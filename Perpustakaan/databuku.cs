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
        public MySqlDataAdapter da;
        DataSet ds;
        connection conn;
        public databuku()
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
        }
       
        private void btninsert_Click(object sender, EventArgs e)
        {

            try
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn.myconnection();
                cmd.CommandText = "insert into buku (judul,sub_judul,nomor_panggil,nama_DDC,subjek,pengarang,penerbit,kota_terbit,tahun_terbit,edisi,volume,ISBN,kode,harga,bahasa,halaman_romawi,halaman_arab,tinggi,keterangan,keaslian,kondisi,status)" + " values (@judul,@sub_judul,@nomor_panggil,@nama_DDC,@subjek,@pengarang,@penerbit,@kota_terbit,@tahun_terbit,@edisi,@volume,@ISBN,@kode,@harga,@bahasa,@halaman_romawi,@halaman_arab,@tinggi,@keterangan,@keaslian,@kondisi,@status)";
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
                //cmd.Parameters.Add(new MySqlParameter("@tanggal_datang", DateTime.Now.ToString()));

          
                //MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                MessageBox.Show("1 data inserted");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
//'" + txtjudul.Text + "','" + txtsub.Text + "','" + txtnomorpanggil.Text + "','" + txtddc.Text + "','ss','" + txtpengarang.Text + "','" + txtpenerbit.Text +"','"+txtkotaterbit.Text+"','"+txttahunterbit.Text+"','"+txtedisi.Text+"','"+txtvol.Text+"','"+txtisbn.Text+"','"+txtkode.Text+"','"+txtharga.Text+"','"+txtbahasa.Text+"','"+txtromawi.Text+"','"+txtarab.Text+"','"+txttinggi.Text+"','"+txtketerangan.Text+"','ssds','sadsa','sdad'