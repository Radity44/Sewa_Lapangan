using Sewa_Lapangan.Controllers;
using Sewa_Lapangan.Models;
using Sewa_Lapangan.Views.Admin;
using Sewa_Lapangan.Views.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sewa_Lapangan.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            // Validasi sederhana
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email dan Password harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proses login lewat controller
            UserModel user = AuthController.Login(email, password);

            if (user != null)
            {
                SessionManager.UserId = user.IdUser;
                SessionManager.UserName = user.Nama;
                SessionManager.Role = user.Role;
                MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cek role user
                if (user.Role == "admin")
                {
                    var adminDashboard = new AdminDashboardForm();
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    var userDashboard = new UserDashboardForm();
                    userDashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Email atau Password salah.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LinkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
