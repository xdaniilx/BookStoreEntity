using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BookStore
{
    public partial class FormGenresPublishingAuthors : Form
    {
        private string hat;      

        public FormGenresPublishingAuthors(string hat)
        {
            InitializeComponent();
            this.hat = hat;
            switch (hat)
            {
                case "genres": Text = "Книжный магазин - Жанры"; break;
                case "publishing": Text = "Книжный магазин - Издательства"; break;
                case "authors": Text = "Книжный магазин - Авторы"; break;
            }
        }   
        //Заполнение таблицы изданий
        private void FillPublishing()
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT idPublishing as [Номер], 
            namePublishing as [Издательство] 
            FROM [Publishing]", ClassConnection.SqlConnection());
            adapter.Fill(dataSet);

            tableInfo.DataSource = dataSet.Tables[0];
            tableInfo.Columns[0].Width = 80;

            lblInfo1.Text = "Издательство";
        }
        //Заполнение таблицы авторов
        private void FillAuthors()
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT idAuthor as [Номер], 
            shortName as [Сокращенное имя], 
            fullName as [Полное имя] 
            FROM [Author]", ClassConnection.SqlConnection());
            adapter.Fill(dataSet);

            tableInfo.DataSource = dataSet.Tables[0];
            tableInfo.Columns[0].Width = 80;

            panelInfo2.Visible = true;
            lblInfo1.Text = "Сокращенное имя автора";
            lblInfo2.Text = "Полное имя автора";
        }
        //Заполнение таблицы жанров
        private void FillGenres()
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT idGenre as [Номер], genre as [Жанр] FROM 
            [Genre]", ClassConnection.SqlConnection());
            adapter.Fill(dataSet);

            tableInfo.DataSource = dataSet.Tables[0];
            tableInfo.Columns[0].Width = 80;

            lblInfo1.Text = "Жанр";
        }
        //Загрузка формы
        private void FormGenresPublishingAuthors_Load(object sender, EventArgs e)
        {           
            switch (hat)
            {
                case "genres": 
                    {                        
                        FillGenres();
                    }; break;
                case "publishing":
                    {                        
                        FillPublishing();
                    }; break;
                case "authors":
                    {                       
                        FillAuthors();                        
                    }; break;
            }           
        }
        //Заполнение полей для изменения, по щелчку
        private void tableInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (hat)
            {
                case "authors":
                    {
                        tbInfo1.Text = tableInfo.CurrentRow.Cells[1].Value.ToString();
                        tbInfo2.Text = tableInfo.CurrentRow.Cells[2].Value.ToString();
                    }; break;
                default:
                    {
                        tbInfo1.Text = tableInfo.CurrentRow.Cells[1].Value.ToString();
                    }; break;
            }                       
        }
        //Добавление новой информации
        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (hat)
            {
                case "genres":
                    {
                        if (!string.IsNullOrWhiteSpace(tbInfo1.Text))
                        {
                            using (SqlConnection connection = ClassConnection.SqlConnection())
                            {
                                connection.Open();
                                SqlCommand check = new SqlCommand(@"SELECT genre FROM [Genre] WHERE genre = '"+tbInfo1.Text+"'", connection);
                                SqlDataReader reader = check.ExecuteReader();

                                reader.Read();
                                if (reader.HasRows)
                                {
                                    MessageBox.Show("Такой жанр уже существует");
                                    reader.Close();
                                }
                                else
                                {
                                    reader.Close();
                                    SqlCommand command = new SqlCommand(@"INSERT INTO [Genre] (genre) 
                                    VALUES (@Genre)", connection);
                                    command.Parameters.AddWithValue("@Genre", tbInfo1.Text);
                                    command.ExecuteNonQuery();

                                    FillGenres();
                                }
                            }                            
                        }
                        else { MessageBox.Show("Не все поля заполнены"); }
                    }; break;
                case "publishing":
                    {
                        if (!string.IsNullOrWhiteSpace(tbInfo1.Text))
                        {
                            using (SqlConnection connection = ClassConnection.SqlConnection())
                            {
                                connection.Open();

                                SqlCommand check = new SqlCommand(@"SELECT namePublishing FROM [Genre] 
                                WHERE namePublishing = '"+tbInfo1.Text+"'", connection);
                                SqlDataReader reader = check.ExecuteReader();

                                reader.Read();
                                if (reader.HasRows)
                                {
                                    MessageBox.Show("Такое издательство уже существует");
                                    reader.Close();
                                }
                                else
                                {
                                    reader.Close();
                                    SqlCommand command = new SqlCommand(@"INSERT INTO [Publishing] (namePublishing) 
                                    VALUES (@NamePublishing)", connection);
                                    command.Parameters.AddWithValue("@NamePublishing", tbInfo1.Text);
                                    command.ExecuteNonQuery();

                                    FillPublishing();
                                }
                            }
                        }
                        else { MessageBox.Show("Не все поля заполнены"); }
                    }; break;
                case "authors":
                    {
                        if (!string.IsNullOrWhiteSpace(tbInfo1.Text) && !string.IsNullOrWhiteSpace(tbInfo2.Text))
                        {
                            using (SqlConnection connection = ClassConnection.SqlConnection())
                            {
                                connection.Open();
                                SqlCommand check = new SqlCommand(@"SELECT shortName FROM [Author]
                                WHERE shortName ='"+tbInfo1.Text+"'", connection);
                                SqlDataReader reader = check.ExecuteReader();

                                reader.Read();
                                if (reader.HasRows)
                                {
                                    MessageBox.Show("Такой автор уже существует");
                                    reader.Close();
                                }
                                else
                                {
                                    reader.Close();
                                    SqlCommand command = new SqlCommand(@"INSERT INTO [Author] (shortName, fullName) 
                                    VALUES (@ShortName, @FullName)", connection);
                                    command.Parameters.AddWithValue("@ShortName", tbInfo1.Text);
                                    command.Parameters.AddWithValue("@FullName", tbInfo2.Text);
                                    command.ExecuteNonQuery();

                                    FillAuthors();
                                }                              
                            }
                        }
                        else { MessageBox.Show("Не все поля заполнены"); }
                    }; break;
            }
        }
        //Изменение существующей информации
        private void btnEdit_Click(object sender, EventArgs e)
        {
            switch (hat)
            {
                case "genres":
                    {
                        if (tbInfo1.TextLength != 0)
                        {
                            using (SqlConnection connection = ClassConnection.SqlConnection())
                            {
                                connection.Open();

                                SqlCommand check = new SqlCommand(@"SELECT genre FROM [Genre] WHERE genre = @Genre", connection);
                                check.Parameters.AddWithValue("@Genre", tbInfo1.Text);
                                SqlDataReader reader = check.ExecuteReader();

                                reader.Read();
                                if (reader.HasRows)
                                {
                                    MessageBox.Show("Такой жанр уже существует");
                                    reader.Close();
                                }
                                else
                                {
                                    reader.Close();
                                    SqlCommand command = new SqlCommand(@"UPDATE [Genre] SET genre = @Genre
                                    WHERE idGenre = @TableGenre", connection);
                                    command.Parameters.AddWithValue("@Genre", tbInfo1.Text);
                                    command.Parameters.AddWithValue("@TableGenre", tableInfo.CurrentRow.Cells[0].Value.ToString());
                                    command.ExecuteNonQuery();

                                    FillGenres();
                                }                              
                            }
                        }
                        else { MessageBox.Show("Не все поля заполнены"); }
                    }; break;
                case "publishing":
                    {
                        if (tbInfo1.TextLength != 0)
                        {
                            using (SqlConnection connection = ClassConnection.SqlConnection())
                            {
                                connection.Open();
                                string checkPublishing = "SELECT namePublishing FROM [Publishing] WHERE namePublishing = " + tbInfo1.Text + "";
                                SqlCommand check = new SqlCommand(checkPublishing, connection);
                                SqlDataReader reader = check.ExecuteReader();

                                reader.Read();
                                if (reader.HasRows)
                                {
                                    MessageBox.Show("Такое издательство уже существует");
                                    reader.Close();
                                }
                                else
                                {
                                    reader.Close();
                                    SqlCommand command = new SqlCommand(@"UPDATE [Publishing] SET namePublishing = @NamePublishing
                                    WHERE idPublishing = @IdPublishing", connection);
                                    command.Parameters.AddWithValue("@NamePublishing", tbInfo1.Text);
                                    command.Parameters.AddWithValue("@IdPublishing", tableInfo.CurrentRow.Cells[0].Value.ToString());
                                    command.ExecuteNonQuery();

                                    FillPublishing();
                                }                                
                            }
                        }
                        else { MessageBox.Show("Не все поля заполнены"); }
                    }; break;
                case "authors":
                    {
                        if (tbInfo1.TextLength != 0 && tbInfo2.TextLength != 0)
                        {
                            using (SqlConnection connection = ClassConnection.SqlConnection())
                            {
                                connection.Open();

                                SqlCommand check = new SqlCommand(@"SELECT fullName FROM [Author]
                                WHERE fullName = @FullName", connection);
                                check.Parameters.AddWithValue("@FullName", tbInfo2.Text);
                                SqlDataReader reader = check.ExecuteReader();

                                reader.Read();
                                if (reader.HasRows)
                                {
                                    MessageBox.Show("Такой автор уже существует");
                                    reader.Close();
                                }
                                else
                                {
                                    reader.Close();
                                    SqlCommand command = new SqlCommand(@"UPDATE [Author] SET 
                                    shortName = @ShortName, fullName = @FullName 
                                    WHERE idAuthor = @IdAuthor", connection);
                                    command.Parameters.AddWithValue("@ShortName", tbInfo1.Text);
                                    command.Parameters.AddWithValue("@FullName", tbInfo2.Text);
                                    command.Parameters.AddWithValue("@IdAuthor", tableInfo.CurrentRow.Cells[0].Value.ToString());
                                    command.ExecuteNonQuery();

                                    FillAuthors();
                                }
                            }
                        }
                        else { MessageBox.Show("Не все поля заполнены"); }
                    }; break;
            }
        }
        //Удаление
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqlQueryDel;
            switch (hat)
            {
                case "genres":
                    {
                        sqlQueryDel = @"DELETE [Genre] WHERE idGenre = @Param";
                        ClassAddInfo.DeleteInfo(sqlQueryDel, tableInfo);
                        FillGenres();
                        
                    }; break;
                case "publishing":
                    {
                        sqlQueryDel = @"DELETE [Publishing] WHERE idPublishing = @Param";
                        ClassAddInfo.DeleteInfo(sqlQueryDel, tableInfo);
                        FillPublishing();                       
                    }; break;
                case "authors":
                    {
                        sqlQueryDel = @"DELETE [Author] WHERE idAuthor = @Param";
                        ClassAddInfo.DeleteInfo(sqlQueryDel, tableInfo);
                        FillAuthors();
                        
                    }; break;
            }
        }
        //Выход с формы
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            var fWarehouseman = new FormWarehouseman();
            fWarehouseman.Show();
            Hide();
        }
        private void FormGenresPublishingAuthors_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
