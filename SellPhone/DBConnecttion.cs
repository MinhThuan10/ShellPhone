using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhone
{
    public class DBConnecttion
    {
        static public SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLCHDT;Integrated Security=True");
        public void connect()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void close()
        {
            conn.Close();
        }
    }
}
