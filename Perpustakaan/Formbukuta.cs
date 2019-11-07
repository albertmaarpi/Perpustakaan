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
    public partial class Formbukuta : Form
    {
        public MySqlDataAdapter da;
        DataSet ds;
        connection conn;
        public Formbukuta()
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

        private void cDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formcd fc = new Formcd();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                fc.ShowDialog();

            }
        }

        private void Formbukuta_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            conn = new connection();
            try
            {
                string query = "Select judul from buku_ta where 1=1";
                da = new MySqlDataAdapter(query, conn.myconnection());
                da.Fill(ds, "buku_ta");
                dataGridView1.DataSource = ds.Tables["buku_ta"];
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
