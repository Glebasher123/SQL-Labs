using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_9
{
    class Connect
    {
        public SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Lab4;Integrated Security=True");
    }
}
