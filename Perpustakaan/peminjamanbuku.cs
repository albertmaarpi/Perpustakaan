using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Perpustakaan
{
    public partial class peminjamanbuku : Form
    {
        connection conn;
        DataSet ds;
        MySqlDataAdapter da;
        public peminjamanbuku()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void peminjamanbuku_Load(object sender, EventArgs e)
        {
            conn = new connection();
            ds = new DataSet();
            da = new MySqlDataAdapter();
           
            try
            {
                string query = "SELECT m.nama_mhs ,b.judul,( CASE WHEN p.STATUS = 1 THEN 'sedang pinjam' ELSE 'sudah dikembalikan' END ) AS 'status peminjaman',p.tgl_peminjaman FROM peminjaman p JOIN buku b ON b.kode = p.kode_buku LEFT JOIN mahasiswa m ON m.nrp = p.kode_peminjam WHERE 1 = 1";
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

        public void loaddata()
        {
            ds = new DataSet();

            string query = "SELECT m.nama_mhs ,b.judul,( CASE WHEN p.STATUS = 1 THEN 'sedang pinjam' ELSE 'sudah dikembalikan' END ) AS 'status peminjaman',p.tgl_peminjaman FROM peminjaman p JOIN buku b ON b.kode = p.kode_buku LEFT JOIN mahasiswa m ON m.nrp = p.kode_peminjam WHERE 1 = 1";
            da = new MySqlDataAdapter(query, conn.myconnection());
            da.Fill(ds, "peminjaman");
            dataGridView1.DataSource = ds.Tables["peminjaman"];
            dataGridView1.Refresh();
        }
        private void btnpinjam_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;
            DateTime dead = dt.AddDays(+7.0);
            //  MessageBox.Show(dt.ToString("dd/MM/yyyy"));
            //  MessageBox.Show(dead.ToString("dd/MM/yyyy"));

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn.myconnection();
                cmd.CommandText = "insert into peminjaman (kode_peminjam,kode_buku)" + " values (@kp,@kb)";
            
                cmd.Parameters.Add(new MySqlParameter("@kp", tbnrp.Text));
                cmd.Parameters.Add(new MySqlParameter("@kb", tbkodebuku.Text));
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("buku berhasil dipinjam");
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
