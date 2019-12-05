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
    public partial class formhistory : Form
    {
        connection conn;
        public MySqlDataAdapter da;
        DataSet ds;
        public formhistory()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            conn = new connection();
            ds = new DataSet();
            da = new MySqlDataAdapter();

            try
            {
                string query = "SELECT m.nama_mhs ,b.judul,( CASE WHEN p.STATUS = 1 THEN 'sedang pinjam' ELSE 'sudah dikembalikan' END ) AS 'status peminjaman',p.tgl_peminjaman FROM peminjaman p JOIN buku b ON b.kode = p.kode_buku LEFT JOIN mahasiswa m ON m.nrp = p.kode_peminjam WHERE 1 = 1 and p.kode_peminjam='"+tbnrp.Text+"'";
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

        private void formhistory_Load(object sender, EventArgs e)
        {
            conn = new connection();
        }
    }
}
