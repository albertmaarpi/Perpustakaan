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
    public partial class Formcd : Form
    {
        public MySqlDataAdapter da;
        DataSet ds;
        connection conn;
        public Formcd()
        {
            InitializeComponent();
        }

        private void bukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formbuku fb = new Formbuku();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                fb.ShowDialog();

            }
        }

        private void bukuTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formbukuta fb = new Formbukuta();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                fb.ShowDialog();

            }
        }

        private void Formcd_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            conn = new connection();
            try
            {
                string query = "Select judul from cd where 1=1";
                da = new MySqlDataAdapter(query, conn.myconnection());
                da.Fill(ds, "cd");
                dataGridView1.DataSource = ds.Tables["cd"];
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
