using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sewa_Lapangan.Controllers;

namespace Sewa_Lapangan.Views
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            // Validasi input sederhana
            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Semua kolom wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password minimal 6 karakter.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proses register via AuthController
            bool result = AuthController.Register(nama, email, password);

            if (result)
            {
                MessageBox.Show("Registrasi berhasil, silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new LoginForm().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Email sudah terdaftar.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGoToLogin_Click(object sender, EventArgs e)
        {

        }

        private void linkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
