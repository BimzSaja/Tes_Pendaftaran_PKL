using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendaftaran_PKL
{
    public partial class pendaftaran : UserControl
    {
        public NpgsqlConnection connection = new NpgsqlConnection(koleksi.connString);
        public NpgsqlCommand command;
        public NpgsqlDataAdapter adapter;
        public DataTable table;
        public NpgsqlDataReader reader;

        public pendaftaran()
        {
            InitializeComponent();
            ShowData();
        }
        public void clear()
        {
            tnis.Text = "";
            tnama.Text = "";
            tsekolah.Text = "";
            tjurusan.Text = "";
            cbminat.Text = "";
            ralasan.Text = "";
        }
        public void ShowData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql = "select * from pendaftaran";

                command = new NpgsqlCommand(sql, connection);
                adapter = new NpgsqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);

                dgdaftar.DataSource = table;

                dgdaftar.Columns[0].HeaderText = "nis";
                dgdaftar.Columns[1].HeaderText = "nama";
                dgdaftar.Columns[2].HeaderText = "sekolah";
                dgdaftar.Columns[3].HeaderText = "jurusan";
                dgdaftar.Columns[4].HeaderText = "bidang";
                dgdaftar.Columns[5].HeaderText = "alasan";


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at:" + ex);
            }
        }
        private void InsertData(string nis, string nama, string sekolah, string jurusan, string bidang, string alasan)
        {
            try
            {
                connection.Open();

                string sql = "INSERT INTO pendaftaran (nis, nama, sekolah, jurusan, bidang, alasan) VALUES (@nis, @nama, @sekolah, @jurusan, @bidang, @alasan)";

                command = new NpgsqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nis", nis);
                command.Parameters.AddWithValue("@nama", nama);
                command.Parameters.AddWithValue("@sekolah", sekolah);
                command.Parameters.AddWithValue("@jurusan", jurusan);
                command.Parameters.AddWithValue("@bidang", bidang);
                command.Parameters.AddWithValue("@alasan", alasan);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully.");
                    clear();
                    ShowData();
                }
                else
                {
                    MessageBox.Show("Failed to insert data.");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at:" + ex.Message);
            }
        }


        private void bsubmit_Click(object sender, EventArgs e)
        {
            InsertData(tnis.Text, tnama.Text, tsekolah.Text, tjurusan.Text, cbminat.Text, ralasan.Text);
        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            if (dgdaftar.CurrentRow.Selected)
            {
                if (!string.IsNullOrEmpty(tnis.Text) && !string.IsNullOrEmpty(tnama.Text)
                && !string.IsNullOrEmpty(tsekolah.Text) && !string.IsNullOrEmpty(tjurusan.Text)
                && !string.IsNullOrEmpty(cbminat.Text) && cbminat.Text != "Pilih--" && !string.IsNullOrEmpty(ralasan.Text))
                {
                    DialogResult result = MessageBox.Show("Are your sure to update", "Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string query = "UPDATE pendaftaran SET nama = @nama, sekolah = @sekolah, jurusan = @jurusan, bidang = @bidang, alasan = @alasan WHERE nis = @nis ";

                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@nis", tnis.Text);
                            command.Parameters.AddWithValue("@nama", tnama.Text);
                            command.Parameters.AddWithValue("@sekolah", tsekolah.Text);
                            command.Parameters.AddWithValue("@jurusan", tjurusan.Text);
                            command.Parameters.AddWithValue("@bidang", cbminat.Text);
                            command.Parameters.AddWithValue("@alasan", ralasan.Text);

                            try
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                MessageBox.Show("Successfully updated!", "Information", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                clear();
                                ShowData();
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
        }
    }
}
