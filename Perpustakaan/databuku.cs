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
    public partial class databuku : Form
    {
        public int idbuku;
        public MySqlDataAdapter da;
        DataSet ds;
        connection conn;
        public databuku()
        {
            InitializeComponent();
        }
        public databuku(int idbuku)
        {
            InitializeComponent();          
            this.idbuku = idbuku;
        }
        public void loadbuku()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from buku where id_buku=@idbuku";
            cmd.Connection = conn.myconnection();
            cmd.Parameters.Add(new MySqlParameter("@idbuku",this.idbuku));
            MySqlDataReader hasil = cmd.ExecuteReader();
            if(hasil.Read())
            {
                lblidbuku.Text = hasil["id_buku"].ToString();
                txtjudul.Text = hasil["judul"].ToString();
                txtsub.Text = hasil["sub_judul"].ToString();
                txtkode.Text = hasil["kode"].ToString();
                txtddc.Text = hasil["nama_DDC"].ToString();
                cbsubjek.SelectedText = hasil["subjek"].ToString();
                txtpengarang.Text = hasil["pengarang"].ToString();
                txtpenerbit.Text = hasil["penerbit"].ToString();
                txtkotaterbit.Text = hasil["kota_terbit"].ToString();
                cbtahun.SelectedText = hasil["tahun_terbit"].ToString();
                txtedisi.Text = hasil["edisi"].ToString();
                txtvol.Text = hasil["volume"].ToString();
                txtisbn.Text = hasil["ISBN"].ToString();
                txtharga.Text = hasil["HARGA"].ToString();
                txtbahasa.Text = hasil["bahasa"].ToString();
                txtromawi.Text = hasil["halaman_romawi"].ToString();
                txtarab.Text = hasil["halaman_arab"].ToString();
                txttinggi.Text = hasil["tinggi"].ToString();
                cbasli.SelectedText = hasil["keaslian"].ToString();
                cbkondisi.SelectedText= hasil["kondisi"].ToString();
               txtketerangan.Text= hasil["keterangan"].ToString();
                txtnomorpanggil.Text = hasil["nomor_panggil"].ToString();
            }hasil.Close();          
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

        private void databuku_Load(object sender, EventArgs e)
        {
            conn = new connection();
            ds = new DataSet();
            loadbuku();
        }
       
        private void btninsert_Click(object sender, EventArgs e)
        {

            try
            {             
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn.myconnection();
                cmd.CommandText = "insert into buku (judul,sub_judul,nomor_panggil,nama_DDC,subjek,pengarang,penerbit,kota_terbit,tahun_terbit,edisi,volume,ISBN,kode,harga,bahasa,halaman_romawi,halaman_arab,tinggi,keterangan,keaslian,kondisi)" + " values (@judul,@sub_judul,@nomor_panggil,@nama_DDC,@subjek,@pengarang,@penerbit,@kota_terbit,@tahun_terbit,@edisi,@volume,@ISBN,@kode,@harga,@bahasa,@halaman_romawi,@halaman_arab,@tinggi,@keterangan,@keaslian,@kondisi)";
                cmd.Parameters.Add(new MySqlParameter("@judul", txtjudul.Text));
                cmd.Parameters.Add(new MySqlParameter("@sub_judul", txtharga.Text));
                cmd.Parameters.Add(new MySqlParameter("@nomor_panggil", txtnomorpanggil.Text));
                cmd.Parameters.Add(new MySqlParameter("@nama_DDC", txtddc.Text));
                cmd.Parameters.Add(new MySqlParameter("@subjek", cbsubjek.SelectedText.ToString()));
                cmd.Parameters.Add(new MySqlParameter("@pengarang", txtpengarang.Text));
                cmd.Parameters.Add(new MySqlParameter("@penerbit", txtpenerbit.Text));
                cmd.Parameters.Add(new MySqlParameter("@kota_terbit", txtkotaterbit.Text));
                cmd.Parameters.Add(new MySqlParameter("@tahun_terbit", cbtahun.SelectedText.ToString()));
                cmd.Parameters.Add(new MySqlParameter("@edisi", txtedisi.Text));
                cmd.Parameters.Add(new MySqlParameter("@volume", txtvol.Text));
                cmd.Parameters.Add(new MySqlParameter("@ISBN", txtisbn.Text));
                cmd.Parameters.Add(new MySqlParameter("@kode", txtkode.Text));
                cmd.Parameters.Add(new MySqlParameter("@harga", txtharga.Text));
                cmd.Parameters.Add(new MySqlParameter("@bahasa", txtbahasa.Text));
                cmd.Parameters.Add(new MySqlParameter("@halaman_romawi", txtromawi.Text));
                cmd.Parameters.Add(new MySqlParameter("@halaman_arab", txtarab.Text));
                cmd.Parameters.Add(new MySqlParameter("@tinggi", txttinggi.Text));
                cmd.Parameters.Add(new MySqlParameter("@keterangan", txtketerangan.Text));
                cmd.Parameters.Add(new MySqlParameter("@keaslian", cbasli.Text));
                cmd.Parameters.Add(new MySqlParameter("@kondisi", cbkondisi.Text));
                //cmd.Parameters.Add(new MySqlParameter("@tanggal_datang", DateTime.Now.ToString()) 
                //MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                MessageBox.Show("1 data inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn.myconnection();
            cmd.CommandText = "update buku set judul=@judul , sub_judul=@sub_judul , nomor_panggil=@nomor_panggil , nama_DDC=@nama_DDC , subjek=@subjek , pengarang=@pengarang , penerbit=@penerbit , kota_terbit=@kota_terbit , tahun_terbit=@tahun_terbit , edisi=@edisi , volume=@volume , ISBN=@ISBN , kode=@kode , harga=@harga , bahasa=@bahasa , halaman_romawi=@halaman_romawi , halaman_arab=@halaman_arab , tinggi=@tinggi , keterangan=@keterangan , keaslian=@keaslian , kondisi=@kondisi where id_buku=@id_buku";
            cmd.Parameters.Add(new MySqlParameter("@judul", txtjudul.Text));
            cmd.Parameters.Add(new MySqlParameter("@sub_judul", txtharga.Text));
            cmd.Parameters.Add(new MySqlParameter("@nomor_panggil", txtnomorpanggil.Text));
            cmd.Parameters.Add(new MySqlParameter("@nama_DDC", txtddc.Text));
            cmd.Parameters.Add(new MySqlParameter("@subjek", cbsubjek.SelectedText.ToString()));
            cmd.Parameters.Add(new MySqlParameter("@pengarang", txtpengarang.Text));
            cmd.Parameters.Add(new MySqlParameter("@penerbit", txtpenerbit.Text));
            cmd.Parameters.Add(new MySqlParameter("@kota_terbit", txtkotaterbit.Text));
            cmd.Parameters.Add(new MySqlParameter("@tahun_terbit", cbtahun.SelectedText.ToString()));
            cmd.Parameters.Add(new MySqlParameter("@edisi", txtedisi.Text));
            cmd.Parameters.Add(new MySqlParameter("@volume", txtvol.Text));
            cmd.Parameters.Add(new MySqlParameter("@ISBN", txtisbn.Text));
            cmd.Parameters.Add(new MySqlParameter("@kode", txtkode.Text));
            cmd.Parameters.Add(new MySqlParameter("@harga", txtharga.Text));
            cmd.Parameters.Add(new MySqlParameter("@bahasa", txtbahasa.Text));
            cmd.Parameters.Add(new MySqlParameter("@halaman_romawi", txtromawi.Text));
            cmd.Parameters.Add(new MySqlParameter("@halaman_arab", txtarab.Text));
            cmd.Parameters.Add(new MySqlParameter("@tinggi", txttinggi.Text));
            cmd.Parameters.Add(new MySqlParameter("@keterangan", txtketerangan.Text));
            cmd.Parameters.Add(new MySqlParameter("@keaslian", cbasli.Text));
            cmd.Parameters.Add(new MySqlParameter("@kondisi", cbkondisi.Text));
            cmd.Parameters.Add(new MySqlParameter("@id_buku", lblidbuku.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("berhasil");
            this.Hide();
            Formbuku fb = new Formbuku();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                fb.ShowDialog();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
//'" + txtjudul.Text + "','" + txtsub.Text + "','" + txtnomorpanggil.Text + "','" + txtddc.Text + "','ss','" + txtpengarang.Text + "','" + txtpenerbit.Text +"','"+txtkotaterbit.Text+"','"+txttahunterbit.Text+"','"+txtedisi.Text+"','"+txtvol.Text+"','"+txtisbn.Text+"','"+txtkode.Text+"','"+txtharga.Text+"','"+txtbahasa.Text+"','"+txtromawi.Text+"','"+txtarab.Text+"','"+txttinggi.Text+"','"+txtketerangan.Text+"','ssds','sadsa','sdad'