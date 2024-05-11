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
    public partial class edit : Form
    {
        public NpgsqlConnection connection = new NpgsqlConnection(koleksi.connString);
        public NpgsqlCommand command;
        public NpgsqlDataAdapter adapter;
        public DataTable table;
        public NpgsqlDataReader reader;
        public edit()
        {
            InitializeComponent();
        }
        public void clear()
        {
            tnis.Text = "";
            tusername.Text = "";
            tpassword.Text = "";
        }

        private void bsubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tusername.Text) && !string.IsNullOrEmpty(tpassword.Text))
            {
                DialogResult result = MessageBox.Show("Are your sure to update", "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE users SET username = @username, password = @password WHERE nis = @nis ";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nis", tnis.Text);
                        command.Parameters.AddWithValue("@username", tusername.Text);
                        command.Parameters.AddWithValue("@password", tpassword.Text);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Successfully updated!", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            clear();

                            this.Hide();
                            home loginForm = new home();
                            loginForm.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }

                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all data!");
            }
        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            home loginForm = new home();
            loginForm.Show();
        }
    }
}