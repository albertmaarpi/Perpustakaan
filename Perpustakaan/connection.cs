using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Perpustakaan
{
    public class connection
    {
        public string stringconnect;
        public MySqlConnection conn;
        public  connection()
        {
            stringconnect = "Server=localhost;database=perpustakaan; UID=root; password=";
            conn = new MySqlConnection(stringconnect);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
               
            }
            else
            {
                conn.Close();
                conn.Open();
               
            }
        }

        public void connclose()
        {
            conn.Close();
        }

        public MySqlConnection myconnection()
        {
            return conn;
        }
    }
}
