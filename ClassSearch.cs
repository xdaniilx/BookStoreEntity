using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using BookStore.Models;
using System.Collections.Generic;
namespace BookStore
{
    class ClassSearch
    {
        //Поиск
        public static void Search(int selectedIndex, ComboBox cbSearch, DataGridView tableBooks)
        {
            DataSet dataSet = new DataSet();
            switch (selectedIndex)
            {
                case 0:
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT Book.idBook as [Номер],
                        Book.name as [Название], 
                        Warehouse.quantity as [Количество], 
                        Warehouse.price as [Цена]
                        FROM [Book], [Warehouse]
                        WHERE Book.idBook = Warehouse.idBook AND
                        Book.name LIKE '%" + cbSearch.Text + "%'", ClassConnection.SqlConnection());
                        adapter.Fill(dataSet);
                    }; break;
                case 1:
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT Book.idBook as [Номер],
                        Book.name as [Название], 
                        Warehouse.quantity as [Количество], 
                        Warehouse.price as [Цена]
                        FROM [Book], [Warehouse], [Author], [BookAuthor]
                        WHERE Book.idBook = Warehouse.idBook AND 
                        BookAuthor.idBook = Book.idBook AND 
                        BookAuthor.idAuthor = Author.idAuthor AND 
                        Author.shortName LIKE '%" + cbSearch.Text + "%'", ClassConnection.SqlConnection());
                        adapter.Fill(dataSet);
                    }; break;
                case 2:
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT Book.idBook as [Номер],
                        Book.name as [Название], 
                        Warehouse.quantity as [Количество], 
                        Warehouse.price as [Цена]
                        FROM [Book], [Warehouse], [Genre], [BookGenre]
                        WHERE Book.idBook = Warehouse.idBook AND 
                        BookGenre.idBook = Book.idBook AND 
                        BookGenre.idGenre = Genre.idGenre AND
                        Genre.genre LIKE '%" + cbSearch.Text + "%'", ClassConnection.SqlConnection());
                        adapter.Fill(dataSet);
                    }; break;
            }                                 
            tableBooks.DataSource = dataSet.Tables[0];
            tableBooks.Columns[0].Width = 70;
            tableBooks.Columns[1].Width = 200;
            tableBooks.Columns[2].Width = 80;
            tableBooks.Columns[3].Width = 80;
        }
        //Заполнение поля поиска
        public static void FillComboBoxSearch(ComboBox cbCategorySearch, ComboBox cbSearch)
        {
            switch (cbCategorySearch.SelectedIndex)
            {
                case 0:
                    {
                        foreach (var item in ClassGetContext.context.Books.Select(x => x.name).Distinct())
                        {
                            cbSearch.Items.Add(item);
                        }
                    }; break;
                case 1:
                    {
                        DataSet dataSet = new DataSet();
                        SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT DISTINCT idAuthor, shortName FROM [Author]", 
                            ClassConnection.SqlConnection());
                        adapter.Fill(dataSet);
                        cbSearch.DataSource = dataSet.Tables[0];
                        cbSearch.DisplayMember = "shortName";
                        cbSearch.ValueMember = "idAuthor";
                    }; break;
                case 2:
                    {
                        DataSet dataSet = new DataSet();
                        SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT DISTINCT idGenre, genre FROM [Genre]", 
                            ClassConnection.SqlConnection());
                        adapter.Fill(dataSet);
                        cbSearch.DataSource = dataSet.Tables[0];
                        cbSearch.DisplayMember = "genre";
                        cbSearch.ValueMember = "idGenre";
                    }; break;
            }
        }
        //Очистка поиска
        public static void Erase(ComboBox cbCategorySearch, ComboBox cbSearch)
        {
            cbCategorySearch.SelectedIndex = 0;
            cbSearch.Text = "";
        }
    }
}
