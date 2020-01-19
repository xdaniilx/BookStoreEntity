using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using BookStore.Models;
using System.Linq;
namespace BookStore
{
    class ClassFillTable
    {
        public static void FillTable(DataGridView nameTable)
        {
            //nameTable.Columns.Add(new DataGridViewColumn { HeaderText = "Номер", Width = 70 });
            //nameTable.Columns.Add(new DataGridViewColumn { HeaderText = "Название", Width = 200 });
            //nameTable.Columns.Add(new DataGridViewColumn { HeaderText = "Количество", Width = 80 });
            //nameTable.Columns.Add(new DataGridViewColumn { HeaderText = "Цена", Width = 80 });

            nameTable.ColumnCount = 4;
            nameTable.Columns[0].Name = "Номер";
            nameTable.Columns[1].Name = "Название";
            nameTable.Columns[2].Name = "Количество";
            nameTable.Columns[3].Name = "Цена";

            var table = (from book in ClassGetContext.context.Books
                         join whbook in ClassGetContext.context.Warehouses on book.idBook equals whbook.idBook
                         select new { book.idBook, book.name, whbook.quantity, whbook.price });
            foreach(var book in table)
            {
                nameTable.Rows.Add(book.idBook, book.name, book.quantity, book.price);
            }

            nameTable.Columns[0].Width = 70;
            nameTable.Columns[1].Width = 200;
            nameTable.Columns[2].Width = 80;
            nameTable.Columns[3].Width = 80;
        }
    }
}
