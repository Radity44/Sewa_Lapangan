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

            dgvPembayaran.Columns.Add("IdPembayaran", "Id Pembayaran");
            dgvPembayaran.Columns["IdPembayaran"].Visible = false;
            dgvPembayaran.Columns.Add("No", "No");
            dgvPembayaran.Columns.Add("NamaUser", "Nama User");
            dgvPembayaran.Columns.Add("Lapangan", "Lapangan");
            dgvPembayaran.Columns.Add("Tanggal", "Tanggal");
            dgvPembayaran.Columns.Add("Jam", "Jam");
            dgvPembayaran.Columns.Add("Tarif", "Tarif");
            dgvPembayaran.Columns.Add("Metode", "Metode Pembayaran");
            dgvPembayaran.Columns.Add("Status", "Status Pembayaran");

            // Tombol Verifikasi
            DataGridViewButtonColumn verifikasiBtn = new DataGridViewButtonColumn();
            verifikasiBtn.Name = "Verifikasi";
            verifikasiBtn.HeaderText = "Verifikasi";
            verifikasiBtn.Text = "Verifikasi";
            verifikasiBtn.UseColumnTextForButtonValue = true;
            dgvPembayaran.Columns.Add(verifikasiBtn);

            // Tombol Tolak
            DataGridViewButtonColumn tolakBtn = new DataGridViewButtonColumn();
            tolakBtn.Name = "Tolak";
            tolakBtn.HeaderText = "Tolak";
            tolakBtn.Text = "Tolak";
            tolakBtn.UseColumnTextForButtonValue = true;
            dgvPembayaran.Columns.Add(tolakBtn);

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT pb.id_pembayaran, u.nama AS nama_user, jenis.nama_jenis, l.nama_lapangan, 
                           j.tanggal, j.jam_mulai, j.jam_selesai, j.tarif, mp.nama_metode, pb.status_pembayaran
                    FROM pembayaran pb
                    JOIN pemesanan p ON pb.id_pemesanan = p.id_pemesanan
                    JOIN ""user"" u ON p.id_user = u.id_user
                    JOIN jadwal_lapangan j ON p.id_jadwal = j.id_jadwal
                    JOIN lapangan l ON j.id_lapangan = l.id_lapangan
                    JOIN jenis_lapangan jenis ON l.id_jenis = jenis.id_jenis
                    JOIN metode_pembayaran mp ON pb.id_metode = mp.id_metode
                    ORDER BY pb.id_pembayaran DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    int no = 1;
                    while (reader.Read())
                    {
                        dgvPembayaran.Rows.Add(
                            reader["id_pembayaran"].ToString(),
                            no++,
                            reader["nama_user"].ToString(),
                            $"{reader["nama_jenis"]} - {reader["nama_lapangan"]}",
                            Convert.ToDateTime(reader["tanggal"]).ToString("yyyy-MM-dd"),
                            $"{reader["jam_mulai"]} - {reader["jam_selesai"]}",
                            reader["tarif"].ToString(),
                            reader["nama_metode"].ToString(),
                            reader["status_pembayaran"].ToString()
                        );
                    }
                }
            }

            dgvPembayaran.AllowUserToAddRows = false;
            dgvPembayaran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPembayaran.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvPembayaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idPembayaran = Convert.ToInt32(dgvPembayaran.Rows[e.RowIndex].Cells["IdPembayaran"].Value);

                if (dgvPembayaran.Columns[e.ColumnIndex].Name == "Verifikasi")
                {
                    UpdateStatusPembayaran(idPembayaran, "Terverifikasi");
                }

                if (dgvPembayaran.Columns[e.ColumnIndex].Name == "Tolak")
                {
                    UpdateStatusPembayaran(idPembayaran, "Ditolak");
                }
            }
        }

        private void UpdateStatusPembayaran(int idPembayaran, string newStatus)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "UPDATE pembayaran SET status_pembayaran = @status WHERE id_pembayaran = @id_pembayaran";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@id_pembayaran", idPembayaran);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show($"Status berhasil diubah menjadi {newStatus}.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataPembayaran();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AdminDashboardForm dash = new AdminDashboardForm();
            dash.Show();
            this.Close();
        }
    }
}
