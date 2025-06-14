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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Sewa_Lapangan.Views.Admin
{
    public partial class KelolaJadwalForm : Form
    {
        public KelolaJadwalForm()
        {
            InitializeComponent();

            LoadJenisLapangan();
            dtpTanggal.MinDate = DateTime.Today;
        }

        private void LoadJenisLapangan()
        {
            cmbJenisLapangan.Items.Clear();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT id_jenis, nama_jenis FROM jenis_lapangan";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbJenisLapangan.Items.Add(new JenisLapanganItem
                        {
                            Id = Convert.ToInt32(reader["id_jenis"]),
                            Nama = reader["nama_jenis"].ToString()
                        });
                    }
                }
            }

            if (cmbJenisLapangan.Items.Count > 0)
                cmbJenisLapangan.SelectedIndex = 0;
        }

        public class LapanganItem
        {
            public int Id { get; set; }
            public string Nama { get; set; }

            public override string ToString()
            {
                return Nama;
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbJenisLapangan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNamaLapangan.Items.Clear();

            var selectedJenis = (JenisLapanganItem)cmbJenisLapangan.SelectedItem;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT id_lapangan, nama_lapangan FROM lapangan WHERE id_jenis = @idJenis";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idJenis", selectedJenis.Id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbNamaLapangan.Items.Add(new LapanganItem
                            {
                                Id = Convert.ToInt32(reader["id_lapangan"]),
                                Nama = reader["nama_lapangan"].ToString()
                            });
                        }
                    }
                }
            }

            if (cmbNamaLapangan.Items.Count > 0)
                cmbNamaLapangan.SelectedIndex = 0;
        }

        private void cmbNamaLapangan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private DateTime AmbilTanggal()
        {
            return dtpTanggal.Value.Date;
        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtJamMulai_TextChanged(object sender, EventArgs e)
        {

        }

        private void numDurasi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTarif_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbJenisLapangan.SelectedItem == null || cmbNamaLapangan.SelectedItem == null)
            {
                MessageBox.Show("Lengkapi pilihan jenis dan nama lapangan.");
                return;
            }

            var jenisSelected = (JenisLapanganItem)cmbJenisLapangan.SelectedItem;
            var namaLapangan = (LapanganItem)cmbNamaLapangan.SelectedItem;

            DateTime tanggal = AmbilTanggal();
            string jamMulaiStr = txtJamMulai.Text.Trim();
            int durasi = (int)numDurasi.Value;
            string tarifStr = txtTarif.Text.Trim();

            if (!TimeSpan.TryParse(jamMulaiStr, out TimeSpan jamMulai))
            {
                MessageBox.Show("Format Jam Mulai salah. Contoh: 08:00");
                return;
            }

            if (!int.TryParse(tarifStr, out int tarif))
            {
                MessageBox.Show("Tarif harus berupa angka.");
                return;
            }

            TimeSpan jamSelesai = jamMulai.Add(TimeSpan.FromHours(durasi));

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO jadwal_lapangan 
                        (id_lapangan, tanggal, jam_mulai, jam_selesai, tarif, status)
                        VALUES 
                        (@id_lapangan, @tanggal, @jam_mulai, @jam_selesai, @tarif, @status);
                    ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_lapangan", namaLapangan.Id);
                        cmd.Parameters.AddWithValue("@tanggal", tanggal);
                        cmd.Parameters.AddWithValue("@jam_mulai", jamMulai);
                        cmd.Parameters.AddWithValue("@jam_selesai", jamSelesai);
                        cmd.Parameters.AddWithValue("@tarif", tarif);
                        cmd.Parameters.AddWithValue("@status", "Tersedia");

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Jadwal berhasil disimpan.");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            cmbJenisLapangan.SelectedIndex = 0;
            cmbNamaLapangan.Items.Clear();
            dtpTanggal.Value = DateTime.Today;
            txtJamMulai.Clear();
            numDurasi.Value = 1;
            txtTarif.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AdminDashboardForm dashboard = new AdminDashboardForm();
            dashboard.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateJadwalForm updateForm = new UpdateJadwalForm();
            updateForm.Show();
            this.Hide();
        }
    }
}
