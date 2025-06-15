namespace Sewa_Lapangan.Views.User
{
    partial class PembayaranDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PembayaranDetailForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnback = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblNoHPPemesan = new Label();
            lblNamaPemesan = new Label();
            lblTarif = new Label();
            lblJam = new Label();
            lblTanggal = new Label();
            lblJenisLapangan = new Label();
            groupBox2 = new GroupBox();
            lblAtasNama = new Label();
            btnBayar = new Button();
            lblNoRekening = new Label();
            lblBank = new Label();
            cmbMetodePembayaran = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(35, 40, 45);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(834, 44);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnback);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(46, 37);
            panel1.TabIndex = 1;
            // 
            // btnback
            // 
            btnback.FlatStyle = FlatStyle.Flat;
            btnback.Image = (Image)resources.GetObject("btnback.Image");
            btnback.Location = new Point(-6, -15);
            btnback.Name = "btnback";
            btnback.Size = new Size(57, 68);
            btnback.TabIndex = 1;
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 43);
            label1.TabIndex = 1;
            label1.Text = "Pembayaran";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblNoHPPemesan);
            groupBox1.Controls.Add(lblNamaPemesan);
            groupBox1.Controls.Add(lblTarif);
            groupBox1.Controls.Add(lblJam);
            groupBox1.Controls.Add(lblTanggal);
            groupBox1.Controls.Add(lblJenisLapangan);
            groupBox1.Location = new Point(132, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(515, 246);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail Pesanan";
            // 
            // lblNoHPPemesan
            // 
            lblNoHPPemesan.AutoSize = true;
            lblNoHPPemesan.Location = new Point(171, 212);
            lblNoHPPemesan.Name = "lblNoHPPemesan";
            lblNoHPPemesan.Size = new Size(50, 20);
            lblNoHPPemesan.TabIndex = 5;
            lblNoHPPemesan.Text = "label3";
            // 
            // lblNamaPemesan
            // 
            lblNamaPemesan.AutoSize = true;
            lblNamaPemesan.Location = new Point(171, 173);
            lblNamaPemesan.Name = "lblNamaPemesan";
            lblNamaPemesan.Size = new Size(50, 20);
            lblNamaPemesan.TabIndex = 4;
            lblNamaPemesan.Text = "label2";
            // 
            // lblTarif
            // 
            lblTarif.AutoSize = true;
            lblTarif.Location = new Point(171, 138);
            lblTarif.Name = "lblTarif";
            lblTarif.Size = new Size(50, 20);
            lblTarif.TabIndex = 3;
            lblTarif.Text = "label5";
            // 
            // lblJam
            // 
            lblJam.AutoSize = true;
            lblJam.Location = new Point(171, 105);
            lblJam.Name = "lblJam";
            lblJam.Size = new Size(50, 20);
            lblJam.TabIndex = 2;
            lblJam.Text = "label4";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(171, 70);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(50, 20);
            lblTanggal.TabIndex = 1;
            lblTanggal.Text = "label3";
            // 
            // lblJenisLapangan
            // 
            lblJenisLapangan.AutoSize = true;
            lblJenisLapangan.Location = new Point(171, 36);
            lblJenisLapangan.Name = "lblJenisLapangan";
            lblJenisLapangan.Size = new Size(50, 20);
            lblJenisLapangan.TabIndex = 0;
            lblJenisLapangan.Text = "label2";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblAtasNama);
            groupBox2.Controls.Add(btnBayar);
            groupBox2.Controls.Add(lblNoRekening);
            groupBox2.Controls.Add(lblBank);
            groupBox2.Controls.Add(cmbMetodePembayaran);
            groupBox2.Location = new Point(127, 306);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(520, 187);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pilih Pembayaran";
            // 
            // lblAtasNama
            // 
            lblAtasNama.AutoSize = true;
            lblAtasNama.Location = new Point(18, 147);
            lblAtasNama.Name = "lblAtasNama";
            lblAtasNama.Size = new Size(50, 20);
            lblAtasNama.TabIndex = 4;
            lblAtasNama.Text = "label2";
            // 
            // btnBayar
            // 
            btnBayar.Location = new Point(420, 147);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(94, 29);
            btnBayar.TabIndex = 3;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = true;
            btnBayar.Click += btnBayar_Click;
            // 
            // lblNoRekening
            // 
            lblNoRekening.AutoSize = true;
            lblNoRekening.Location = new Point(18, 111);
            lblNoRekening.Name = "lblNoRekening";
            lblNoRekening.Size = new Size(50, 20);
            lblNoRekening.TabIndex = 2;
            lblNoRekening.Text = "label3";
            // 
            // lblBank
            // 
            lblBank.AutoSize = true;
            lblBank.Location = new Point(18, 73);
            lblBank.Name = "lblBank";
            lblBank.Size = new Size(50, 20);
            lblBank.TabIndex = 1;
            lblBank.Text = "label2";
            // 
            // cmbMetodePembayaran
            // 
            cmbMetodePembayaran.FormattingEnabled = true;
            cmbMetodePembayaran.Location = new Point(18, 26);
            cmbMetodePembayaran.Name = "cmbMetodePembayaran";
            cmbMetodePembayaran.Size = new Size(477, 28);
            cmbMetodePembayaran.TabIndex = 0;
            cmbMetodePembayaran.SelectedIndexChanged += cmbMetodePembayaran_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 212);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 11;
            label2.Text = "No HP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 173);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 10;
            label3.Text = "Nama Pemesan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 138);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 9;
            label4.Text = "Total Biaya";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 105);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 8;
            label5.Text = "Jam";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 70);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 7;
            label6.Text = "Tanggal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 36);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 6;
            label7.Text = "Lapangan";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(153, 212);
            label8.Name = "label8";
            label8.Size = new Size(12, 20);
            label8.TabIndex = 17;
            label8.Text = ":";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(153, 173);
            label9.Name = "label9";
            label9.Size = new Size(12, 20);
            label9.TabIndex = 16;
            label9.Text = ":";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(153, 138);
            label10.Name = "label10";
            label10.Size = new Size(12, 20);
            label10.TabIndex = 15;
            label10.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(153, 105);
            label11.Name = "label11";
            label11.Size = new Size(12, 20);
            label11.TabIndex = 14;
            label11.Text = ":";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(153, 70);
            label12.Name = "label12";
            label12.Size = new Size(12, 20);
            label12.TabIndex = 13;
            label12.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(153, 36);
            label13.Name = "label13";
            label13.Size = new Size(12, 20);
            label13.TabIndex = 12;
            label13.Text = ":";
            // 
            // PembayaranDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 505);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel1);
            Name = "PembayaranDetailForm";
            Text = "PembayaranDetailForm";
            Load += PembayaranDetailForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btnback;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblTarif;
        private Label lblJam;
        private Label lblTanggal;
        private Label lblJenisLapangan;
        private GroupBox groupBox2;
        private Label lblNoHPPemesan;
        private Label lblNamaPemesan;
        private Button btnBayar;
        private Label lblNoRekening;
        private Label lblBank;
        private ComboBox cmbMetodePembayaran;
        private Label lblAtasNama;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}