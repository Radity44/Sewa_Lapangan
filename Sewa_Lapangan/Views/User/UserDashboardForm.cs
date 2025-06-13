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
    }
}
