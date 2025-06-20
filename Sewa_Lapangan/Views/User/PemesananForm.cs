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

            // 1️⃣ Validasi input kosong
            if (!System.Text.RegularExpressions.Regex.IsMatch(noHP, @"^08[0-9]{8,}$"))
            {
                MessageBox.Show("Nomor tidak valid.", "Validasi No HP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2️⃣ Validasi nama harus mengandung huruf
            if (!System.Text.RegularExpressions.Regex.IsMatch(namaPemesan, @"[a-zA-Z]"))
            {
                MessageBox.Show("Nama pemesan harus mengandung huruf.", "Validasi Nama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3️⃣ Validasi nomor HP: angka, min 2 digit, mulai dengan 08
            if (!System.Text.RegularExpressions.Regex.IsMatch(noHP, @"^08[0-9]{1,}$"))
            {
                MessageBox.Show("Nomor HP harus berupa angka, minimal 2 digit dan dimulai dengan '08'.", "Validasi No HP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // 4️⃣ Ambil tarif dari jadwal lapangan
                    int totalBiaya = 0;
                    string queryTarif = "SELECT tarif FROM jadwal_lapangan WHERE id_jadwal = @id_jadwal";
                    using (var cmdTarif = new NpgsqlCommand(queryTarif, conn))
                    {
                        cmdTarif.Parameters.AddWithValue("@id_jadwal", idJadwal);
                        totalBiaya = Convert.ToInt32(cmdTarif.ExecuteScalar());
                    }

                    // 5️⃣ Insert ke pemesanan
                    string insertPemesanan = @"
                INSERT INTO pemesanan (id_user, id_jadwal, id_lapangan, total_biaya, status_bayar, status_pemesanan)
                VALUES (@id_user, @id_jadwal, 
                    (SELECT id_lapangan FROM jadwal_lapangan WHERE id_jadwal = @id_jadwal), 
                    @total_biaya, 'Belum Bayar', 'Aktif')
                RETURNING id_pemesanan";

                    int idPemesanan;
                    using (var cmd = new NpgsqlCommand(insertPemesanan, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_user", idUser);
                        cmd.Parameters.AddWithValue("@id_jadwal", idJadwal);
                        cmd.Parameters.AddWithValue("@total_biaya", totalBiaya);
                        idPemesanan = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 6️⃣ Insert ke detail_pemesanan
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

                    // 7️⃣ Hapus dari cart
                    string deleteCart = @"
                DELETE FROM cart_pemesanan
                WHERE id_user = @id_user AND id_jadwal = @id_jadwal";

                    using (var cmdDel = new NpgsqlCommand(deleteCart, conn))
                    {
                        cmdDel.Parameters.AddWithValue("@id_user", idUser);
                        cmdDel.Parameters.AddWithValue("@id_jadwal", idJadwal);
                        cmdDel.ExecuteNonQuery();
                    }

                    // 8️⃣ Update status jadwal
                    string updateStatus = @"
                UPDATE jadwal_lapangan
                SET status = 'Terpesan'
                WHERE id_jadwal = @id_jadwal";

                    using (var cmdStatus = new NpgsqlCommand(updateStatus, conn))
                    {
                        cmdStatus.Parameters.AddWithValue("@id_jadwal", idJadwal);
                        cmdStatus.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pemesanan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // agar ShowDialog() bisa menerima sinyal sukses
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // atau None, sesuai kebutuhan
            this.Close();
        }

        private void txtNoHP_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblTanggal_Click(object sender, EventArgs e)
        {

        }

        private void lblJam_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
