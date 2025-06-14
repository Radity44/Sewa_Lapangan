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
    public partial class UserDashboardForm : Form
    {
        public UserDashboardForm()
        {
            InitializeComponent();
        }

        private void btnLihatJadwal_Click(object sender, EventArgs e)
        {
            LihatJadwalForm lihatForm = new LihatJadwalForm();
            lihatForm.Show();
            this.Hide();
        }

        private void btnPesanLapangan_Click(object sender, EventArgs e)
        {
            PesanLapanganForm pesanForm = new PesanLapanganForm();
            pesanForm.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Optional clear session (jika pakai SessionManager)
            SessionManager.UserId = 0;
            SessionManager.UserName = "";

            // Kembali ke form login
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {

        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            ListPembayaranForm pembayaranForm = new ListPembayaranForm();
            pembayaranForm.Show();
            this.Close();
        }

        private void btnRiwayat_Click_1(object sender, EventArgs e)
        {
            RiwayatPesananForm riwayatPesananForm = new RiwayatPesananForm();
            riwayatPesananForm.Show();
            this.Close();
        }
    }
}
