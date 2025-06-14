using Npgsql;
using Sewa_Lapangan.Models;
using Sewa_Lapangan.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace Sewa_Lapangan.Views.Admin
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void LoadDataUser()
        {
            string query = @"
        SELECT 
            u.nama AS nama_user,
            j.tanggal AS tanggal_booking,
            l.nama_lapangan AS nama_lapangan
        FROM 
            pemesanan p
        JOIN ""user"" u ON p.id_user = u.id_user
        JOIN jadwal_lapangan j ON p.id_jadwal = j.id_jadwal
        JOIN lapangan l ON p.id_lapangan = l.id_lapangan
        ORDER BY j.tanggal DESC;
    ";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Tambahkan kolom nomor urut manual
                        dt.Columns.Add("No", typeof(int));

                        // Isi data nomor urut
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dt.Rows[i]["No"] = i + 1;
                        }

                        // Pindahkan kolom No ke posisi paling depan
                        dt.Columns["No"].SetOrdinal(0);

                        // Tambahkan pengaturan visual
                        dgvDataUser.RowHeadersVisible = false;

                        // Binding langsung ke DataTable (tanpa DefaultView, tanpa ToTable)
                        dgvDataUser.DataSource = dt;

                        // Atur tampilan datagridview
                        dgvDataUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvDataUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        dgvDataUser.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        dgvDataUser.RowTemplate.Height = 30;
                        dgvDataUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvDataUser.ReadOnly = true;

                        dgvDataUser.Columns["No"].FillWeight = 10;  // kolom No kecil saja
                        dgvDataUser.Columns["nama_user"].FillWeight = 40;
                        dgvDataUser.Columns["tanggal_booking"].FillWeight = 30;
                        dgvDataUser.Columns["nama_lapangan"].FillWeight = 20;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadDataUser();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionManager.UserId = 0;
            SessionManager.UserName = "";

            // Kembali ke form login
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnKelolaJadwal_Click(object sender, EventArgs e)
        {
            KelolaJadwalForm kelolaJadwal = new KelolaJadwalForm();
            kelolaJadwal.Show();
            this.Hide();
        }
    }
}
