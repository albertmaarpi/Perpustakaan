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
        public databukuta()
        {
            InitializeComponent();
        }

        private void databukuta_Load(object sender, EventArgs e)
        {
            conn = new connection();
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
                cmd.CommandText = "insert into buku_ta" +
                    "(judul,pengarang,nrp,pembimbing,co_pembimbing,tahun,abstrak,keterangan,kondisi,penguji1,penguji2,penguji3,available)"
                    +"values("+txtjudul.Text+","+txtpengarang.Text+","+txtnrp.Text+","+cbpembimbing.SelectedText+","+cbcopembimbing.SelectedText+"," +
                    ""+cbtahun.SelectedText+","+txtabstrak.Text+","+rbketerangan.Text+","+cbkondisi.SelectedText+","+cbpenguji1.SelectedText+"," +
                    ""+cbpenguji2.SelectedText+","+cbpenguji3.SelectedText+","+cbavailable.SelectedText+")";
                cmd.ExecuteNonQuery();
                MessageBox.Show("insert successful");
            }
            catch (Exception ex)
            {

                
            }
        }
    }
}
