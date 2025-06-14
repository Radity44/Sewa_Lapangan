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
    public partial class ListPembayaranForm : Form
    {
        public ListPembayaranForm()
        {
            InitializeComponent();
            LoadPesananBelumBayar();
        }

        private void LoadPesananBelumBayar()
        {
            dgvPesanan.Rows.Clear();
            dgvPesanan.Columns.Clear();

            dgvPesanan.Columns.Add("IdPemesanan", "Id Pemesanan");
            dgvPesanan.Columns["IdPemesanan"].Visible = false;
            dgvPesanan.Columns.Add("No", "No");
            dgvPesanan.Columns.Add("JenisLapangan", "Jenis Lapangan");
            dgvPesanan.Columns.Add("Tanggal", "Tanggal");
            dgvPesanan.Columns.Add("Jam", "Jam");
            dgvPesanan.Columns.Add("Tarif", "Tarif");
            dgvPesanan.Columns.Add("Status", "Status");

            // Tambahkan tombol Bayar
            DataGridViewButtonColumn bayarBtn = new DataGridViewButtonColumn();
            bayarBtn.Name = "Bayar";
            bayarBtn.HeaderText = "Aksi";
            bayarBtn.Text = "Bayar";
            bayarBtn.UseColumnTextForButtonValue = true;
            dgvPesanan.Columns.Add(bayarBtn);

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                SELECT p.id_pemesanan, j.tanggal, j.jam_mulai, j.jam_selesai, j.tarif, l.nama_lapangan, jenis.nama_jenis, p.status_bayar
                FROM pemesanan p
                JOIN jadwal_lapangan j ON p.id_jadwal = j.id_jadwal
                JOIN lapangan l ON j.id_lapangan = l.id_lapangan
                JOIN jenis_lapangan jenis ON l.id_jenis = jenis.id_jenis
                WHERE p.id_user = @id_user AND p.status_bayar = 'Belum Bayar'
            ";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", SessionManager.UserId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        int no = 1;
                        while (reader.Read())
                        {
                            dgvPesanan.Rows.Add(
                                reader["id_pemesanan"].ToString(),
                                no++,
                                $"{reader["nama_jenis"]} - {reader["nama_lapangan"]}",
                                Convert.ToDateTime(reader["tanggal"]).ToString("yyyy-MM-dd"),
                                $"{reader["jam_mulai"]} - {reader["jam_selesai"]}",
                                reader["tarif"].ToString(),
                                reader["status_bayar"].ToString()
                            );
                        }
                    }
                }
            }

            dgvPesanan.AllowUserToAddRows = false;
            dgvPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPesanan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            UserDashboardForm dash = new UserDashboardForm();
            dash.Show();
            this.Close();
        }

        private void dgvPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPesanan.Columns[e.ColumnIndex].Name == "Bayar")
            {
                int idPemesanan = Convert.ToInt32(dgvPesanan.Rows[e.RowIndex].Cells["IdPemesanan"].Value);
                PembayaranDetailForm detailForm = new PembayaranDetailForm(idPemesanan);
                detailForm.Show();
                this.Close();
            }
        }
    }
}
