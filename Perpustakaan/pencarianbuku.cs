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

namespace Perpustakaan
{
    public partial class pencarianbuku : Form
    {
        public MySqlDataAdapter da;
        connection conn;
        public DataSet ds;

        public pencarianbuku()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pencarianbuku_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            conn = new connection();

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            da = new MySqlDataAdapter("select * from buku", conn.myconnection());

            ds.Tables["buku"].Clear();
            da.Fill(ds, "buku");
            dataGridView1.DataSource = ds.Tables["buku"];
            dataGridView1.Refresh();
        }
    }
}
