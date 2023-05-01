using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Factory
{
    internal class Bd
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=desktop-scp0gor\SQLEXPRESS;initial Catalog = Factory; Integrated Security=True");
        public void openConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return SqlConnection;
        }
    }
}
