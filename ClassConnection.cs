using System.Data.SqlClient;
namespace BookStore
{
    class ClassConnection
    {
        public static SqlConnection SqlConnection()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(local)\sqlexpress;Initial Catalog=BookStoreDB;Integrated Security=True");
            return connection;
        }
    }
}
