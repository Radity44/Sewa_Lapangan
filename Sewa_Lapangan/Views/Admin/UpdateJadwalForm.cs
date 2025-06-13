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
    public partial class UpdateJadwalForm : Form
    {
        public UpdateJadwalForm()
        {
            InitializeComponent();
            LoadDataJadwal();

        }

        private void LoadDataJadwal()
        {
            dgvJadwal.Rows.Clear();
            dgvJadwal.Columns.Clear();

            // Kolom manual dengan urutan benar:
            dgvJadwal.Columns.Add("No", "No");
            dgvJadwal.Columns.Add("JenisLapangan", "Jenis Lapangan");
            dgvJadwal.Columns.Add("NamaLapangan", "Nama Lapangan");
            dgvJadwal.Columns.Add("Tanggal", "Tanggal");
            dgvJadwal.Columns.Add("JamMulai", "Jam Mulai");
            dgvJadwal.Columns.Add("JamSelesai", "Jam Selesai");
            dgvJadwal.Columns.Add("Tarif", "Tarif");
            dgvJadwal.Columns.Add("Status", "Status");
            dgvJadwal.Columns.Add("IdJadwal", "Id Jadwal");  // taruh id di paling belakang
            dgvJadwal.Columns["IdJadwal"].Visible = false;

            // Tombol Edit
            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            editBtn.Name = "Edit";
            editBtn.HeaderText = "Edit";
            editBtn.Text = "Edit";
            editBtn.UseColumnTextForButtonValue = true;
            dgvJadwal.Columns.Add(editBtn);

            // Tombol Hapus
            DataGridViewButtonColumn hapusBtn = new DataGridViewButtonColumn();
            hapusBtn.Name = "Hapus";
            hapusBtn.HeaderText = "Hapus";
            hapusBtn.Text = "Hapus";
            hapusBtn.UseColumnTextForButtonValue = true;
            dgvJadwal.Columns.Add(hapusBtn);

            string query = @"
        SELECT jl.id_jadwal, jl.tanggal, jl.jam_mulai, jl.jam_selesai, jl.tarif, jl.status, 
               l.nama_lapangan, j.nama_jenis
        FROM jadwal_lapangan jl
        JOIN lapangan l ON jl.id_lapangan = l.id_lapangan
        JOIN jenis_lapangan j ON l.id_jenis = j.id_jenis
        ORDER BY jl.tanggal DESC, jl.jam_mulai ASC;";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    int no = 1;
                    while (reader.Read())
                    {
                        dgvJadwal.Rows.Add(
                            no++,
                            reader["nama_jenis"].ToString(),
                            reader["nama_lapangan"].ToString(),
                            Convert.ToDateTime(reader["tanggal"]).ToString("yyyy-MM-dd"),
                            reader["jam_mulai"].ToString(),
                            reader["jam_selesai"].ToString(),
                            reader["tarif"].ToString(),
                            reader["status"].ToString(),
                            reader["id_jadwal"].ToString()
                        );
                    }
                }
            }

            dgvJadwal.AllowUserToAddRows = false;
            dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJadwal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void dgvJadwal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // ambil id_jadwal dari hidden id (opsional)
                int rowIndex = e.RowIndex;

                string jenisLapangan = dgvJadwal.Rows[rowIndex].Cells["JenisLapangan"].Value.ToString();
                string namaLapangan = dgvJadwal.Rows[rowIndex].Cells["NamaLapangan"].Value.ToString();
                string tanggal = dgvJadwal.Rows[rowIndex].Cells["Tanggal"].Value.ToString();
                string jamMulai = dgvJadwal.Rows[rowIndex].Cells["JamMulai"].Value.ToString();
                int idJadwal = Convert.ToInt32(dgvJadwal.Rows[rowIndex].Cells["IdJadwal"].Value);

                if (dgvJadwal.Columns[e.ColumnIndex].Name == "Edit")
                {
                    EditJadwalForm editForm = new EditJadwalForm(idJadwal);
                    editForm.ShowDialog();
                    LoadDataJadwal();
                }

                if (dgvJadwal.Columns[e.ColumnIndex].Name == "Hapus")
                {
                    if (MessageBox.Show("Yakin hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DeleteJadwal(idJadwal);
                        LoadDataJadwal();
                    }
                }

            }
        }

        private void DeleteJadwal(int idJadwal)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = @"DELETE FROM jadwal_lapangan WHERE id_jadwal = @id_jadwal";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_jadwal", idJadwal);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            KelolaJadwalForm kelolaForm = new KelolaJadwalForm();
            kelolaForm.Show();
            this.Close();
        }

        private void UpdateJadwalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
