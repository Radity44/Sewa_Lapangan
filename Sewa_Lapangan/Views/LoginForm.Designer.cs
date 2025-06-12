namespace Sewa_Lapangan.Views
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label4 = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            LinkToRegister = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(LinkToRegister);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(177, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 353);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 291);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 6;
            label4.Text = "Belum memiliki akun?";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(191, 245);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(81, 189);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(352, 27);
            txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(81, 123);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(352, 27);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 153);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 89);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 25);
            label1.Name = "label1";
            label1.Size = new Size(229, 31);
            label1.TabIndex = 0;
            label1.Text = "LOGIN TO GOSPORT";
            // 
            // LinkToRegister
            // 
            LinkToRegister.AutoSize = true;
            LinkToRegister.Location = new Point(300, 291);
            LinkToRegister.Name = "LinkToRegister";
            LinkToRegister.Size = new Size(63, 20);
            LinkToRegister.TabIndex = 8;
            LinkToRegister.TabStop = true;
            LinkToRegister.Text = "Register";
            LinkToRegister.LinkClicked += LinkToRegister_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginFrom";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label4;
        private LinkLabel LinkToRegister;
    }
}