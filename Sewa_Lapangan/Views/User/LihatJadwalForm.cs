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

    public partial class LihatJadwalForm : Form
    {
        private PesanLapanganForm pesanForm = null;

        public LihatJadwalForm()
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

        private void LihatJadwalForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvJadwal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvJadwal.Columns[e.ColumnIndex].Name == "Pesan")
            {
                int idJadwal = Convert.ToInt32(dgvJadwal.Rows[e.RowIndex].Cells["IdJadwal"].Value);

                if (pesanForm == null || pesanForm.IsDisposed)
                {
                    pesanForm = new PesanLapanganForm();
                    pesanForm.Show();
                    this.Close();
                }

                pesanForm.AddJadwal(idJadwal);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (cmbJenisLapangan.SelectedItem == null)
            {
                MessageBox.Show("Pilih jenis lapangan terlebih dahulu.");
                return;
            }

            var jenisSelected = (JenisLapanganItem)cmbJenisLapangan.SelectedItem;
            DateTime tanggal = dtpTanggal.Value.Date;

            LoadDataJadwal(jenisSelected.Id, tanggal);
        }

        private void LoadDataJadwal(int idJenis, DateTime tanggal)
        {
            dgvJadwal.Rows.Clear();
            dgvJadwal.Columns.Clear();

            dgvJadwal.Columns.Add("IdJadwal", "Id Jadwal"); // Hidden
            dgvJadwal.Columns["IdJadwal"].Visible = false;

            dgvJadwal.Columns.Add("No", "No");
            dgvJadwal.Columns.Add("NamaLapangan", "Nama Lapangan");
            dgvJadwal.Columns.Add("JamMulai", "Jam Mulai");
            dgvJadwal.Columns.Add("JamSelesai", "Jam Selesai");
            dgvJadwal.Columns.Add("Tarif", "Tarif");
            dgvJadwal.Columns.Add("Status", "Status");

            // Tambahkan tombol PESAN
            DataGridViewButtonColumn pesanBtn = new DataGridViewButtonColumn();
            pesanBtn.Name = "Pesan";
            pesanBtn.HeaderText = "Aksi";
            pesanBtn.Text = "Pesan";
            pesanBtn.UseColumnTextForButtonValue = true;
            dgvJadwal.Columns.Add(pesanBtn);

            string query = @"
                SELECT jl.id_jadwal, jl.jam_mulai, jl.jam_selesai, jl.tarif, jl.status, l.nama_lapangan
                FROM jadwal_lapangan jl
                JOIN lapangan l ON jl.id_lapangan = l.id_lapangan
                JOIN jenis_lapangan j ON l.id_jenis = j.id_jenis
                WHERE j.id_jenis = @idJenis AND jl.tanggal = @tanggal AND jl.status = 'Tersedia'
                ORDER BY jl.jam_mulai;";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idJenis", idJenis);
                    cmd.Parameters.AddWithValue("@tanggal", tanggal);

                    using (var reader = cmd.ExecuteReader())
                    {
                        int no = 1;
                        while (reader.Read())
                        {
                            dgvJadwal.Rows.Add(
                                reader["id_jadwal"].ToString(),
                                no++,
                                reader["nama_lapangan"].ToString(),
                                reader["jam_mulai"].ToString(),
                                reader["jam_selesai"].ToString(),
                                reader["tarif"].ToString(),
                                reader["status"].ToString()
                            );
                        }
                    }
                }
            }

            dgvJadwal.AllowUserToAddRows = false;
            dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJadwal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbJenisLapangan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            UserDashboardForm dash = new UserDashboardForm();
            dash.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
