using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Keys
{
    internal class Bd
    {// подключение бд
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=desktop-scp0gor\SQLEXPRESS;initial Catalog = Keys; Integrated Security=True");
        // подключение бд
        public void openConnection()
        {
            if(SqlConnection.State == System.Data.ConnectionState.Closed) { 
            SqlConnection.Open();
            }
        }
        //отключение бд
        public void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
        //возврат строки
        public SqlConnection GetConnection()
        {
            return SqlConnection;
        }
    }
}
