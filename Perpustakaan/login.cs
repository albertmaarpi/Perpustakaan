using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
namespace Perpustakaan
{
    public partial class login : Form
    {
        public connection conn;
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            conn = new connection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbpassword.Text;
            string password = tbusername.Text;
            MySqlCommand cmd = new MySqlCommand("select * from userperpus where username='"+username+"' and password='"+password+"'",this.conn.myconnection());
            MySqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {
                int jabatan = Convert.ToInt32(reader["jabatan"].ToString());
                if (jabatan == 1)
                {
                    MessageBox.Show("halo admin "+username);
                }
                else
                {
                    MessageBox.Show("halo staff "+username);
                }
                //MessageBox.Show("berhasil login sebagai "+username+" dengan jabatan : "+reader["jabatan"]);
            }
            else
            {
                MessageBox.Show("gagal login");
            }
            reader.Close();
        }
    }
}
