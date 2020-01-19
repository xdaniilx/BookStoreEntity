using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BookStore
{
    public partial class FormAddArrival : Form
    {
        public FormAddArrival()
        {
            InitializeComponent();
        }
        //Загрузка формы
        private void FormAddArrival_Load(object sender, EventArgs e)
        {
            cbCategorySearch.SelectedIndex = 0;
            lblParamSum.Text = "0";

            ClassFillTable.FillTable(tableBooks);
            ClassFillBookInfo.FillBookInfo(tableBooks, pictureBoxCover, lblParamGenre, lblParamAuthor,
            lblParamNameBook, lblParamYearPublishing, lblParamCoverType, lblParamPublishing,
            lblParamPageCount, lblParamAgeLimit, lblParamISBN, richTextBoxDescription);
        }
        //Работа с поиском
        //Изменение типа поиска
        private void cbCategorySearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSearch.FillComboBoxSearch(cbCategorySearch, cbSearch);
        }

        //Поиск
        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            ClassSearch.Search(cbCategorySearch.SelectedIndex, cbSearch, tableBooks);
        }

        //Очистка поля поиска
        private void pictureBoxErase_Click(object sender, EventArgs e)
        {
            ClassSearch.Erase(cbCategorySearch, cbSearch);
            ClassFillTable.FillTable(tableBooks);
        }
        //Отображение информации о книге, по щелчку на строку таблицы
        private void tableBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassFillBookInfo.FillBookInfo(tableBooks, pictureBoxCover, lblParamGenre, lblParamAuthor,
            lblParamNameBook, lblParamYearPublishing, lblParamCoverType, lblParamPublishing,
            lblParamPageCount, lblParamAgeLimit, lblParamISBN, richTextBoxDescription);
        }
        //Переход на форму добавления новой книги
        private void btnAddNewBook_Click(object sender, EventArgs e)
        {     
            var fAddBook = new FormAddBook("Add");
            fAddBook.Show();          
        }
        //Переход на форму добавления на основании
        private void btnAddOnTheBasis_Click(object sender, EventArgs e)
        {
            var fAddBook = new FormAddBook(Convert.ToInt32(tableBooks.CurrentRow.Cells[0].Value), "OnTheBasis");
            fAddBook.Show();
        }
        //Выход с формы, переход на форму кладовщика
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            var fWarehouse = new FormWarehouseman();
            fWarehouse.Show();
            Hide();
        }
        //Добавление книг в поступление
        double s = 0;
        private void buttonAddToBasket_Click(object sender, EventArgs e)
        {
            if(numericUpDownQuantity.Value > 0 && !string.IsNullOrWhiteSpace(tbPrice.Text))
            {
                int b = Convert.ToInt32(numericUpDownQuantity.Value);
                decimal m = Math.Round(Convert.ToDecimal(tbPrice.Text), 2);

                tableArrival.ColumnCount = 4;
                tableArrival.Columns[0].Name = "Номер";
                tableArrival.Columns[1].Name = "Название";
                tableArrival.Columns[2].Name = "Количество";
                tableArrival.Columns[3].Name = "Стоимость";

                tableArrival.Columns[0].Width = 80;
                tableArrival.Columns[1].Width = 250;
                tableArrival.Columns[2].Width = 120;
                tableArrival.Columns[3].Width = 120;

                if (tableArrival.RowCount == 0)
                {                    
                        tableArrival.Rows.Add(
                     tableBooks.CurrentRow.Cells[0].Value.ToString(),
                     tableBooks.CurrentRow.Cells[1].Value.ToString(),
                     b,
                     m * b);
                }
                else
                {
                    int k = 0;
                    int i;
                    for (i = 0; i < tableArrival.RowCount; i++)
                    {
                        if (tableBooks.CurrentRow.Cells[0].Value.ToString() == tableArrival.Rows[i].Cells[0].Value.ToString())
                        {
                            k++; break;
                        }
                    }
                    if (k > 0)
                    {
                            b = int.Parse(tableArrival.Rows[i].Cells[2].Value.ToString());
                            b += Convert.ToInt32(numericUpDownQuantity.Value);
                            tableArrival.Rows[i].Cells[0].Value = tableBooks.CurrentRow.Cells[0].Value.ToString();
                            tableArrival.Rows[i].Cells[1].Value = tableBooks.CurrentRow.Cells[1].Value.ToString();
                            tableArrival.Rows[i].Cells[2].Value = b;
                            tableArrival.Rows[i].Cells[3].Value = m * b;
                    }
                    else
                    {
                        b = Convert.ToInt32(numericUpDownQuantity.Value);
                        tableArrival.Rows.Add(
                            tableBooks.CurrentRow.Cells[0].Value.ToString(),
                            tableBooks.CurrentRow.Cells[1].Value.ToString(),
                            b,
                            m * b);
                    }
                }
                for (int i = 0; i < tableArrival.RowCount; i++)
                {
                    s += Convert.ToDouble(tableArrival.Rows[i].Cells[3].Value.ToString());
                }
                lblParamSum.Text = s.ToString();
                s = 0;
            }
            else { MessageBox.Show("Не удается добавить книгу в поступление"); }           
        }
        //Удаление из поступления
        private void pictureBoxDeleteArrivalItem_Click(object sender, EventArgs e)
        {
            if (tableArrival.RowCount > 0)
            {
                tableArrival.Rows.RemoveAt(tableArrival.CurrentRow.Index);
                for (int i = 0; i < tableArrival.RowCount; i++)
                {
                    s += Convert.ToDouble(tableArrival.Rows[i].Cells[3].Value.ToString());
                }
                lblParamSum.Text = s.ToString();
                s = 0;
            }
            else { MessageBox.Show("Список поступления пуст!"); }
        }
        //Оформление поступления
        private void buttonArrival_Click(object sender, EventArgs e)
        {
            if (tableArrival.RowCount > 0)
            {
                using (var connection = ClassConnection.SqlConnection())
                {
                    connection.Open();

                    var commAddToArrival = new SqlCommand(@"INSERT INTO [Arrival] (idWorker, dateOfArrival, sum)
                    VALUES (@idWorker, @dateOfArrival, @sum)", connection);
                    commAddToArrival.Parameters.AddWithValue("@idWorker", ClassActiveUser.WorkerId);
                    commAddToArrival.Parameters.AddWithValue("@dateOfArrival", DateTime.Now);
                    commAddToArrival.Parameters.AddWithValue("@sum", Convert.ToDecimal(lblParamSum.Text));
                    commAddToArrival.ExecuteNonQuery();

                    var commSelMaxId = new SqlCommand(@"SELECT MAX(idArrival) FROM [Arrival]", connection);
                    SqlDataReader readerSelMaxId = commSelMaxId.ExecuteReader();
                    readerSelMaxId.Read();
                    int maxId = Convert.ToInt32(readerSelMaxId[0]);
                    readerSelMaxId.Close();

                    foreach (DataGridViewRow row in tableArrival.Rows)
                    {
                        var commAddToSellBook = new SqlCommand(@"INSERT INTO [ArrivalBook] 
                        (idBook, idArrival, quantity, price1pc) 
                        VALUES (@idBook, @idArrival, @quantity, @price1pc)", connection);
                        commAddToSellBook.Parameters.AddWithValue(@"idBook", Convert.ToInt32(row.Cells[0].Value));
                        commAddToSellBook.Parameters.AddWithValue(@"idArrival", maxId);
                        commAddToSellBook.Parameters.AddWithValue(@"quantity", Convert.ToInt32(row.Cells[2].Value));
                        commAddToSellBook.Parameters.AddWithValue(@"price1pc", Convert.ToDecimal(row.Cells[3].Value) / Convert.ToInt32(row.Cells[2].Value));
                        commAddToSellBook.ExecuteNonQuery();

                        var commUpdWarehouse = new SqlCommand(@"UPDATE [Warehouse]
                        SET quantity = (quantity + " + Convert.ToInt32(row.Cells[2].Value) + "), price = @Price WHERE Warehouse.idBook = " + Convert.ToInt32(row.Cells[0].Value) + "", connection);
                        commUpdWarehouse.Parameters.AddWithValue("@Price", Convert.ToDecimal(row.Cells[3].Value) / Convert.ToDecimal(row.Cells[2].Value));
                        commUpdWarehouse.ExecuteNonQuery();
                    }
                }
                ClassFillTable.FillTable(tableBooks);
                tableArrival.Rows.Clear();
                lblParamSum.Text = "0";
                MessageBox.Show("Поступление оформлено!");
            }
            else { MessageBox.Show("Список поступления пуст!"); }
        }
        //Событие возникает при 
        private void FormAddArrival_Activated(object sender, EventArgs e)
        {
            ClassFillTable.FillTable(tableBooks);
        }       
        //Обработка нажатий поля ввода цены
        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            string textTbPrice = tbPrice.Text;

            if (string.IsNullOrWhiteSpace(tbPrice.Text) || textTbPrice.Contains(","))
            {
                if ((e.KeyChar <= 48 || e.KeyChar >= 58) && number != 8)
                {
                    e.Handled = true;
                }                   
            }
            else if(!Char.IsDigit(number) && number != 8 && number != 44)
            { e.Handled = true; }                         
        }
        //Выход из приложения
        private void FormAddArrival_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
