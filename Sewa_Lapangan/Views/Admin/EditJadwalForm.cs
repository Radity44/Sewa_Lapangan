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
    public partial class EditJadwalForm : Form
    {
        private int idJadwal;
        private int idLapangan;
        public EditJadwalForm(int idJadwal)
        {
            InitializeComponent();
            this.idJadwal = idJadwal;
            LoadJenisLapangan();
            LoadDataJadwal();
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
        }

        private void LoadNamaLapangan(int idJenis)
        {
            cmbNamaLapangan.Items.Clear();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT id_lapangan, nama_lapangan FROM lapangan WHERE id_jenis = @idJenis";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idJenis", idJenis);
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
        }

        private void LoadDataJadwal()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT jl.*, l.id_jenis, j.nama_jenis, l.nama_lapangan
                    FROM jadwal_lapangan jl
                    JOIN lapangan l ON jl.id_lapangan = l.id_lapangan
                    JOIN jenis_lapangan j ON l.id_jenis = j.id_jenis
                    WHERE jl.id_jadwal = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idJadwal);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idJenis = Convert.ToInt32(reader["id_jenis"]);

                            // Set jenis lapangan
                            for (int i = 0; i < cmbJenisLapangan.Items.Count; i++)
                            {
                                var item = (JenisLapanganItem)cmbJenisLapangan.Items[i];
                                if (item.Id == idJenis)
                                {
                                    cmbJenisLapangan.SelectedIndex = i;
                                    break;
                                }
                            }

                            LoadNamaLapangan(idJenis);

                            // Set nama lapangan
                            string namaLapangan = reader["nama_lapangan"].ToString();
                            for (int i = 0; i < cmbNamaLapangan.Items.Count; i++)
                            {
                                var item = (LapanganItem)cmbNamaLapangan.Items[i];
                                if (item.Nama == namaLapangan)
                                {
                                    cmbNamaLapangan.SelectedIndex = i;
                                    idLapangan = item.Id;
                                    break;
                                }
                            }

                            dtpTanggal.Value = Convert.ToDateTime(reader["tanggal"]);
                            txtJamMulai.Text = reader["jam_mulai"].ToString();
                            TimeSpan jamMulai = (TimeSpan)reader["jam_mulai"];
                            TimeSpan jamSelesai = (TimeSpan)reader["jam_selesai"];
                            numDurasi.Value = (decimal)(jamSelesai - jamMulai).TotalHours;
                            txtTarif.Text = reader["tarif"].ToString();
                        }
                    }
                }
            }
        }

        private void EditJadwalForm_Load(object sender, EventArgs e)
        {
            if (cmbJenisLapangan.SelectedItem != null)
            {
                var selectedJenis = (JenisLapanganItem)cmbJenisLapangan.SelectedItem;
                LoadNamaLapangan(selectedJenis.Id);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var jenisSelected = (JenisLapanganItem)cmbJenisLapangan.SelectedItem;
            var namaSelected = (LapanganItem)cmbNamaLapangan.SelectedItem;
            int idLapanganBaru = namaSelected.Id;

            DateTime tanggal = dtpTanggal.Value.Date;
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
                        UPDATE jadwal_lapangan
                        SET id_lapangan = @id_lapangan, tanggal = @tanggal,
                            jam_mulai = @jam_mulai, jam_selesai = @jam_selesai, tarif = @tarif
                        WHERE id_jadwal = @id_jadwal";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_lapangan", idLapanganBaru);
                        cmd.Parameters.AddWithValue("@tanggal", tanggal);
                        cmd.Parameters.AddWithValue("@jam_mulai", jamMulai);
                        cmd.Parameters.AddWithValue("@jam_selesai", jamSelesai);
                        cmd.Parameters.AddWithValue("@tarif", tarif);
                        cmd.Parameters.AddWithValue("@id_jadwal", idJadwal);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data berhasil diupdate!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            KelolaJadwalForm KelolaJadwal = new KelolaJadwalForm();
            KelolaJadwal.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
