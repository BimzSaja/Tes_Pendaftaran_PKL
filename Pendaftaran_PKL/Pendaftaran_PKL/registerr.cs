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
using System.Xml.Linq;

namespace Pendaftaran_PKL
{
    public partial class registerr : Form
    {
        public NpgsqlConnection connection = new NpgsqlConnection(koleksi.connString);
        public NpgsqlCommand command;
        public NpgsqlDataAdapter adapter;
        public DataTable table;
        public NpgsqlDataReader reader;
        public registerr()
        {
            InitializeComponent();
        }
        public void clear()
        {
            tnis.Text = "";
            tusername.Text = "";
            tpassword.Text = "";
        }

        public void submit()
        {
            if (!string.IsNullOrEmpty(tnis.Text) && !string.IsNullOrEmpty(tpassword.Text))
            {
                try
                {
                    connection.Close();
                    connection.Open();

                    string npg = "INSERT INTO users (nis, username, password)" + "VALUES (@nis, @username, @password)";
                    command = new NpgsqlCommand(npg, connection);

                    command.Parameters.AddWithValue("@nis", tnis.Text);
                    command.Parameters.AddWithValue("@username", tusername.Text);
                    command.Parameters.AddWithValue("@password", tpassword.Text);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Successfully inserted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                    // Hide the current form (registration form)
                    this.Hide();

                    // Show the login form
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at:" + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill all data before insert!");
            }
        }


        private void bsubmit_Click(object sender, EventArgs e)
        {
            submit();
        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void llogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 panggil = new Form1();
            panggil.Show();
        }
    }
}
