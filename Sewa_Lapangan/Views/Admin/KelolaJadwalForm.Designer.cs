namespace Sewa_Lapangan.Views.Admin
{
    partial class KelolaJadwalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaJadwalForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnback = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtTarif = new TextBox();
            numDurasi = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSimpan = new Button();
            txtJamMulai = new TextBox();
            dtpTanggal = new DateTimePicker();
            cmbNamaLapangan = new ComboBox();
            cmbJenisLapangan = new ComboBox();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            btnUpdate = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDurasi).BeginInit();
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
            flowLayoutPanel1.Size = new Size(800, 44);
            flowLayoutPanel1.TabIndex = 0;
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
            label1.Size = new Size(160, 43);
            label1.TabIndex = 1;
            label1.Text = "Kelola Jadwal";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTarif);
            groupBox1.Controls.Add(numDurasi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSimpan);
            groupBox1.Controls.Add(txtJamMulai);
            groupBox1.Controls.Add(dtpTanggal);
            groupBox1.Controls.Add(cmbNamaLapangan);
            groupBox1.Controls.Add(cmbJenisLapangan);
            groupBox1.Location = new Point(76, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(678, 357);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tambah Jadwal";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 326);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 14;
            label7.Text = "Set Tarif";
            label7.Click += label7_Click;
            // 
            // txtTarif
            // 
            txtTarif.Location = new Point(170, 322);
            txtTarif.Name = "txtTarif";
            txtTarif.Size = new Size(335, 27);
            txtTarif.TabIndex = 13;
            txtTarif.TextChanged += txtTarif_TextChanged;
            // 
            // numDurasi
            // 
            numDurasi.Location = new Point(173, 263);
            numDurasi.Name = "numDurasi";
            numDurasi.Size = new Size(332, 27);
            numDurasi.TabIndex = 12;
            numDurasi.ValueChanged += numDurasi_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 265);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 11;
            label6.Text = "Set Durasi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 210);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 10;
            label5.Text = "Set Jam Mulai";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 156);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 9;
            label4.Text = "Set Tanggal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 101);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 8;
            label3.Text = "Pilih Lapangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 39);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 7;
            label2.Text = "Pilih Jenis Lapamgan";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(563, 322);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtJamMulai
            // 
            txtJamMulai.Location = new Point(170, 203);
            txtJamMulai.Name = "txtJamMulai";
            txtJamMulai.Size = new Size(335, 27);
            txtJamMulai.TabIndex = 5;
            txtJamMulai.TextChanged += txtJamMulai_TextChanged;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(170, 151);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(332, 27);
            dtpTanggal.TabIndex = 2;
            dtpTanggal.ValueChanged += dtpTanggal_ValueChanged;
            // 
            // cmbNamaLapangan
            // 
            cmbNamaLapangan.FormattingEnabled = true;
            cmbNamaLapangan.Location = new Point(170, 93);
            cmbNamaLapangan.Name = "cmbNamaLapangan";
            cmbNamaLapangan.Size = new Size(332, 28);
            cmbNamaLapangan.TabIndex = 1;
            cmbNamaLapangan.SelectedIndexChanged += cmbNamaLapangan_SelectedIndexChanged;
            // 
            // cmbJenisLapangan
            // 
            cmbJenisLapangan.FormattingEnabled = true;
            cmbJenisLapangan.Location = new Point(170, 36);
            cmbJenisLapangan.Name = "cmbJenisLapangan";
            cmbJenisLapangan.Size = new Size(332, 28);
            cmbJenisLapangan.TabIndex = 0;
            cmbJenisLapangan.SelectedIndexChanged += cmbJenisLapangan_SelectedIndexChanged;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(327, 413);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(148, 29);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update Jadwal";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // KelolaJadwalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "KelolaJadwalForm";
            Text = "KelolaJadwalForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDurasi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btnback;
        private Label label1;
        private GroupBox groupBox1;
        private DateTimePicker dtpTanggal;
        private ComboBox cmbNamaLapangan;
        private ComboBox cmbJenisLapangan;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private Button btnSimpan;
        private TextBox txtJamMulai;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private NumericUpDown numDurasi;
        private Label label7;
        private TextBox txtTarif;
        private Button btnUpdate;
    }
}