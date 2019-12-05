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
    
    public partial class formpengembalian : Form
    {
        connection conn;
        DataSet ds;
        MySqlDataAdapter da;
        public formpengembalian()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }
        public void loaddata()
        {
            ds = new DataSet();

            string query = "SELECT m.nama_mhs ,b.judul,( CASE WHEN p.STATUS = 1 THEN 'sedang pinjam' ELSE 'sudah dikembalikan' END ) AS 'status peminjaman',p.tgl_peminjaman FROM peminjaman p JOIN buku b ON b.kode = p.kode_buku LEFT JOIN mahasiswa m ON m.nrp = p.kode_peminjam WHERE 1 = 1 and p.status=1";
            da = new MySqlDataAdapter(query, conn.myconnection());
            da.Fill(ds, "peminjaman");
            dataGridView1.DataSource = ds.Tables["peminjaman"];
            dataGridView1.Refresh();
        }
        private void formpengembalian_Load(object sender, EventArgs e)
        {
            conn = new connection();
            ds = new DataSet();
            da = new MySqlDataAdapter();

            try
            {
                string query = "SELECT m.nama_mhs ,b.judul,( CASE WHEN p.STATUS = 1 THEN 'sedang pinjam' ELSE 'sudah dikembalikan' END ) AS 'status peminjaman',p.tgl_peminjaman FROM peminjaman p JOIN buku b ON b.kode = p.kode_buku LEFT JOIN mahasiswa m ON m.nrp = p.kode_peminjam WHERE 1 = 1 and p.status=1";
                da = new MySqlDataAdapter(query, conn.myconnection());
                da.Fill(ds, "peminjaman");
                dataGridView1.DataSource = ds.Tables["peminjaman"];
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
