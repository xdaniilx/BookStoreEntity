using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
namespace BookStore
{
    //Класс отвечает за добавление в базу данных авторов, издательств или жанров
    class ClassAddInfo
    {
        public static void AddInfo(string type, string sqlQuery, ComboBox cbType)
        {
            using (var connection = ClassConnection.SqlConnection())
            {
                var items = from DataRowView i in cbType.Items
                            where i.Row.ItemArray[1].ToString() == type
                            select i;
                if (!items.Any() && !string.IsNullOrWhiteSpace(type))
                {
                    connection.Open();
                    SqlCommand commandAddType = new SqlCommand(sqlQuery, connection);
                    commandAddType.ExecuteNonQuery();
                }
                else { MessageBox.Show("Не удалось добавить!"); }
            }
        }
        //Удаление издательста, жанров или авторов
        public static void DeleteInfo(string sqlQueryDel, DataGridView tableInfo)
        {
            try
            {
                using (SqlConnection connection = ClassConnection.SqlConnection())
                {
                    connection.Open();

                    SqlCommand commDel = new SqlCommand(sqlQueryDel, connection);
                    commDel.Parameters.AddWithValue("@Param", Convert.ToInt32(tableInfo.CurrentRow.Cells[0].Value));
                    commDel.ExecuteNonQuery();
                }
            }
            catch { MessageBox.Show("Невозможно удалить!"); }
        }
    }
}
