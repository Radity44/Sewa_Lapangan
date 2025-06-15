namespace Sewa_Lapangan.Views.Admin
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            GOSPORT = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            btnDashboard = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            btnKelolaJadwal = new Button();
            button3 = new Button();
            panel6 = new Panel();
            panel7 = new Panel();
            btnKelolaTransaksi = new Button();
            button5 = new Button();
            panel14 = new Panel();
            panel15 = new Panel();
            btnRiwayatPesanan = new Button();
            button8 = new Button();
            panel10 = new Panel();
            panel11 = new Panel();
            btnLogout = new Button();
            button9 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            dgvDataUser = new DataGridView();
            lblTotalUser = new Label();
            lblTotalTransaksi = new Label();
            U = new GroupBox();
            groupBox2 = new GroupBox();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataUser).BeginInit();
            U.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(35, 40, 45);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel14);
            flowLayoutPanel1.Controls.Add(panel10);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(247, 680);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(GOSPORT);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 83);
            panel1.TabIndex = 1;
            // 
            // GOSPORT
            // 
            GOSPORT.AutoSize = true;
            GOSPORT.BorderStyle = BorderStyle.Fixed3D;
            GOSPORT.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GOSPORT.ForeColor = Color.White;
            GOSPORT.Location = new Point(34, 16);
            GOSPORT.Name = "GOSPORT";
            GOSPORT.Size = new Size(147, 40);
            GOSPORT.TabIndex = 3;
            GOSPORT.Text = "GOSPORT";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnDashboard);
            panel2.Location = new Point(3, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 62);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Location = new Point(0, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 70);
            panel3.TabIndex = 3;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.FromArgb(35, 40, 45);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-5, -52);
            button1.Name = "button1";
            button1.Size = new Size(286, 164);
            button1.TabIndex = 0;
            button1.Text = "             Beranda";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDashboard.BackColor = Color.FromArgb(35, 40, 45);
            btnDashboard.BackgroundImageLayout = ImageLayout.None;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(-5, -52);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(286, 164);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "             Beranda";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click_1;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 160);
            panel4.Name = "panel4";
            panel4.Size = new Size(242, 62);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnKelolaJadwal);
            panel5.Location = new Point(0, 8);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 70);
            panel5.TabIndex = 3;
            // 
            // btnKelolaJadwal
            // 
            btnKelolaJadwal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnKelolaJadwal.BackColor = Color.FromArgb(35, 40, 45);
            btnKelolaJadwal.BackgroundImageLayout = ImageLayout.None;
            btnKelolaJadwal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaJadwal.ForeColor = Color.White;
            btnKelolaJadwal.Image = (Image)resources.GetObject("btnKelolaJadwal.Image");
            btnKelolaJadwal.ImageAlign = ContentAlignment.MiddleLeft;
            btnKelolaJadwal.Location = new Point(-5, -52);
            btnKelolaJadwal.Name = "btnKelolaJadwal";
            btnKelolaJadwal.Size = new Size(286, 164);
            btnKelolaJadwal.TabIndex = 0;
            btnKelolaJadwal.Text = "             Kelola Jadwal";
            btnKelolaJadwal.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaJadwal.UseVisualStyleBackColor = false;
            btnKelolaJadwal.Click += btnKelolaJadwal_Click;
            // 
            // button3
            // 
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackColor = Color.FromArgb(35, 40, 45);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-5, -52);
            button3.Name = "button3";
            button3.Size = new Size(286, 164);
            button3.TabIndex = 0;
            button3.Text = "             Beranda";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(button5);
            panel6.Location = new Point(3, 228);
            panel6.Name = "panel6";
            panel6.Size = new Size(242, 62);
            panel6.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnKelolaTransaksi);
            panel7.Location = new Point(0, 8);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 70);
            panel7.TabIndex = 3;
            // 
            // btnKelolaTransaksi
            // 
            btnKelolaTransaksi.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnKelolaTransaksi.BackColor = Color.FromArgb(35, 40, 45);
            btnKelolaTransaksi.BackgroundImageLayout = ImageLayout.None;
            btnKelolaTransaksi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaTransaksi.ForeColor = Color.White;
            btnKelolaTransaksi.Image = (Image)resources.GetObject("btnKelolaTransaksi.Image");
            btnKelolaTransaksi.ImageAlign = ContentAlignment.MiddleLeft;
            btnKelolaTransaksi.Location = new Point(-5, -52);
            btnKelolaTransaksi.Name = "btnKelolaTransaksi";
            btnKelolaTransaksi.Size = new Size(286, 164);
            btnKelolaTransaksi.TabIndex = 0;
            btnKelolaTransaksi.Text = "             Kelola Transaksi";
            btnKelolaTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaTransaksi.UseVisualStyleBackColor = false;
            btnKelolaTransaksi.Click += btnKelolaTransaksi_Click;
            // 
            // button5
            // 
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.BackColor = Color.FromArgb(35, 40, 45);
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-5, -52);
            button5.Name = "button5";
            button5.Size = new Size(286, 164);
            button5.TabIndex = 0;
            button5.Text = "             Beranda";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            panel14.Controls.Add(panel15);
            panel14.Controls.Add(button8);
            panel14.Location = new Point(3, 296);
            panel14.Name = "panel14";
            panel14.Size = new Size(242, 62);
            panel14.TabIndex = 5;
            // 
            // panel15
            // 
            panel15.Controls.Add(btnRiwayatPesanan);
            panel15.Location = new Point(0, 8);
            panel15.Name = "panel15";
            panel15.Size = new Size(250, 70);
            panel15.TabIndex = 3;
            // 
            // btnRiwayatPesanan
            // 
            btnRiwayatPesanan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRiwayatPesanan.BackColor = Color.FromArgb(35, 40, 45);
            btnRiwayatPesanan.BackgroundImageLayout = ImageLayout.None;
            btnRiwayatPesanan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatPesanan.ForeColor = Color.White;
            btnRiwayatPesanan.Image = (Image)resources.GetObject("btnRiwayatPesanan.Image");
            btnRiwayatPesanan.ImageAlign = ContentAlignment.MiddleLeft;
            btnRiwayatPesanan.Location = new Point(-5, -54);
            btnRiwayatPesanan.Name = "btnRiwayatPesanan";
            btnRiwayatPesanan.Size = new Size(286, 164);
            btnRiwayatPesanan.TabIndex = 0;
            btnRiwayatPesanan.Text = "             Lihat Riwayat";
            btnRiwayatPesanan.TextAlign = ContentAlignment.MiddleLeft;
            btnRiwayatPesanan.UseVisualStyleBackColor = false;
            btnRiwayatPesanan.Click += btnRiwayatPesanan_Click;
            // 
            // button8
            // 
            button8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button8.BackColor = Color.FromArgb(35, 40, 45);
            button8.BackgroundImageLayout = ImageLayout.None;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(-5, -52);
            button8.Name = "button8";
            button8.Size = new Size(286, 164);
            button8.TabIndex = 0;
            button8.Text = "             Beranda";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(button9);
            panel10.Location = new Point(3, 364);
            panel10.Name = "panel10";
            panel10.Size = new Size(242, 62);
            panel10.TabIndex = 4;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnLogout);
            panel11.Location = new Point(0, 8);
            panel11.Name = "panel11";
            panel11.Size = new Size(250, 70);
            panel11.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.BackColor = Color.FromArgb(35, 40, 45);
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-4, -53);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(286, 164);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "             Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // button9
            // 
            button9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button9.BackColor = Color.FromArgb(35, 40, 45);
            button9.BackgroundImageLayout = ImageLayout.None;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(-5, -52);
            button9.Name = "button9";
            button9.Size = new Size(286, 164);
            button9.TabIndex = 0;
            button9.Text = "             Beranda";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(35, 40, 45);
            label1.Location = new Point(261, 19);
            label1.Name = "label1";
            label1.Size = new Size(257, 40);
            label1.TabIndex = 4;
            label1.Text = "Dashboard Admin";
            // 
            // dgvDataUser
            // 
            dgvDataUser.AllowUserToAddRows = false;
            dgvDataUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataUser.Location = new Point(281, 278);
            dgvDataUser.Name = "dgvDataUser";
            dgvDataUser.RowHeadersWidth = 51;
            dgvDataUser.Size = new Size(694, 319);
            dgvDataUser.TabIndex = 5;
            dgvDataUser.CellContentClick += dgvDataUser_CellContentClick;
            // 
            // lblTotalUser
            // 
            lblTotalUser.AutoSize = true;
            lblTotalUser.Location = new Point(93, 48);
            lblTotalUser.Name = "lblTotalUser";
            lblTotalUser.Size = new Size(50, 20);
            lblTotalUser.TabIndex = 6;
            lblTotalUser.Text = "label2";
            // 
            // lblTotalTransaksi
            // 
            lblTotalTransaksi.AutoSize = true;
            lblTotalTransaksi.Location = new Point(51, 46);
            lblTotalTransaksi.Name = "lblTotalTransaksi";
            lblTotalTransaksi.Size = new Size(50, 20);
            lblTotalTransaksi.TabIndex = 7;
            lblTotalTransaksi.Text = "label3";
            // 
            // U
            // 
            U.Controls.Add(lblTotalUser);
            U.Location = new Point(312, 128);
            U.Name = "U";
            U.Size = new Size(276, 108);
            U.TabIndex = 8;
            U.TabStop = false;
            U.Text = "User Terdaftar";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotalTransaksi);
            groupBox2.Location = new Point(678, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(276, 108);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Total Pendapatan";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 680);
            Controls.Add(groupBox2);
            Controls.Add(U);
            Controls.Add(dgvDataUser);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            Load += AdminDashboardForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDataUser).EndInit();
            U.ResumeLayout(false);
            U.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDashboard;
        private Panel panel1;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel3;
        private Button button1;
        private Panel panel4;
        private Panel panel5;
        private Button btnKelolaJadwal;
        private Button button3;
        private Panel panel6;
        private Panel panel7;
        private Button btnKelolaTransaksi;
        private Button button5;
        private Panel panel8;
        private Panel panel9;
        private Button btnLihatRiwayat;
        private Button button7;
        private Panel panel10;
        private Panel panel11;
        private Button btnLogout;
        private Button button9;
        private Label GOSPORT;
        private Label label1;
        private DataGridView dgvDataUser;
        private Label lblTotalUser;
        private Label lblTotalTransaksi;
        private GroupBox U;
        private GroupBox groupBox2;
        private Panel panel12;
        private Panel panel13;
        private Button button2;
        private Button button4;
        private Panel panel14;
        private Panel panel15;
        private Button btnRiwayatPesanan;
        private Button button8;
    }
}