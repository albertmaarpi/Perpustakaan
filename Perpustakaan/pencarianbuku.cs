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
         DataSet ds;

        public pencarianbuku()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pencarianbuku_Load(object sender, EventArgs e)
        {
    

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            conn = new connection();
            string query = "Select * from buku where 1=1";
            try
            {
                query += " and judul='" + tbpencarian.Text + "'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            da = new MySqlDataAdapter(query,conn.myconnection());
            //ds.Tables["buku"].Clear();
            da.Fill(ds,"buku");
            dataGridView1.DataSource = ds.Tables["buku"];
            dataGridView1.Refresh();
        }

        private void cDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            pencarianCD cd = new pencarianCD();
            if (cd.ShowDialog()==DialogResult.OK)
            {
                cd.ShowDialog();
            }
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
    }
}
