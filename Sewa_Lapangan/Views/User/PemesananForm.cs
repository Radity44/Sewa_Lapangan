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
    public partial class PemesananForm : Form
    {
        private int idJadwal;
        private int idUser;
        public PemesananForm(int idJadwal, int idUser)
        {
            InitializeComponent();
            this.idJadwal = idJadwal;
            this.idUser = idUser;
            LoadJadwal();
        }

        private void LoadJadwal()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT jl.tanggal, jl.jam_mulai, jl.jam_selesai, jl.tarif, 
                           l.nama_lapangan, j.nama_jenis
                    FROM jadwal_lapangan jl
                    JOIN lapangan l ON jl.id_lapangan = l.id_lapangan
                    JOIN jenis_lapangan j ON l.id_jenis = j.id_jenis
                    WHERE jl.id_jadwal = @idJadwal";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idJadwal", idJadwal);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblJenisLapangan.Text = $"{reader["nama_jenis"]} - {reader["nama_lapangan"]}";
                            lblTanggal.Text = Convert.ToDateTime(reader["tanggal"]).ToString("yyyy-MM-dd");
                            lblJam.Text = $"{reader["jam_mulai"]} - {reader["jam_selesai"]}";
                            lblTarif.Text = reader["tarif"].ToString();
                        }
                    }
                }
            }
        }

        private void PemesananForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNamaPemesan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string namaPemesan = txtNamaPemesan.Text.Trim();
            string noHP = txtNoHP.Text.Trim();

            if (string.IsNullOrEmpty(namaPemesan) || string.IsNullOrEmpty(noHP))
            {
                MessageBox.Show("Nama dan Nomor HP wajib diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Insert ke tabel pemesanan
                    string insertPemesanan = @"
                INSERT INTO pemesanan (id_user, id_jadwal, tanggal_pesan, status_bayar)
                VALUES (@id_user, @id_jadwal, CURRENT_DATE, 'Belum Bayar')
                RETURNING id_pemesanan";

                    int idPemesanan;
                    using (var cmd = new NpgsqlCommand(insertPemesanan, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_user", idUser);
                        cmd.Parameters.AddWithValue("@id_jadwal", idJadwal);
                        idPemesanan = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Insert ke tabel detail_pemesanan
                    string insertDetail = @"
                INSERT INTO detail_pemesanan (id_pemesanan, nama_pemesan, nohp_pemesan)
                VALUES (@id_pemesanan, @nama, @nohp)";

                    using (var cmd2 = new NpgsqlCommand(insertDetail, conn))
                    {
                        cmd2.Parameters.AddWithValue("@id_pemesanan", idPemesanan);
                        cmd2.Parameters.AddWithValue("@nama", namaPemesan);
                        cmd2.Parameters.AddWithValue("@nohp", noHP);
                        cmd2.ExecuteNonQuery();
                    }

                    // Hapus data dari cart setelah selesai pesan
                    string deleteCart = @"
                DELETE FROM cart_pemesanan
                WHERE id_user = @id_user AND id_jadwal = @id_jadwal";

                    using (var cmdDel = new NpgsqlCommand(deleteCart, conn))
                    {
                        cmdDel.Parameters.AddWithValue("@id_user", idUser);
                        cmdDel.Parameters.AddWithValue("@id_jadwal", idJadwal);
                        cmdDel.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pemesanan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kembali ke Dashboard
                UserDashboardForm dashboard = new UserDashboardForm();
                dashboard.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            PesanLapanganForm pesanLapangan = new PesanLapanganForm();
            pesanLapangan.Show();
            this.Close();
        }
    }
}
