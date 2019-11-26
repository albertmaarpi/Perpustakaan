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
                string query = "Select * from cd where 1=1";
                da = new MySqlDataAdapter(query, conn.myconnection());
                da.Fill(ds, "cd");
                dataGridView1.DataSource = ds.Tables["cd"];
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
            }
        }
        void tampildata()
        {
            da = new MySqlDataAdapter("select * from cd", conn.myconnection());
            ds = new DataSet();

            da.Fill(ds, "cd");
            dataGridView1.DataSource = ds.Tables["cd"];
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MySqlCommand cmd = new MySqlCommand();


                cmd.Connection = conn.myconnection();
                cmd.CommandText = "delete from cd where judul='" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "' and kode='" + dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() + "'";
                //MessageBox.Show(cmd.CommandText);

                cmd.ExecuteNonQuery();
                MessageBox.Show("1 data delete");
                tampildata();
            }
        }

        private void btnbaru_Click(object sender, EventArgs e)
        {
            this.Hide();
            datacd dc = new datacd();
            if (dc.ShowDialog() == DialogResult.OK)
            {
                dc.ShowDialog();

            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            conn = new connection();
            string query = "Select * from cd where 1=1";
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
            da.Fill(ds, "cd");
            dataGridView1.DataSource = ds.Tables["cd"];
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            int idcd = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            datacd dc = new datacd(idcd);
            dc.ShowDialog();
        }
    }
}
