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
    public partial class datacd : Form
    {
        public int idcd;
        public MySqlDataAdapter da;
        connection conn;
        DataSet ds;
        public datacd()
        {
            InitializeComponent();
        }
        public datacd(int idcd)
        {
            InitializeComponent();
            this.idcd = idcd;
        }
        public void loadcd()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from cd where id_cd=@idcd";
            cmd.Connection = conn.myconnection();
            cmd.Parameters.Add(new MySqlParameter("@idcd", this.idcd));
            MySqlDataReader hasil = cmd.ExecuteReader();
            if (hasil.Read())
            {
                lblidcd.Text = hasil["id_cd"].ToString();
                txtjudul.Text = hasil["judul"].ToString();
                cbjenis.SelectedText = hasil["jenis"].ToString();
                txtharga.Text = hasil["harga"].ToString();
                rbketerangan.Text = hasil["keterangan"].ToString();
                txtkode.Text = hasil["kode"].ToString(); ;
                cbkondisi.SelectedText = hasil["kondisi"].ToString(); ;
                txtrak.Text= hasil["rak"].ToString();
            }
            hasil.Close();
            
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

        private void cDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formcd fc = new Formcd();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                fc.ShowDialog();

            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn.myconnection();
                cmd.CommandText = "insert into cd" +
                    "(judul,jenis,harga,keterangan,kode,kondisi,rak)" +
                    "values(@judul,@jenis,@harga,@keterangan,@kode,@kondisi,@rak)";
                cmd.Parameters.Add(new MySqlParameter("@judul", txtjudul.Text));
                cmd.Parameters.Add(new MySqlParameter("@jenis", cbjenis.Text));
                cmd.Parameters.Add(new MySqlParameter("@harga", txtharga.Text));
                cmd.Parameters.Add(new MySqlParameter("@keterangan", rbketerangan.Text));
                cmd.Parameters.Add(new MySqlParameter("@kode", txtkode.Text));
                cmd.Parameters.Add(new MySqlParameter("@kondisi", cbkondisi.Text));
                cmd.Parameters.Add(new MySqlParameter("@rak", txtrak.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("insert successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void datacd_Load(object sender, EventArgs e)
        {
            conn = new connection();

            loadcd();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn.myconnection();
            cmd.CommandText = "update cd set judul=@judul , jenis=@jenis , harga=@harga , keterangan=@keterangan , kode=@kode , kondisi=@kondisi,rak=@rak where id_cd=@id_cd ";
            cmd.Parameters.Add(new MySqlParameter("@judul", txtjudul.Text));
            cmd.Parameters.Add(new MySqlParameter("@jenis", cbjenis.Text));
            cmd.Parameters.Add(new MySqlParameter("@harga", txtharga.Text));
            cmd.Parameters.Add(new MySqlParameter("@keterangan", rbketerangan.Text));
            cmd.Parameters.Add(new MySqlParameter("@kode", txtkode.Text));
            cmd.Parameters.Add(new MySqlParameter("@kondisi", cbkondisi.Text));
            cmd.Parameters.Add(new MySqlParameter("@rak", txtrak.Text));
            cmd.Parameters.Add(new MySqlParameter("@id_cd", lblidcd.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("berhasil");
            this.Hide();
            Formcd fc = new Formcd();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                fc.ShowDialog();
            }
        }
    }
}
