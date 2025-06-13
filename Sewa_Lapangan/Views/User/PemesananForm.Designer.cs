namespace Sewa_Lapangan.Views.User
{
    partial class PemesananForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PemesananForm));
            groupBox1 = new GroupBox();
            lblJam = new Label();
            lblTarif = new Label();
            lblTanggal = new Label();
            lblJenisLapangan = new Label();
            groupBox2 = new GroupBox();
            btnSimpan = new Button();
            label3 = new Label();
            label2 = new Label();
            txtNoHP = new TextBox();
            txtNamaPemesan = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnback = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblJam);
            groupBox1.Controls.Add(lblTarif);
            groupBox1.Controls.Add(lblTanggal);
            groupBox1.Controls.Add(lblJenisLapangan);
            groupBox1.Location = new Point(196, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 156);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lblJam
            // 
            lblJam.AutoSize = true;
            lblJam.Location = new Point(20, 89);
            lblJam.Name = "lblJam";
            lblJam.Size = new Size(50, 20);
            lblJam.TabIndex = 4;
            lblJam.Text = "label3";
            // 
            // lblTarif
            // 
            lblTarif.AutoSize = true;
            lblTarif.Location = new Point(20, 120);
            lblTarif.Name = "lblTarif";
            lblTarif.Size = new Size(50, 20);
            lblTarif.TabIndex = 3;
            lblTarif.Text = "label4";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(20, 55);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(50, 20);
            lblTanggal.TabIndex = 1;
            lblTanggal.Text = "label2";
            // 
            // lblJenisLapangan
            // 
            lblJenisLapangan.AutoSize = true;
            lblJenisLapangan.Location = new Point(20, 24);
            lblJenisLapangan.Name = "lblJenisLapangan";
            lblJenisLapangan.Size = new Size(50, 20);
            lblJenisLapangan.TabIndex = 0;
            lblJenisLapangan.Text = "label1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSimpan);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNoHP);
            groupBox2.Controls.Add(txtNamaPemesan);
            groupBox2.Location = new Point(196, 249);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(395, 189);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(169, 155);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 4;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 110);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 40);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // txtNoHP
            // 
            txtNoHP.Location = new Point(149, 110);
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(220, 27);
            txtNoHP.TabIndex = 1;
            // 
            // txtNamaPemesan
            // 
            txtNamaPemesan.Location = new Point(149, 37);
            txtNamaPemesan.Name = "txtNamaPemesan";
            txtNamaPemesan.Size = new Size(220, 27);
            txtNamaPemesan.TabIndex = 0;
            txtNamaPemesan.TextChanged += txtNamaPemesan_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(35, 40, 45);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 44);
            flowLayoutPanel1.TabIndex = 3;
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
            label1.Size = new Size(134, 43);
            label1.TabIndex = 1;
            label1.Text = "Pemesanan";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PemesananForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PemesananForm";
            Text = "PemesananForm";
            Load += PemesananForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblTarif;
        private Label lblTanggal;
        private Label lblJenisLapangan;
        private Label lblJam;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private TextBox txtNoHP;
        private TextBox txtNamaPemesan;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btnback;
        private Label label1;
        private Button btnSimpan;
    }
}