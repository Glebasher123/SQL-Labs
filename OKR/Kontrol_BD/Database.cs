using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrol_BD
{
    class Database
    {
        SqlConnection Connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog= Ozera_Var4;Integrated Security=True"); //подключение к sql

        public void OpenConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();
        }

        public void CloseConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
                Connection.Close();
        }

        public SqlConnection getConnection()
        {
            return Connection;
        }
    }
}
