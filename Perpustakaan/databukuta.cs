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
    public partial class databukuta : Form
    {
        public MySqlDataAdapter da;
        connection conn;
        DataSet ds;
        public int idbukuta;
        public databukuta(int idbukuta)
        {
            InitializeComponent();
            this.idbukuta = idbukuta;
        }

        public void loadbukuta()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from buku_ta where id_bukuta=@idbukuta";
            cmd.Connection = conn.myconnection();
            cmd.Parameters.Add(new MySqlParameter("@idbukuta", this.idbukuta));
            MySqlDataReader hasil = cmd.ExecuteReader();
            if (hasil.Read())
            {
                lblidbukuta.Text = hasil["id_bukuta"].ToString();
                txtjudul.Text = hasil["judul"].ToString();
                txtpengarang.Text = hasil["pengarang"].ToString();
                txtnrp.Text = hasil["nrp"].ToString();
                cbpembimbing.SelectedText = hasil["pembimbing"].ToString();
                cbcopembimbing.SelectedText = hasil["co_pembimbing"].ToString();
                cbtahun.SelectedText = hasil["tahun"].ToString();
                txtabstrak.Text = hasil["abstrak"].ToString();
                rbketerangan.Text = hasil["keterangan"].ToString();
                cbkondisi.SelectedText = hasil["kondisi"].ToString();
                cbpenguji1.SelectedText = hasil["penguji1"].ToString();
                cbpenguji2.SelectedText = hasil["penguji2"].ToString();
                cbpenguji3.SelectedText = hasil["penguji3"].ToString();
            }
            hasil.Close();
        }


        public databukuta()
        {
            InitializeComponent();
            
        }

        private void databukuta_Load(object sender, EventArgs e)
        {
            conn = new connection();
            loadbukuta();
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
                cmd.CommandText = "insert into buku_ta" +                    "(judul,pengarang,nrp,pembimbing,co_pembimbing,tahun,abstrak,keterangan,kondisi,penguji1,penguji2,penguji3)"+"values(@judul,@pengarang,@nrp,@pembimbing,@co_pembimbing,@tahun,@abstrak,@keterangan,@kondisi,@penguji1,@penguji2," +
                    "@penguji3)";
                cmd.Parameters.Add(new MySqlParameter("@judul", txtjudul.Text));
                cmd.Parameters.Add(new MySqlParameter("@pengarang", txtpengarang.Text));
                cmd.Parameters.Add(new MySqlParameter("@nrp", txtnrp.Text));
                cmd.Parameters.Add(new MySqlParameter("@pembimbing", cbpembimbing.Text));
                cmd.Parameters.Add(new MySqlParameter("@co_pembimbing", cbcopembimbing.Text));
                cmd.Parameters.Add(new MySqlParameter("@tahun", cbtahun.SelectedText));
                cmd.Parameters.Add(new MySqlParameter("@abstrak", txtabstrak.Text));
                cmd.Parameters.Add(new MySqlParameter("@keterangan", rbketerangan.Text));
                cmd.Parameters.Add(new MySqlParameter("@kondisi", cbkondisi.Text));
                cmd.Parameters.Add(new MySqlParameter("@penguji1", cbpenguji1.Text));
                cmd.Parameters.Add(new MySqlParameter("@penguji2", cbpenguji2.Text));
                cmd.Parameters.Add(new MySqlParameter("@penguji3", cbpenguji3.Text));
              
                cmd.ExecuteNonQuery();
                MessageBox.Show("insert successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn.myconnection();
            cmd.CommandText = "update buku_ta set judul=@judul , pengarang=@pengarang , nrp=@nrp , pembimbing=@pembimbing , co_pembimbing=@co_pembimbing , tahun=@tahun , abstrak=@abstrak , keterangan=@keterangan ,kondisi=@kondisi , penguji1=@penguji1 , penguji2=@penguji2 , penguji3=@penguji3 where id_bukuta=@id_bukuta ";
            cmd.Parameters.Add(new MySqlParameter("@judul", txtjudul.Text));
            cmd.Parameters.Add(new MySqlParameter("@pengarang", txtpengarang.Text));
            cmd.Parameters.Add(new MySqlParameter("@nrp", txtnrp.Text));
            cmd.Parameters.Add(new MySqlParameter("@pembimbing", cbpembimbing.Text));
            cmd.Parameters.Add(new MySqlParameter("@co_pembimbing", cbcopembimbing.Text));
            cmd.Parameters.Add(new MySqlParameter("@tahun", cbtahun.SelectedText));
            cmd.Parameters.Add(new MySqlParameter("@abstrak", txtabstrak.Text));
            cmd.Parameters.Add(new MySqlParameter("@keterangan", rbketerangan.Text));
            cmd.Parameters.Add(new MySqlParameter("@kondisi", cbkondisi.Text));
            cmd.Parameters.Add(new MySqlParameter("@penguji1", cbpenguji1.Text));
            cmd.Parameters.Add(new MySqlParameter("@penguji2", cbpenguji2.Text));
            cmd.Parameters.Add(new MySqlParameter("@penguji3", cbpenguji3.Text));
            cmd.Parameters.Add(new MySqlParameter("@id_bukuta", lblidbukuta.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("berhasil");
            this.Hide();
            Formbukuta fb = new Formbukuta();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                fb.ShowDialog();
            }
        }
    }
}
