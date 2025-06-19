using Npgsql;
using Sewa_Lapangan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Sewa_Lapangan.Views.Admin
{
    public partial class KelolaPembayaranForm : Form
    {
        public KelolaPembayaranForm()
        {
            InitializeComponent();
            LoadDataPembayaran();
        }

        private void LoadDataPembayaran()
        {
            dgvPembayaran.Rows.Clear();
            dgvPembayaran.Columns.Clear();

            dgvPembayaran.Columns.Add("No", "No");
            dgvPembayaran.Columns.Add("NamaUser", "Nama User");
            dgvPembayaran.Columns.Add("JenisLapangan", "Jenis Lapangan");
            dgvPembayaran.Columns.Add("Tanggal", "Tanggal");
            dgvPembayaran.Columns.Add("Tarif", "Tarif");
            dgvPembayaran.Columns.Add("Status", "Status");
            dgvPembayaran.Columns.Add("IdPembayaran", "Id Pembayaran");
            dgvPembayaran.Columns["IdPembayaran"].Visible = false;

            // Tombol Verifikasi
            DataGridViewButtonColumn verifikasiBtn = new DataGridViewButtonColumn
            {
                Name = "Verifikasi",
                HeaderText = "Verifikasi",
                Text = "Verifikasi",
                UseColumnTextForButtonValue = true
            };
            dgvPembayaran.Columns.Add(verifikasiBtn);

            // Tombol Tolak
            DataGridViewButtonColumn tolakBtn = new DataGridViewButtonColumn
            {
                Name = "Tolak",
                HeaderText = "Tolak",
                Text = "Tolak",
                UseColumnTextForButtonValue = true
            };
            dgvPembayaran.Columns.Add(tolakBtn);

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT pb.id_pembayaran, pb.status_pembayaran, u.nama, j.tanggal, j.tarif, jl.nama_jenis
                    FROM pembayaran pb
                    JOIN pemesanan p ON pb.id_pemesanan = p.id_pemesanan
                    JOIN ""user"" u ON p.id_user = u.id_user
                    JOIN jadwal_lapangan j ON p.id_jadwal = j.id_jadwal
                    JOIN lapangan l ON j.id_lapangan = l.id_lapangan
                    JOIN jenis_lapangan jl ON l.id_jenis = jl.id_jenis
                    WHERE pb.status_pembayaran = @status
                    ORDER BY pb.id_pembayaran DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", StatusPembayaran.Menunggu);

                    using (var reader = cmd.ExecuteReader())
                    {
                        int no = 1;
                        while (reader.Read())
                        {
                            dgvPembayaran.Rows.Add(
                                no++,
                                reader["nama"].ToString(),
                                reader["nama_jenis"].ToString(),
                                Convert.ToDateTime(reader["tanggal"]).ToString("yyyy-MM-dd"),
                                reader["tarif"].ToString(),
                                reader["status_pembayaran"].ToString(),
                                reader["id_pembayaran"].ToString()
                            );
                        }
                    }
                }
            }

            dgvPembayaran.AllowUserToAddRows = false;
            dgvPembayaran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPembayaran.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KelolaPembayaranForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvPembayaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int idPembayaran = Convert.ToInt32(dgvPembayaran.Rows[e.RowIndex].Cells["IdPembayaran"].Value);

                if (dgvPembayaran.Columns[e.ColumnIndex].Name == "Verifikasi")
                {
                    if (MessageBox.Show("Verifikasi pembayaran ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        UpdateStatus(idPembayaran, StatusPembayaran.Lunas);
                }
                else if (dgvPembayaran.Columns[e.ColumnIndex].Name == "Tolak")
                {
                    if (MessageBox.Show("Tolak pembayaran ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        UpdateStatus(idPembayaran, StatusPembayaran.Gagal);
                }
            }
        }

        private void UpdateStatus(int idPembayaran, string statusBaru)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // 1️⃣ Update status pembayaran
                string updateBayar = @"UPDATE pembayaran SET status_pembayaran = @status WHERE id_pembayaran = @id";
                using (var cmd = new NpgsqlCommand(updateBayar, conn))
                {
                    cmd.Parameters.AddWithValue("@status", statusBaru);
                    cmd.Parameters.AddWithValue("@id", idPembayaran);
                    cmd.ExecuteNonQuery();
                }

                // 2️⃣ Update status_bayar di pemesanan
                string updatePesan = @"UPDATE pemesanan SET status_bayar = @status WHERE id_pemesanan = (SELECT id_pemesanan FROM pembayaran WHERE id_pembayaran = @id)";
                using (var cmd2 = new NpgsqlCommand(updatePesan, conn))
                {
                    cmd2.Parameters.AddWithValue("@status", statusBaru);
                    cmd2.Parameters.AddWithValue("@id", idPembayaran);
                    cmd2.ExecuteNonQuery();
                }

                // 3️⃣ Jika ditolak, jadwal dikembalikan menjadi 'Tersedia'
                if (statusBaru == StatusPembayaran.Gagal)
                {
                    string updateJadwal = @"
                UPDATE jadwal_lapangan 
                SET status = 'Tersedia' 
                WHERE id_jadwal = (
                    SELECT p.id_jadwal 
                    FROM pemesanan p
                    JOIN pembayaran pb ON pb.id_pemesanan = p.id_pemesanan
                    WHERE pb.id_pembayaran = @id
                )";

                    using (var cmd3 = new NpgsqlCommand(updateJadwal, conn))
                    {
                        cmd3.Parameters.AddWithValue("@id", idPembayaran);
                        cmd3.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show($"Status berhasil diperbarui ke {statusBaru}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataPembayaran();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AdminDashboardForm dashboard = new AdminDashboardForm();
            dashboard.Show();
            this.Close();
        }
    }
}
