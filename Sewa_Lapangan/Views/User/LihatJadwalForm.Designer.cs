namespace Sewa_Lapangan.Views.User
{
    partial class LihatJadwalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatJadwalForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnback = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            btnCari = new Button();
            cmbJenisLapangan = new ComboBox();
            dtpTanggal = new DateTimePicker();
            dgvJadwal = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).BeginInit();
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
            flowLayoutPanel1.Size = new Size(982, 44);
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
            label1.Size = new Size(147, 43);
            label1.TabIndex = 1;
            label1.Text = "Lihat Jadwal";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCari);
            groupBox1.Controls.Add(cmbJenisLapangan);
            groupBox1.Controls.Add(dtpTanggal);
            groupBox1.Location = new Point(208, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(576, 196);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cari Jadwal";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 109);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 4;
            label3.Text = "Pilih Tanggal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 40);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 3;
            label2.Text = "Pilih Jenis Lapangan";
            // 
            // btnCari
            // 
            btnCari.Location = new Point(246, 157);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(94, 29);
            btnCari.TabIndex = 2;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // cmbJenisLapangan
            // 
            cmbJenisLapangan.FormattingEnabled = true;
            cmbJenisLapangan.Location = new Point(229, 40);
            cmbJenisLapangan.Name = "cmbJenisLapangan";
            cmbJenisLapangan.Size = new Size(250, 28);
            cmbJenisLapangan.TabIndex = 1;
            cmbJenisLapangan.SelectedIndexChanged += cmbJenisLapangan_SelectedIndexChanged;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(229, 103);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(250, 27);
            dtpTanggal.TabIndex = 0;
            dtpTanggal.ValueChanged += dtpTanggal_ValueChanged;
            // 
            // dgvJadwal
            // 
            dgvJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwal.Location = new Point(182, 326);
            dgvJadwal.Name = "dgvJadwal";
            dgvJadwal.RowHeadersWidth = 51;
            dgvJadwal.Size = new Size(627, 248);
            dgvJadwal.TabIndex = 4;
            dgvJadwal.CellContentClick += dgvJadwal_CellContentClick;
            // 
            // LihatJadwalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 633);
            Controls.Add(dgvJadwal);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel1);
            Name = "LihatJadwalForm";
            Text = "LihatJadwalForm";
            Load += LihatJadwalForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btnback;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cmbJenisLapangan;
        private DateTimePicker dtpTanggal;
        private DataGridView dgvJadwal;
        private Label label3;
        private Label label2;
        private Button btnCari;
    }
}