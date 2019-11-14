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
    public partial class Formbuku : Form
    {
        public MySqlDataAdapter da;
        DataSet ds;
        connection conn;
        public Formbuku()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Formbuku_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            conn = new connection();
            try
            {
                string query = "Select * from buku where 1=1";
                da = new MySqlDataAdapter(query, conn.myconnection());
                da.Fill(ds, "buku");
                dataGridView1.DataSource = ds.Tables["buku"];
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
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

        private void cDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formcd fc = new Formcd();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                fc.ShowDialog();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            conn = new connection();
            string query = "Select * from buku where 1=1";
            try
            {
                query += " and judul like '%" + txtsearch.Text.ToUpper() + "%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            da = new MySqlDataAdapter(query, conn.myconnection());
          //ds.Tables["buku"].Clear();
            da.Fill(ds, "buku");
            dataGridView1.DataSource = ds.Tables["buku"];
            dataGridView1.Refresh();
        }

        private void btnbaru_Click(object sender, EventArgs e)
        {
            this.Hide();
            databuku db = new databuku();
            if (db.ShowDialog() == DialogResult.OK)
            {
                db.ShowDialog();
                
            }
        }
      
        private void btndelete_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = "DELETE";
        }
        void tampildata()
        {
            da = new MySqlDataAdapter("select * from buku", conn.myconnection());
            ds = new DataSet();

            da.Fill(ds, "buku");
            dataGridView1.DataSource = ds.Tables["buku"];
            dataGridView1.Refresh();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==0)
            {
                MySqlCommand cmd = new MySqlCommand();


                cmd.Connection = conn.myconnection();
                cmd.CommandText = "delete from buku where nama_DDC='" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + "'";
                //MessageBox.Show(cmd.CommandText);

                cmd.ExecuteNonQuery();
                MessageBox.Show("1 data delete");
                tampildata();
            }
        }

        private void bukuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
