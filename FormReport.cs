using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using BookStore.Models;
namespace BookStore
{
    public partial class FormReport : Form
    {
        string typeReport;
        string sqlReport;
        string sqlReportBook;

        public FormReport(string typeReport)
        {            
            InitializeComponent();

            this.typeReport = typeReport;
            if (typeReport == "arrival")
            {
                Text = "Книжный магазин - Поступления";
                lblParamTypeReport.Text = "Поступления";
            }
            if(typeReport == "sell")
            {
                Text = "Книжный магазин - Продажи";
                lblParamTypeReport.Text = "Продажи";
            }
            if (typeReport == "popularbook")
            {
                Text = "Книжный магазин - Популярные книги";
                lblParamTypeReport.Text = "Популярные книги";
                panelDate.Visible = false;
                panelTotal.Visible = false;
                sqlReportBook = @"SELECT Book.name as [Название книги], 
                        Publishing.namePublishing as [Издательство], Book.yearOfPublishing as [Год издания] 
                        FROM [Book], [Publishing] WHERE Book.idPublishing = Publishing.idPublishing AND
                        Book.idBook = @idBook";
            }
        }
        //Загрузка формы
        private void FormReport_Load(object sender, EventArgs e)
        {
            dateTimePickerBegin.Value = DateTime.Today;
            if(typeReport == "popularbook")
            {
                FillTablePopularBook();
            }
        }      
        //Вывод в таблицу отчета
        private void FillTable()
        {            
            using(SqlConnection connection = ClassConnection.SqlConnection())
            {
                connection.Open();

                var dataSetArrival = new DataSet();
                var adapterArrival = new SqlDataAdapter(sqlReport, connection);
                adapterArrival.SelectCommand.Parameters.AddWithValue("@dateOfBegin", dateTimePickerBegin.Value);
                adapterArrival.SelectCommand.Parameters.AddWithValue("@dateOfEnd", dateTimePickerEnd.Value);
                adapterArrival.Fill(dataSetArrival);
                tableReport.DataSource = dataSetArrival.Tables[0];

                tableReport.Columns[0].Width = 80;               
                tableReport.Columns[1].Width = 250;
                tableReport.Columns[2].Width = 110;
                tableReport.Columns[3].Width = 150; 
            }
        }
        //Вывод в таблицу книг по популярности
        private void FillTablePopularBook()
        {
            var popularBook = (from book in ClassGetContext.context.Books
                               join sellbook in ClassGetContext.context.SellBooks on book.idBook equals sellbook.idBook
                               join sell in ClassGetContext.context.Sells on sellbook.idSell equals sell.idSell
                               group sellbook by new {book.idBook, book.name} into sumOnBook
                               select new 
                               { 
                                   sumOnBook.Key.idBook, 
                                   sumOnBook.Key.name, 
                                   P = sumOnBook.Sum(c => c.quantity),
                               }).FirstOrDefault();
            

            //using (SqlConnection connection = ClassConnection.SqlConnection())
            //{
            //    connection.Open();

            //    var dataSetPopularBook = new DataSet();
            //    var adapterPopularBook = new SqlDataAdapter(@"SELECT Book.idBook as [Код], 
            //    Book.name as [Название книги], 
            //    SUM(SellBook.quantity) as [Количество проданых книг]
            //    FROM [Sell], [SellBook], [Book]
            //    WHERE Book.idBook = SellBook.idBook AND SellBook.idSell = Sell.idSell 
            //    GROUP BY Book.idBook, Book.name ORDER BY [Количество проданых книг] desc", connection);
            //    adapterPopularBook.Fill(dataSetPopularBook);
            //    tableReport.DataSource = dataSetPopularBook.Tables[0];

            //    tableReport.Columns[0].Width = 30;
            //    tableReport.Columns[1].Width = 100;
            //    tableReport.Columns[2].Width = 150;
            //}
        }
        //Заполнение таблицы с информацией
        private void FillArrivalBookTable()
        {
            using (SqlConnection connection = ClassConnection.SqlConnection())
            {
                connection.Open();
                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlReportBook, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@idBook", Convert.ToInt32(tableReport.CurrentRow.Cells[0].Value));
                adapter.Fill(dataSet);
                tableReportBook.DataSource = dataSet.Tables[0];

                tableReportBook.Columns[0].Width = 250;
                tableReportBook.Columns[1].Width = 80;
                tableReportBook.Columns[2].Width = 150;
                tableReportBook.Columns[3].Width = 110;
            }
        }
        //Заполнение информации о книге
        private void FillPopularBookInfo()
        {
            using (SqlConnection connection = ClassConnection.SqlConnection())
            {
                connection.Open();

                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlReportBook, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@idBook", Convert.ToInt32(tableReport.CurrentRow.Cells[0].Value));
                adapter.Fill(dataSet);
                tableReportBook.DataSource = dataSet.Tables[0];

                tableReportBook.Columns[0].Width = 250;
                tableReportBook.Columns[1].Width = 80;
                tableReportBook.Columns[2].Width = 150;
            }
        }
        //Отображение информации
        private void tableArrival_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (typeReport != "popularbook")
                FillArrivalBookTable();
            else
                FillPopularBookInfo();           
        }
        //Кнопка формирования отчета     
        int quantity = 0;
        double sum = 0;
        private void btnConfirm_Click(object sender, EventArgs e)
        {          
            switch (typeReport)
            {
                case "arrival":
                    { 
                        sqlReport = @"SELECT idArrival as [Номер], 
                Worker.fullName as [Сотрудник], 
                dateOfArrival as [Дата поступления], sum as [Сумма поступления] 
                FROM [Arrival] JOIN [Worker] 
                ON Worker.idWorker = Arrival.idWorker WHERE dateOfArrival >= @dateOfBegin AND 
                dateOfArrival <=@dateOfEnd";
                        sqlReportBook = @"SELECT Book.name as [Название книги], 
                ArrivalBook.quantity as [Количество], ArrivalBook.price1pc as [Стоимость одной книги],
                (ArrivalBook.quantity*ArrivalBook.price1pc) as [Сумма]
                FROM [Arrival], [ArrivalBook], [Book]
                WHERE Book.idBook = ArrivalBook.idBook AND ArrivalBook.idArrival = Arrival.idArrival AND 
                ArrivalBook.idArrival = @idBook";
                    }
                    ; break;
                case "sell":
                    {
                        sqlReport = @"SELECT idSell as [Номер], 
                Worker.fullName as [Сотрудник], 
                dateOfSale as [Дата поступления], sum as [Сумма поступления] 
                FROM [Sell] JOIN [Worker] 
                ON Worker.idWorker = Sell.idWorker WHERE dateOfSale >= @dateOfBegin AND dateOfSale <=@dateOfEnd";
                        sqlReportBook = @"SELECT Book.name as [Название книги], 
                SellBook.quantity as [Количество], SellBook.price1pc as [Стоимость одной книги],
                (SellBook.quantity*SellBook.price1pc) as [Сумма]
                FROM [Sell], [SellBook], [Book]
                WHERE Book.idBook = SellBook.idBook AND SellBook.idSell = Sell.idSell AND SellBook.idSell = @idBook";
                    }; break;
            }
            if(dateTimePickerBegin.Value < dateTimePickerEnd.Value)
            {
                FillTable();
                if (tableReport.RowCount == 0 && tableReportBook.RowCount >= 1)
                {
                    tableReportBook.DataSource = null;
                }

                if (tableReport.RowCount > 0)
                {
                    quantity = tableReport.RowCount;
                    lblParamQuantity.Text = quantity.ToString();
                    quantity = 0;

                    for (int i = 0; i < tableReport.RowCount; i++)
                    {
                        sum += Convert.ToDouble(tableReport.Rows[i].Cells[3].Value.ToString());
                    }
                    lblParamSum.Text = sum.ToString();
                    sum = 0;
                }
            }
            else { MessageBox.Show("Начальная дата не может быть больше конечной!"); }          
        }
        //Выход с формы
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            var fWarehouseman = new FormWarehouseman();
            fWarehouseman.Show();
            Hide();
        }
        private void FormReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
