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
            No_Hp = new Label();
            label2 = new Label();
            txtNoHP = new TextBox();
            txtNamaPemesan = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnback = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblJam);
            groupBox1.Controls.Add(lblTarif);
            groupBox1.Controls.Add(lblTanggal);
            groupBox1.Controls.Add(lblJenisLapangan);
            groupBox1.Location = new Point(196, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 156);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail Jadwal";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblJam
            // 
            lblJam.AutoSize = true;
            lblJam.Location = new Point(163, 91);
            lblJam.Name = "lblJam";
            lblJam.Size = new Size(13, 20);
            lblJam.TabIndex = 4;
            lblJam.Text = " ";
            lblJam.Click += lblJam_Click;
            // 
            // lblTarif
            // 
            lblTarif.AutoSize = true;
            lblTarif.Location = new Point(163, 125);
            lblTarif.Name = "lblTarif";
            lblTarif.Size = new Size(13, 20);
            lblTarif.TabIndex = 3;
            lblTarif.Text = " ";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(163, 56);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(13, 20);
            lblTanggal.TabIndex = 1;
            lblTanggal.Text = " ";
            lblTanggal.Click += lblTanggal_Click;
            // 
            // lblJenisLapangan
            // 
            lblJenisLapangan.AutoSize = true;
            lblJenisLapangan.Location = new Point(163, 24);
            lblJenisLapangan.Name = "lblJenisLapangan";
            lblJenisLapangan.Size = new Size(13, 20);
            lblJenisLapangan.TabIndex = 0;
            lblJenisLapangan.Text = " ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSimpan);
            groupBox2.Controls.Add(No_Hp);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNoHP);
            groupBox2.Controls.Add(txtNamaPemesan);
            groupBox2.Location = new Point(196, 249);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(395, 189);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data pemesan";
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
            // No_Hp
            // 
            No_Hp.AutoSize = true;
            No_Hp.Location = new Point(31, 110);
            No_Hp.Name = "No_Hp";
            No_Hp.Size = new Size(53, 20);
            No_Hp.TabIndex = 3;
            No_Hp.Text = "No Hp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 40);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 2;
            label2.Text = "Nama Pemesan";
            // 
            // txtNoHP
            // 
            txtNoHP.Location = new Point(149, 110);
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(220, 27);
            txtNoHP.TabIndex = 1;
            txtNoHP.TextChanged += txtNoHP_TextChanged;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 24);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 5;
            label3.Text = "Lapangan  : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 91);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 6;
            label4.Text = "Jam            :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 125);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 7;
            label5.Text = "Harga        :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 56);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 8;
            label6.Text = "Tanggal     :";
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
        private Label No_Hp;
        private Label label2;
        private TextBox txtNoHP;
        private TextBox txtNamaPemesan;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btnback;
        private Label label1;
        private Button btnSimpan;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
    }
}