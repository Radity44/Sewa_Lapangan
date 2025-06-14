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

namespace Sewa_Lapangan.Views.User
{
    public partial class RiwayatPesananForm : Form
    {
        public RiwayatPesananForm()
        {
            InitializeComponent();
            LoadRiwayatPesananUser();
        }

        private void LoadRiwayatPesananUser()
        {
            dgvRiwayatUser.Rows.Clear();
            dgvRiwayatUser.Columns.Clear();

            dgvRiwayatUser.Columns.Add("No", "No");
            dgvRiwayatUser.Columns.Add("Lapangan", "Lapangan");
            dgvRiwayatUser.Columns.Add("Tanggal", "Tanggal");
            dgvRiwayatUser.Columns.Add("Jam", "Jam");
            dgvRiwayatUser.Columns.Add("Tarif", "Tarif");
            dgvRiwayatUser.Columns.Add("Metode", "Metode Pembayaran");
            dgvRiwayatUser.Columns.Add("StatusPembayaran", "Status Pembayaran");

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT jenis.nama_jenis, l.nama_lapangan, 
                           j.tanggal, j.jam_mulai, j.jam_selesai, j.tarif, 
                           mp.nama_metode, pb.status_pembayaran
                    FROM pembayaran pb
                    JOIN pemesanan p ON pb.id_pemesanan = p.id_pemesanan
                    JOIN jadwal_lapangan j ON p.id_jadwal = j.id_jadwal
                    JOIN lapangan l ON j.id_lapangan = l.id_lapangan
                    JOIN jenis_lapangan jenis ON l.id_jenis = jenis.id_jenis
                    JOIN metode_pembayaran mp ON pb.id_metode = mp.id_metode
                    WHERE p.id_user = @id_user
                    ORDER BY pb.id_pembayaran DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", SessionManager.UserId); // ambil user login aktif

                    using (var reader = cmd.ExecuteReader())
                    {
                        int no = 1;
                        while (reader.Read())
                        {
                            dgvRiwayatUser.Rows.Add(
                                no++,
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
            }

            dgvRiwayatUser.AllowUserToAddRows = false;
            dgvRiwayatUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayatUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void btnback_Click(object sender, EventArgs e)
        {
            UserDashboardForm dash = new UserDashboardForm();
            dash.Show();
            this.Close();
        }

        private void RiwayatPesananForm_Load(object sender, EventArgs e)
        {

        }
    }
}
