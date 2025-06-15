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
    public partial class RiwayatPesananForm : Form
    {
        public RiwayatPesananForm()
        {
            InitializeComponent();
            LoadRiwayatPesanan();
        }

        private void LoadRiwayatPesanan()
        {
            dgvRiwayat.Rows.Clear();
            dgvRiwayat.Columns.Clear();

            dgvRiwayat.Columns.Add("No", "No");
            dgvRiwayat.Columns.Add("NamaUser", "Nama User");
            dgvRiwayat.Columns.Add("Lapangan", "Lapangan");
            dgvRiwayat.Columns.Add("Tanggal", "Tanggal");
            dgvRiwayat.Columns.Add("Jam", "Jam");
            dgvRiwayat.Columns.Add("Tarif", "Tarif");
            dgvRiwayat.Columns.Add("Metode", "Metode Pembayaran");
            dgvRiwayat.Columns.Add("StatusPembayaran", "Status Pembayaran");

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT u.nama AS nama_user, jenis.nama_jenis, l.nama_lapangan, 
                               j.tanggal, j.jam_mulai, j.jam_selesai, j.tarif, 
                               mp.nama_metode, pb.status_pembayaran
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
                            dgvRiwayat.Rows.Add(
                                no++,
                                reader["nama_user"].ToString(),
                                $"{reader["nama_jenis"]} - {reader["nama_lapangan"]}",
                                Convert.ToDateTime(reader["tanggal"]).ToString("yyyy-MM-dd"),
                                $"{reader["jam_mulai"]} - {reader["jam_selesai"]}",
                                Convert.ToInt32(reader["tarif"]).ToString("N0"),
                                reader["nama_metode"].ToString(),
                                reader["status_pembayaran"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AdminDashboardForm dashboard = new AdminDashboardForm();
            dashboard.Show();
            this.Close();
        }

        private void RiwayatPesananForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
