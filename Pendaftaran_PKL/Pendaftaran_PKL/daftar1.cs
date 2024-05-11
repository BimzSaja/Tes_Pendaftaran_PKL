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
    public partial class daftar1 : UserControl
    {
        public NpgsqlConnection connection = new NpgsqlConnection(koleksi.connString);
        public NpgsqlCommand command;
        public NpgsqlDataAdapter adapter;
        public DataTable table;
        public NpgsqlDataReader reader;
        public daftar1()
        {
            InitializeComponent();
        }
        public void clear()
        {
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

                dgdaftar.Columns[0].HeaderText = "nama";
                dgdaftar.Columns[1].HeaderText = "sekolah";
                dgdaftar.Columns[2].HeaderText = "jurusan";
                dgdaftar.Columns[3].HeaderText = "bidang";
                dgdaftar.Columns[4].HeaderText = "alasan";


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at:" + ex);
            }
        }

        private void bsubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tnama.Text) && !string.IsNullOrEmpty(tsekolah.Text)
            && !string.IsNullOrEmpty(tjurusan.Text) && cbminat.Text != "Pilih--"
            && !string.IsNullOrEmpty(ralasan.Text))
            {
                try
                {
                    connection.Close();
                    connection.Open();

                    string sql = "INSERT INTO pendaftaran (nama, sekolah, jurusan, bidang, alasan)" + "VALUES (@nama, @sekolah, @jurusan, @bidang, @alasan)";
                    command = new NpgsqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@nama", tnama.Text);
                    command.Parameters.AddWithValue("@sekolah", tsekolah.Text);
                    command.Parameters.AddWithValue("@jurusan", tjurusan.Text);
                    command.Parameters.AddWithValue("@bidang", cbminat.Text);
                    command.Parameters.AddWithValue("@alasan", ralasan.Text);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Succesfully inserted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    ShowData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message + "\nStack Trace: " + ex.StackTrace);
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
    }
}
