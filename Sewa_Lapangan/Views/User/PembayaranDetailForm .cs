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
    public partial class PembayaranDetailForm : Form
    {
        private int idPemesanan;
        public PembayaranDetailForm(int idPemesanan)
        {
            InitializeComponent();
            this.idPemesanan = idPemesanan;
            LoadDetailPemesanan();
            LoadMetodePembayaran();
        }

        private void LoadDetailPemesanan()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT j.tanggal, j.jam_mulai, j.jam_selesai, j.tarif, 
                           l.nama_lapangan, jenis.nama_jenis,
                           d.nama_pemesan, d.nohp_pemesan
                    FROM pemesanan p
                    JOIN jadwal_lapangan j ON p.id_jadwal = j.id_jadwal
                    JOIN lapangan l ON j.id_lapangan = l.id_lapangan
                    JOIN jenis_lapangan jenis ON l.id_jenis = jenis.id_jenis
                    JOIN detail_pemesanan d ON p.id_pemesanan = d.id_pemesanan
                    WHERE p.id_pemesanan = @id_pemesanan";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_pemesanan", idPemesanan);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblJenisLapangan.Text = $"{reader["nama_jenis"]} - {reader["nama_lapangan"]}";
                            lblTanggal.Text = Convert.ToDateTime(reader["tanggal"]).ToString("yyyy-MM-dd");
                            lblJam.Text = $"{reader["jam_mulai"]} - {reader["jam_selesai"]}";
                            lblTarif.Text = reader["tarif"].ToString();

                            lblNamaPemesan.Text = reader["nama_pemesan"].ToString();
                            lblNoHPPemesan.Text = reader["nohp_pemesan"].ToString();
                        }
                    }
                }
            }
        }

        private void LoadMetodePembayaran()
        {
            cmbMetodePembayaran.Items.Clear();
            cmbMetodePembayaran.Items.Add("Cash");
            cmbMetodePembayaran.Items.Add("Transfer");
            cmbMetodePembayaran.SelectedIndex = 0;

            lblBank.Text = "";
            lblNoRekening.Text = "";
            lblAtasNama.Text = "";
        }

        private void LoadRekening()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT nama_bank, nomor_rekening, nama_rekening FROM rekening_admin LIMIT 1";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblBank.Text = reader["nama_bank"].ToString();
                        lblNoRekening.Text = reader["nomor_rekening"].ToString();
                        lblAtasNama.Text = reader["nama_rekening"].ToString();
                    }
                }
            }
        }


        private void PembayaranDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            string metode = cmbMetodePembayaran.SelectedItem.ToString();
            int idMetode = (metode == "Cash") ? 1 : 2;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO pembayaran (id_pemesanan, id_metode, waktu_pembayaran, status_pembayaran)
                        VALUES (@id_pemesanan, @id_metode, NOW(), 'Menunggu')";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_pemesanan", idPemesanan);
                        cmd.Parameters.AddWithValue("@id_metode", idMetode);
                        cmd.ExecuteNonQuery();
                    }

                    string updatePemesanan = @"UPDATE pemesanan SET status_bayar = 'Menunggu' WHERE id_pemesanan = @id_pemesanan";
                    using (var cmdUpdate = new NpgsqlCommand(updatePemesanan, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@id_pemesanan", idPemesanan);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pembayaran berhasil disimpan, menunggu verifikasi admin!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserDashboardForm dashboard = new UserDashboardForm();
                dashboard.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            ListPembayaranForm list = new ListPembayaranForm();
            list.Show();
            this.Close();
        }

        private void cmbMetodePembayaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMetodePembayaran.SelectedItem.ToString() == "Transfer")
            {
                LoadRekening();
            }
            else
            {
                lblBank.Text = "";
                lblNoRekening.Text = "";
                lblAtasNama.Text = "";
            }
        }
    }
}
