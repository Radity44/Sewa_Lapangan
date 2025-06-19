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
    public partial class PesanLapanganForm : Form
    {
        public PesanLapanganForm()
        {
            InitializeComponent();
            LoadPesanan();
        }

        // Method untuk menambahkan id_jadwal ke dalam daftar
        public void AddJadwal(int idJadwal)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // Cek apakah sudah ada
                string cekQuery = @"
            SELECT COUNT(*) FROM cart_pemesanan
            WHERE id_user = @id_user AND id_jadwal = @id_jadwal";

                using (var cmdCek = new NpgsqlCommand(cekQuery, conn))
                {
                    cmdCek.Parameters.AddWithValue("@id_user", SessionManager.UserId);
                    cmdCek.Parameters.AddWithValue("@id_jadwal", idJadwal);
                    int count = Convert.ToInt32(cmdCek.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Jadwal ini sudah masuk dalam daftar pemesanan.");
                        return;
                    }
                }

                // Insert ke cart_pemesanan
                string insertQuery = @"
            INSERT INTO cart_pemesanan (id_user, id_jadwal)
            VALUES (@id_user, @id_jadwal)";

                using (var cmdInsert = new NpgsqlCommand(insertQuery, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@id_user", SessionManager.UserId);
                    cmdInsert.Parameters.AddWithValue("@id_jadwal", idJadwal);
                    cmdInsert.ExecuteNonQuery();
                }

                MessageBox.Show("Jadwal berhasil ditambahkan ke keranjang.");
                LoadPesanan();
            }
        }

        private void LoadPesanan()
        {
            dgvPesanan.Rows.Clear();
            dgvPesanan.Columns.Clear();

            dgvPesanan.Columns.Add("No", "No");
            dgvPesanan.Columns.Add("NamaLapangan", "Nama Lapangan");
            dgvPesanan.Columns.Add("Tanggal", "Tanggal");
            dgvPesanan.Columns.Add("JamMulai", "Jam Mulai");
            dgvPesanan.Columns.Add("JamSelesai", "Jam Selesai");
            dgvPesanan.Columns.Add("Tarif", "Tarif");
            dgvPesanan.Columns.Add("IdJadwal", "Id Jadwal");
            dgvPesanan.Columns["IdJadwal"].Visible = false;

            // Tambahkan tombol Detail
            DataGridViewButtonColumn detailBtn = new DataGridViewButtonColumn();
            detailBtn.Name = "Detail";
            detailBtn.HeaderText = "Aksi";
            detailBtn.Text = "Detail";
            detailBtn.UseColumnTextForButtonValue = true;
            dgvPesanan.Columns.Add(detailBtn);

            int no = 1;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT jl.id_jadwal, jl.tanggal, jl.jam_mulai, jl.jam_selesai, jl.tarif, 
                   l.nama_lapangan, j.nama_jenis
            FROM cart_pemesanan cp
            JOIN jadwal_lapangan jl ON cp.id_jadwal = jl.id_jadwal
            JOIN lapangan l ON jl.id_lapangan = l.id_lapangan
            JOIN jenis_lapangan j ON l.id_jenis = j.id_jenis
            WHERE cp.id_user = @id_user
            ORDER BY jl.tanggal, jl.jam_mulai";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", SessionManager.UserId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvPesanan.Rows.Add(
                                no++,
                                reader["nama_jenis"].ToString() + " - " + reader["nama_lapangan"].ToString(),
                                Convert.ToDateTime(reader["tanggal"]).ToString("yyyy-MM-dd"),
                                reader["jam_mulai"].ToString(),
                                reader["jam_selesai"].ToString(),
                                reader["tarif"].ToString(),
                                reader["id_jadwal"].ToString()
                            );
                        }
                    }
                }
            }

            dgvPesanan.AllowUserToAddRows = false;
            dgvPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPesanan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }


        private void PesanLapanganForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPesanan.Columns[e.ColumnIndex].Name == "Detail")
            {
                int idJadwal = Convert.ToInt32(dgvPesanan.Rows[e.RowIndex].Cells["IdJadwal"].Value);

                using (var pemesananForm = new PemesananForm(idJadwal, SessionManager.UserId))
                {
                    var result = pemesananForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        LoadPesanan();  // hanya reload jika berhasil
                    }
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            UserDashboardForm dashboard = new UserDashboardForm();
            dashboard.Show();
            this.Close();
        }
    }
}
