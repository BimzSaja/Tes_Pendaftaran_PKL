using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendaftaran_PKL
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        private void bberanda_Click(object sender, EventArgs e)
        {
            beranda1.BringToFront();
        }

        private void bpendaftaran_Click(object sender, EventArgs e)
        {
            pendaftaran2.BringToFront();
        }

        private void blogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 panggil = new Form1();
            panggil.Show();
        }

        private void psetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            edit panggil = new edit();
            panggil.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            edit panggil = new edit();
            panggil.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
