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
    public partial class peminjamanTA : Form
    {
        connection conn;
        public MySqlDataAdapter da;
        DataSet ds;

        public peminjamanTA()
        {
            InitializeComponent();
        }

        private void peminjamanTA_Load(object sender, EventArgs e)
        {
            connection conn = new connection();
        }

        private void btnpinjam_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }
    }
}
