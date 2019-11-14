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
    public partial class pencarianCD : Form
    {
        public MySqlDataAdapter da;
        connection conn;
        DataSet ds;
        public pencarianCD()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            conn = new connection();
            string query = "Select * from cd where 1=1";
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
            da.Fill(ds, "cd");
            dataGridView1.DataSource = ds.Tables["cd"];
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
