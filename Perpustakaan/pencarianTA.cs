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
    public partial class pencarianTA : Form
    {
        public MySqlDataAdapter da;
        connection conn;
        DataSet ds;
        public pencarianTA()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            conn = new connection();
            string query = "Select * from buku_ta where 1=1";
            try
            {
                query += " and judul='" + tbpencarian.Text + "'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            da = new MySqlDataAdapter(query, conn.myconnection());
            //ds.Tables["buku"].Clear();
            da.Fill(ds, "buku_ta");
            dataGridView1.DataSource = ds.Tables["buku_ta"];
            dataGridView1.Refresh();
        }

        private void bukuTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            pencarianTA ta = new pencarianTA();
            if (ta.ShowDialog() == DialogResult.OK)
            {
                ta.ShowDialog();
            }
        }

        private void cDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            pencarianCD cd = new pencarianCD();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                cd.ShowDialog();
            }
        }

        private void bukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            pencarianbuku buku = new pencarianbuku();
            if (buku.ShowDialog() == DialogResult.OK)
            {
                buku.ShowDialog();
            }
        }
    }
}
