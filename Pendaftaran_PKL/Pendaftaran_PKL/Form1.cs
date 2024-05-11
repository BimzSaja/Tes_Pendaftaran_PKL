using Npgsql;
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
    public partial class Form1 : Form
    {
        public NpgsqlConnection connection = new NpgsqlConnection(koleksi.connString);
        public NpgsqlCommand command;
        public NpgsqlDataAdapter adapter;
        public DataTable table;
        public NpgsqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
        }

        private void bsubmit_Click(object sender, EventArgs e)
        {
            connection.Open();

            string sql = "SELECT * FROM users WHERE username = '" + tusername.Text + "'AND password = '" + tpassword.Text + "'";
            command = new NpgsqlCommand(sql, connection);
            adapter = new NpgsqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                home panggil = new home();
                panggil.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login pelase check Username dan Password");
            }
            connection.Close();
        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        //    register1.BringToFront();
        }

        private void lregister_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registerr panggil = new registerr();
            panggil.Show();
        }
    }
}
