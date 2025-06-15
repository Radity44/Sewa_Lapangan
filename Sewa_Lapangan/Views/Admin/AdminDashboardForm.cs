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
            dgvDataUser.Rows.Clear();
            dgvDataUser.Columns.Clear();

            dgvDataUser.Columns.Add("No", "No");
            dgvDataUser.Columns.Add("NamaUser", "Nama User");
            dgvDataUser.Columns.Add("TotalPemesanan", "Total Pemesanan");
            dgvDataUser.Columns.Add("TotalTransaksi", "Total Transaksi");
            dgvDataUser.Columns.Add("IdUser", "Id User");
            dgvDataUser.Columns["IdUser"].Visible = false;

            DataGridViewButtonColumn hapusBtn = new DataGridViewButtonColumn
            {
                Name = "Hapus",
                HeaderText = "Hapus Akun",
                Text = "Hapus",
                UseColumnTextForButtonValue = true
            };
            dgvDataUser.Columns.Add(hapusBtn);

            string query = @"
                SELECT 
                    u.id_user,
                    u.nama AS nama_user,
                    COUNT(p.id_pemesanan) AS total_pemesanan,
                    COALESCE(SUM(p.total_biaya), 0) AS total_transaksi
                FROM ""user"" u
                LEFT JOIN pemesanan p ON u.id_user = p.id_user
                GROUP BY u.id_user, u.nama
                ORDER BY total_transaksi DESC;
            ";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    int no = 1;
                    while (reader.Read())
                    {
                        dgvDataUser.Rows.Add(
                            no++,
                            reader["nama_user"].ToString(),
                            reader["total_pemesanan"].ToString(),
                            $"Rp {Convert.ToDecimal(reader["total_transaksi"]):N0}",
                            reader["id_user"].ToString()
                        );
                    }
                }
            }

            dgvDataUser.AllowUserToAddRows = false;
            dgvDataUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadSummary()
        {
            string query = @"
                SELECT 
                    (SELECT COUNT(*) FROM ""user"") AS total_user,
                    (SELECT COALESCE(SUM(total_biaya), 0) FROM pemesanan) AS total_transaksi;
            ";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblTotalUser.Text = $"Total User: {reader["total_user"]}";
                        lblTotalTransaksi.Text = $"Total Pemasukan: Rp {Convert.ToDecimal(reader["total_transaksi"]):N0}";
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
            LoadSummary();
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
            RiwayatPesananForm riwayatPesanan = new RiwayatPesananForm();
            riwayatPesanan.Show();
            this.Hide();
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

        private void btnKelolaTransaksi_Click(object sender, EventArgs e)
        {
            KelolaPembayaranForm kelolaPembayaran = new KelolaPembayaranForm();
            kelolaPembayaran.Show();
            this.Hide();
        }

        private void dgvDataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDataUser.Columns["Hapus"].Index && e.RowIndex >= 0)
            {
                int idUser = Convert.ToInt32(dgvDataUser.Rows[e.RowIndex].Cells["IdUser"].Value);
                string namaUser = dgvDataUser.Rows[e.RowIndex].Cells["NamaUser"].Value.ToString();

                var confirm = MessageBox.Show($"Yakin ingin menghapus user {namaUser}?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    HapusUser(idUser);
                    LoadDataUser();
                    LoadSummary();
                }
            }
        }

        private void HapusUser(int idUser)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM \"user\" WHERE id_user = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idUser);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("User berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRiwayatPesanan_Click(object sender, EventArgs e)
        {
            RiwayatPesananForm riwayatForm = new RiwayatPesananForm();
            riwayatForm.Show();

            // Tutup / hide form dashboard sekarang
            this.Hide();

        }
    }
}
