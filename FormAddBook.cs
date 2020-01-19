using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace BookStore
{
    public partial class FormAddBook : Form
    {
        private int idBook;
        string newPath;
        string whoEnter;
        public FormAddBook(int idBook, string whoEnter)
        {
            InitializeComponent();
            this.idBook = idBook;
            this.whoEnter = whoEnter;
            if(whoEnter == "OnTheBasis")
            {
                Text = "Книжный магазин - Добавление книги";
                btnEditBook.Visible = false;
            }
            else
            {
                Text = "Книжный магазин - Изменение информации о книге";
                btnAddBook.Visible = false;
            }                  
        }
        public FormAddBook(string whoEnter)
        {
            InitializeComponent();
            this.whoEnter = whoEnter;
            Text = "Книжный магазин - Добавление книги";
            btnEditBook.Visible = false;
        }
        private void FormAddBook_Load(object sender, EventArgs e)
        {
            tableAuthor.ColumnCount = 2;
            tableAuthor.Columns[0].Visible = false;
            tableGenre.ColumnCount = 2;          
            tableGenre.Columns[0].Visible = false;

            cbAgeLimit.SelectedIndex = 0;
            cbCoverType.SelectedIndex = 0;
            cbAddNew.SelectedIndex = 0;

            FillPublishing();
            FillAuthors();
            FillGenres();
            if(whoEnter == "Edit" || whoEnter == "OnTheBasis") { FillInformationForEdit(); }                            
        }
        //Заполнение информации для изменения
        private void FillInformationForEdit()
        {
            using (SqlConnection connection = ClassConnection.SqlConnection())
            {
                connection.Open();              
                var commandAuthor = new SqlCommand(@"SELECT Author.idAuthor, Author.shortName 
                FROM [Author], [Book], [BookAuthor] 
                WHERE Book.idBook = "+idBook+" AND Author.idAuthor = BookAuthor.idAuthor AND BookAuthor.idBook = Book.idBook", connection);
                var readerAuthor = commandAuthor.ExecuteReader();
                if (readerAuthor.HasRows)
                {
                    while (readerAuthor.Read())
                    {
                        tableAuthor.Rows.Add(readerAuthor[0], readerAuthor[1]);
                    }
                    readerAuthor.Close();
                }
                readerAuthor.Close();

                var commandGenre = new SqlCommand(@"SELECT Genre.idGenre, Genre.genre 
                FROM [Genre], [Book], [BookGenre] 
                WHERE Book.idBook = '" + idBook + "' AND Genre.idGenre = BookGenre.idGenre AND Book.idBook = BookGenre.idBook", connection);
                var readerGenre = commandGenre.ExecuteReader();
                if (readerGenre.HasRows)
                {
                    while (readerGenre.Read())
                    {
                        tableGenre.Rows.Add(readerGenre[0], readerGenre[1]);
                    }
                    readerGenre.Close();
                }
                readerGenre.Close();

                var commandBookInfo = new SqlCommand(@"SELECT Book.name,
                Book.yearOfPublishing, Book.CoverType, Publishing.namePublishing, Book.pageCount,
                Book.ageLimit, Book.ISBN, Book.description, Book.cover
                FROM [Book], [Author], [BookAuthor], [Genre], [BookGenre], [Publishing]
                WHERE Book.idBook = '" + idBook + "' AND " +
                "Author.idAuthor = BookAuthor.idAuthor AND " +
                "BookAuthor.idBook = Book.idBook AND " +
                "Genre.idGenre = BookGenre.idGenre AND " +
                "Book.idBook = BookGenre.idBook AND " +
                "Book.idPublishing = Publishing.idPublishing", connection);
                SqlDataReader reader = commandBookInfo.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tbNameBook.Text = reader[0].ToString();
                        tbYearOfPublishing.Text = reader[1].ToString();
                        cbCoverType.Text = reader[2].ToString();
                        cbPublishing.Text = reader[3].ToString();
                        numericUpDownPageCount.Text = reader[4].ToString();
                        cbAgeLimit.Text = reader[5].ToString();
                        tbISBN.Text = reader[6].ToString();
                        richTextBoxDescription.Text = reader[7].ToString();

                        string path = reader[8].ToString();
                        newPath = reader[8].ToString();
                        if (path != "")
                        {
                            Bitmap image = new Bitmap(path);
                            pictureBoxCover.Image = image;
                        }
                        else
                        {
                            pictureBoxCover.Image = pictureBoxCover.ErrorImage;
                        }
                    }
                    reader.Close();
                }
            }         
        }
        //Заполнение списка издательств
        private void FillPublishing()
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT idPublishing, namePublishing FROM 
            [Publishing]", ClassConnection.SqlConnection());
            adapter.Fill(dataSet);

            cbPublishing.DataSource = dataSet.Tables[0];
            cbPublishing.DisplayMember = "namePublishing";
            cbPublishing.ValueMember = "idPublishing";
        }
        //Заполнение списка авторов
        private void FillAuthors()
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT idAuthor, shortName FROM 
            [Author]", ClassConnection.SqlConnection());
            adapter.Fill(dataSet);

            cbAuthor.DataSource = dataSet.Tables[0];
            cbAuthor.DisplayMember = "shortName";
            cbAuthor.ValueMember = "idAuthor";
        }
        //Заполнение списка жанров
        private void FillGenres()
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT idGenre, genre FROM 
            [Genre]", ClassConnection.SqlConnection());
            adapter.Fill(dataSet);

            cbGenre.DataSource = dataSet.Tables[0];
            cbGenre.DisplayMember = "genre";
            cbGenre.ValueMember = "idGenre";
        }
        //Добавление новой книги
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNameBook.Text) && !string.IsNullOrWhiteSpace(tbYearOfPublishing.Text) &&
                !string.IsNullOrWhiteSpace(tbISBN.Text) && !string.IsNullOrWhiteSpace(cbAgeLimit.Text) &&
                !string.IsNullOrWhiteSpace(cbCoverType.Text) && !string.IsNullOrWhiteSpace(richTextBoxDescription.Text) &&
                !string.IsNullOrWhiteSpace(cbPublishing.Text) && numericUpDownPageCount.Value > 0 &&
                tableAuthor.RowCount > 0 && tableGenre.RowCount > 0)
            {
                using (SqlConnection connection = ClassConnection.SqlConnection())
                {
                    connection.Open();

                    var commInsBook = new SqlCommand(@"INSERT INTO [Book]
                    (name, yearOfPublishing, pageCount, ageLimit, ISBN, cover, coverType, description, idPublishing) 
                    VALUES (@nameBook, @yearOfPublishing, @pageCount, @ageLimit, @ISBN, @cover, @coverType, 
                    @description, @idPublishing)", connection);

                    commInsBook.Parameters.AddWithValue("@nameBook", tbNameBook.Text);
                    commInsBook.Parameters.AddWithValue("@yearOfPublishing", Convert.ToInt32(tbYearOfPublishing.Text));
                    commInsBook.Parameters.AddWithValue("@pageCount", Convert.ToInt32(numericUpDownPageCount.Value));
                    commInsBook.Parameters.AddWithValue("@ageLimit", cbAgeLimit.Text);
                    commInsBook.Parameters.AddWithValue("@ISBN", tbISBN.Text);
                    commInsBook.Parameters.AddWithValue("@cover", newPath);
                    commInsBook.Parameters.AddWithValue("@coverType", cbCoverType.Text);
                    commInsBook.Parameters.AddWithValue("@description", richTextBoxDescription.Text);
                    commInsBook.Parameters.AddWithValue("@idPublishing", cbPublishing.SelectedValue);

                    commInsBook.ExecuteNonQuery();

                    var commSelMaxId = new SqlCommand(@"SELECT MAX(idBook) FROM [Book]", connection);
                    SqlDataReader readerSelMaxId = commSelMaxId.ExecuteReader();
                    readerSelMaxId.Read();
                    int maxId = Convert.ToInt32(readerSelMaxId[0]);
                    readerSelMaxId.Close();

                    foreach (DataGridViewRow row in tableGenre.Rows)
                    {
                        var commInsGenre = new SqlCommand(@"INSERT INTO [BookGenre] 
                        (idBook, idGenre) VALUES (" + maxId + ", " + Convert.ToInt32(row.Cells[0].Value) + ")", connection);
                        commInsGenre.ExecuteNonQuery();
                    }
                    foreach (DataGridViewRow row in tableAuthor.Rows)
                    {
                        var commInsAuthor = new SqlCommand(@"INSERT INTO [BookAuthor] 
                        (idBook, idAuthor) VALUES (" + maxId + ", " + Convert.ToInt32(row.Cells[0].Value) + ")", connection);
                        commInsAuthor.ExecuteNonQuery();
                    }
                    var commInsWarehouse = new SqlCommand(@"INSERT INTO [Warehouse] (idBook, quantity, price)
                    VALUES (" + maxId + ", 0, 0)", connection);
                    commInsWarehouse.ExecuteNonQuery();

                    MessageBox.Show("Книга успешно добавлена!");
                    Hide();
                }
            }
            else MessageBox.Show("Не все поля заполены!");
        }
        //Изменение информации о книге
        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNameBook.Text) && !string.IsNullOrWhiteSpace(tbYearOfPublishing.Text) &&
                !string.IsNullOrWhiteSpace(tbISBN.Text) && !string.IsNullOrWhiteSpace(cbAgeLimit.Text) &&
                !string.IsNullOrWhiteSpace(cbCoverType.Text) && !string.IsNullOrWhiteSpace(richTextBoxDescription.Text) &&
                !string.IsNullOrWhiteSpace(cbPublishing.Text) && numericUpDownPageCount.Value > 0 &&
                tableAuthor.RowCount > 0 && tableGenre.RowCount > 0)
            {
                using (SqlConnection connection = ClassConnection.SqlConnection())
                {
                    connection.Open();

                    SqlCommand commandUpdate = new SqlCommand(@"UPDATE [Book]
                    SET Book.name = @nameBook, Book.yearOfPublishing = @yearOfPublishing, 
                    Book.pageCount = @pageCount, Book.ageLimit = @ageLimit,
                    Book.ISBN = @ISBN, Book.cover = @cover, Book.coverType = @coverType,
                    Book.description = @description, Book.idPublishing = @idPublishing              
                    WHERE Book.idBook = '" + idBook + "'", connection);

                    commandUpdate.Parameters.AddWithValue("@nameBook", tbNameBook.Text);
                    commandUpdate.Parameters.AddWithValue("@yearOfPublishing", Convert.ToInt32(tbYearOfPublishing.Text));
                    commandUpdate.Parameters.AddWithValue("@pageCount", Convert.ToInt32(numericUpDownPageCount.Value));
                    commandUpdate.Parameters.AddWithValue("@ageLimit", cbAgeLimit.Text);
                    commandUpdate.Parameters.AddWithValue("@ISBN", tbISBN.Text);
                    commandUpdate.Parameters.AddWithValue("@cover", newPath);
                    commandUpdate.Parameters.AddWithValue("@coverType", cbCoverType.Text);
                    commandUpdate.Parameters.AddWithValue("@description", richTextBoxDescription.Text);
                    commandUpdate.Parameters.AddWithValue("@idPublishing", cbPublishing.SelectedValue);

                    commandUpdate.ExecuteNonQuery();

                    SqlCommand commDeleteGenre = new SqlCommand(@"DELETE FROM [BookGenre] WHERE idBook = " + idBook + "", connection);
                    commDeleteGenre.ExecuteNonQuery();

                    SqlCommand commDeleteAuthor = new SqlCommand(@"DELETE FROM [BookAuthor] WHERE idBook = " + idBook + "", connection);
                    commDeleteAuthor.ExecuteNonQuery();

                    foreach (DataGridViewRow row in tableGenre.Rows)
                    {
                        SqlCommand commInsertGenre = new SqlCommand(@"INSERT INTO [BookGenre] 
                        (idBook, idGenre) VALUES (" + idBook + ", " + Convert.ToInt32(row.Cells[0].Value) + ")", connection);
                        commInsertGenre.ExecuteNonQuery();
                    }
                    foreach (DataGridViewRow row in tableAuthor.Rows)
                    {
                        SqlCommand commInsertAuthor = new SqlCommand(@"INSERT INTO [BookAuthor] 
                        (idBook, idAuthor) VALUES (" + idBook + ", " + Convert.ToInt32(row.Cells[0].Value) + ")", connection);
                        commInsertAuthor.ExecuteNonQuery();
                    }

                    MessageBox.Show("Информация о книге успешно изменена!");
                    var fWarehouseman = new FormWarehouseman();
                    fWarehouseman.Show();
                    Hide();
                }
            }
            else MessageBox.Show("Не все поля заполены!");
        }
        //Добавление или изменение обложки
        private void buttonAddCover_Click(object sender, EventArgs e)
        {
            Bitmap image;
            pictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage;

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    string path = open_dialog.FileName;                   
                    File.Copy(path, Path.Combine(Application.StartupPath + "\\Covers" , new FileInfo(path).Name), true);                   
                    newPath = "Covers/" + Path.GetFileName(open_dialog.FileName);
                    this.pictureBoxCover.Size = image.Size;
                    pictureBoxCover.Image = image;                    
                    pictureBoxCover.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Выход из формы
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            switch (whoEnter)
            {
                case "Edit":
                    {
                        var fWarehouseman = new FormWarehouseman();
                        fWarehouseman.Show();
                        Hide();
                    }; break;
                default: { Hide(); }; break;
            }
        }
        //Добавление автора в список
        private void pictureBoxAddAuthor_Click(object sender, EventArgs e)
        { tableAuthor.Rows.Add(cbAuthor.SelectedValue, cbAuthor.Text); }
        //Добавление жанра в список
        private void pictureBoxAddGenre_Click(object sender, EventArgs e)
        { tableGenre.Rows.Add(cbGenre.SelectedValue, cbGenre.Text); }
        //Удаление  жанра из списка
        private void pictureBoxDeleteGenre_Click(object sender, EventArgs e)
        {
            if (tableGenre.RowCount > 0) tableGenre.Rows.RemoveAt(tableGenre.CurrentRow.Index);           
            else MessageBox.Show("Нечего удалять");        
        }
        //Удаление автора из списка
        private void pictureBoxDeleteAuthor_Click(object sender, EventArgs e)
        {
            if(tableAuthor.RowCount > 0) tableAuthor.Rows.RemoveAt(tableAuthor.CurrentRow.Index);            
            else MessageBox.Show("Нечего удалять");           
        }      
        //Добавление нового издательства, жанра или автора      
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string type = tbAddNew.Text;
            string sqlQuery;

            switch (cbAddNew.SelectedIndex)
            {
                case 0:
                    {
                        sqlQuery = @"INSERT INTO [Author] (shortName, fullName) 
                        VALUES ('" + type + "', '" + type + "')";
                        ClassAddInfo.AddInfo(type, sqlQuery, cbAuthor);                        
                        FillAuthors();
                    }; break;
                case 1:
                    {
                        sqlQuery = @"INSERT INTO [Genre] (genre) 
                        VALUES ('" + type + "')";
                        ClassAddInfo.AddInfo(type, sqlQuery, cbGenre);
                        FillGenres();
                    }; break;
                case 2:
                    {
                        sqlQuery = @"INSERT INTO [Publishing] (namePublishing) 
                        VALUES ('" + type + "')";
                        ClassAddInfo.AddInfo(type, sqlQuery, cbPublishing);
                        FillPublishing();
                    }; break;
            }
        }
        private void FormAddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }                       
}
