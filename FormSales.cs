using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;
namespace BookStore
{
    public partial class FormSales : Form
    {        
        public FormSales()
        {
            InitializeComponent();
        }
        //Загрузка формы
        private void FormSales_Load(object sender, EventArgs e)
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
        //Показ информации о книге
        private void tableBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassFillBookInfo.FillBookInfo(tableBooks, pictureBoxCover, lblParamGenre, lblParamAuthor,
            lblParamNameBook, lblParamYearPublishing, lblParamCoverType, lblParamPublishing,
            lblParamPageCount, lblParamAgeLimit, lblParamISBN, richTextBoxDescription);
        }     
        //Добавление книг в корзину     
        double s = 0;
        private void buttonAddToBasket_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(numericUpDownQuantity.Value);

            tableSell.ColumnCount = 4;
            tableSell.Columns[0].Name = "Номер";
            tableSell.Columns[1].Name = "Название";
            tableSell.Columns[2].Name = "Количество";
            tableSell.Columns[3].Name = "Стоимость";

            tableSell.Columns[0].Width = 80;
            tableSell.Columns[1].Width = 250;
            tableSell.Columns[2].Width = 120;
            tableSell.Columns[3].Width = 120;

            if (tableSell.RowCount == 0)
            {             
                if (b <= Convert.ToInt32(tableBooks.CurrentRow.Cells[2].Value))
                {
                    tableSell.Rows.Add(
                 tableBooks.CurrentRow.Cells[0].Value.ToString(),
                 tableBooks.CurrentRow.Cells[1].Value.ToString(),
                 b,
                 Convert.ToDouble(tableBooks.CurrentRow.Cells[3].Value) * b);
                }
                else { MessageBox.Show("Нет такого количества!"); }                
            }
            else
            {
                int k = 0;
                int i;
                for (i = 0; i < tableSell.RowCount; i++)
                {
                    if (tableBooks.CurrentRow.Cells[0].Value.ToString() == tableSell.Rows[i].Cells[0].Value.ToString())
                    {
                        k++; break;
                    }
                }
                if (k > 0)
                {
                    if (b <= (Convert.ToInt32(tableBooks.CurrentRow.Cells[2].Value) - Convert.ToInt32(tableSell.Rows[i].Cells[2].Value)))
                    {
                        b = int.Parse(tableSell.Rows[i].Cells[2].Value.ToString());
                        b += Convert.ToInt32(numericUpDownQuantity.Value);
                        tableSell.Rows[i].Cells[0].Value = tableBooks.CurrentRow.Cells[0].Value.ToString();
                        tableSell.Rows[i].Cells[1].Value = tableBooks.CurrentRow.Cells[1].Value.ToString();
                        tableSell.Rows[i].Cells[2].Value = b;
                        tableSell.Rows[i].Cells[3].Value = Convert.ToDouble(tableBooks.CurrentRow.Cells[3].Value) * b;
                    }
                    else { MessageBox.Show("Нет такого количества!"); }
                }
                else
                {
                        b = Convert.ToInt32(numericUpDownQuantity.Value);
                        tableSell.Rows.Add(
                            tableBooks.CurrentRow.Cells[0].Value.ToString(),
                            tableBooks.CurrentRow.Cells[1].Value.ToString(),
                            b,
                            Convert.ToDouble(tableBooks.CurrentRow.Cells[3].Value.ToString()) * b);
                }
            }
            for (int i = 0; i < tableSell.RowCount; i++)
            {
                s += Convert.ToDouble(tableSell.Rows[i].Cells[3].Value.ToString());
            }
            lblParamSum.Text = s.ToString();
            s = 0;
        }
        //Удаление книги из корзины
        private void pictureBoxDeleteSellItem_Click(object sender, EventArgs e)
        {
            if (tableSell.RowCount > 0)
            {
                tableSell.Rows.RemoveAt(tableSell.CurrentRow.Index);
                for (int i = 0; i < tableSell.RowCount; i++)
                {
                    s += Convert.ToDouble(tableSell.Rows[i].Cells[3].Value.ToString());
                }
                lblParamSum.Text = s.ToString();
                s = 0;
            }
            else { MessageBox.Show("Нечего удалять!"); }
        }
        //Продажа
        private void buttonSell_Click(object sender, EventArgs e)
        {
            if(tableSell.RowCount > 0)
            {
                using(var connection = ClassConnection.SqlConnection())
                {
                    connection.Open();

                    var commandAddToSell = new SqlCommand(@"INSERT INTO [Sell] (idWorker, dateOfSale, sum)
                    VALUES (@idWorker, @dateOfSale, @sum)", connection);
                    commandAddToSell.Parameters.AddWithValue("@idWorker", ClassActiveUser.WorkerId);
                    commandAddToSell.Parameters.AddWithValue("@dateOfSale", DateTime.Now);
                    commandAddToSell.Parameters.AddWithValue("@sum", Convert.ToDecimal(lblParamSum.Text));
                    commandAddToSell.ExecuteNonQuery();

                    var commandSelectMaxId = new SqlCommand(@"SELECT MAX(idSell) FROM [Sell]", connection);
                    SqlDataReader readerSelectMaxId = commandSelectMaxId.ExecuteReader();
                    readerSelectMaxId.Read();
                    int maxId = Convert.ToInt32(readerSelectMaxId[0]);
                    readerSelectMaxId.Close();

                    foreach (DataGridViewRow row in tableSell.Rows)
                    {
                        var commandAddToSellBook = new SqlCommand(@"INSERT INTO [SellBook] 
                        (idBook, idSell, quantity, price1pc) 
                        VALUES (@idBook, @idSell, @quantity, @price1pc)", connection);
                        commandAddToSellBook.Parameters.AddWithValue(@"idBook", Convert.ToInt32(row.Cells[0].Value));
                        commandAddToSellBook.Parameters.AddWithValue(@"idSell", maxId);
                        commandAddToSellBook.Parameters.AddWithValue(@"quantity", Convert.ToInt32(row.Cells[2].Value));
                        commandAddToSellBook.Parameters.AddWithValue(@"price1pc", Convert.ToInt32(row.Cells[3].Value) / Convert.ToInt32(row.Cells[2].Value));
                        commandAddToSellBook.ExecuteNonQuery();

                        var commandUpdateWarehouse = new SqlCommand(@"UPDATE [Warehouse]
                        SET quantity = (quantity - "+Convert.ToInt32(row.Cells[2].Value)+") WHERE Warehouse.idBook = "+Convert.ToInt32(row.Cells[0].Value)+"", connection);
                        commandUpdateWarehouse.ExecuteNonQuery();
                    }            
                }
                
                MessageBox.Show("Продажа произведена успешно!");

                //Печать чека

                    Word.Application wordapp = new Word.Application();
                    wordapp.Visible = true;
                    Object template = Environment.CurrentDirectory + "\\TovarCheck.dotx";
                    Object newTemplate = false;
                    Object documentType = Word.WdNewDocumentType.wdNewBlankDocument;
                    Object visible = true;
                    Word._Document worddoc;
                    //Создаем документ 1
                    worddoc = wordapp.Documents.Add(ref template, ref newTemplate, ref documentType, ref
                   visible);
                    Object bookmarkNameObj = "Date";
                    Word.Range bookmarkRange = null;
                    bookmarkRange = worddoc.Bookmarks.get_Item(ref bookmarkNameObj).Range;
                    bookmarkRange.Text = Convert.ToDateTime(DateTime.Now).ToString();

                    bookmarkNameObj = "Number";
                    bookmarkRange = null;
                    bookmarkRange = worddoc.Bookmarks.get_Item(ref bookmarkNameObj).Range;
                    using (var connection = ClassConnection.SqlConnection())
                    {
                        connection.Open();
                        var comSelNumber = new SqlCommand(@"SELECT MAX(idSell) FROM [Sell]", connection);
                        SqlDataReader readerNumber = comSelNumber.ExecuteReader();
                        readerNumber.Read();
                        string sellNumber = readerNumber[0].ToString();
                        readerNumber.Close();
                        bookmarkRange.Text = sellNumber;
                    }
           
                    bookmarkNameObj = "FIO";
                    bookmarkRange = null;
                    bookmarkRange = worddoc.Bookmarks.get_Item(ref bookmarkNameObj).Range;
                    using(var connection = ClassConnection.SqlConnection())
                    {
                        connection.Open();
                        var comSelWorker = new SqlCommand(@"SELECT fullName FROM [Worker]
                        WHERE idWorker = "+ClassActiveUser.WorkerId+"", connection);
                        SqlDataReader readerWorker = comSelWorker.ExecuteReader();
                        readerWorker.Read();
                        string workerFullName = readerWorker[0].ToString();
                        readerWorker.Close();
                        bookmarkRange.Text = workerFullName;
                    }
                    
                    bookmarkNameObj = "Total";
                    bookmarkRange = null;
                    bookmarkRange = worddoc.Bookmarks.get_Item(ref bookmarkNameObj).Range;
                    bookmarkRange.Text = lblParamSum.Text;

                    bookmarkNameObj = "Table";
                    bookmarkRange = null;
                    bookmarkRange = worddoc.Bookmarks.get_Item(ref bookmarkNameObj).Range;
                    Object behiavor = Word.WdDefaultTableBehavior.wdWord9TableBehavior;
                    Object autoFitBehiavor = Word.WdAutoFitBehavior.wdAutoFitFixed;
                    int rows = tableSell.RowCount+1;
                    int columns = 4;
                    worddoc.Tables.Add(bookmarkRange, rows, columns, ref behiavor, ref autoFitBehiavor);
                    worddoc.Tables[1].Cell(1, 1).Range.Text = "№";
                    worddoc.Tables[1].Cell(1, 2).Range.Text = "Наименование товара";
                    worddoc.Tables[1].Cell(1, 3).Range.Text = "Количество";
                    worddoc.Tables[1].Cell(1, 4).Range.Text = "Цена";
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                        if(tableSell.Rows.Count > i)
                            worddoc.Tables[1].Cell(i + 2, j + 1).Range.Text = tableSell.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                ClassFillTable.FillTable(tableBooks);
                tableSell.Rows.Clear();
                lblParamSum.Text = "0";
            }
            else { MessageBox.Show("Нечего продавать!"); }
        }
        //Выход на форму авторизации
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            FormAuthorization formAuthorization = new FormAuthorization();
            formAuthorization.Show();
            Hide();
        }
        private void FormSales_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

