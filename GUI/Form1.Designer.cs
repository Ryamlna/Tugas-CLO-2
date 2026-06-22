namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblJudul = new Label();
            gbInput = new GroupBox();
            btnPesan = new Button();
            numJumlahPesanan = new NumericUpDown();
            label3 = new Label();
            cmbMenu = new ComboBox();
            label2 = new Label();
            txtNamaPelanggan = new TextBox();
            label1 = new Label();
            gbDetail = new GroupBox();
            lblTotalDetail = new Label();
            lblJumlahDetail = new Label();
            lblHargaDetail = new Label();
            lblMenuDetail = new Label();
            lblNamaDetail = new Label();
            gbStatus = new GroupBox();
            rtbRiwayat = new RichTextBox();
            lblStatus = new Label();
            gbInfoMenu = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            gbProses = new GroupBox();
            btnBatalkan = new Button();
            label7 = new Label();
            btnBayar = new Button();
            btnReset = new Button();
            label8 = new Label();
            gbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlahPesanan).BeginInit();
            gbDetail.SuspendLayout();
            gbStatus.SuspendLayout();
            gbInfoMenu.SuspendLayout();
            gbProses.SuspendLayout();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Microsoft Sans Serif", 30F);
            lblJudul.ForeColor = Color.SpringGreen;
            lblJudul.Location = new Point(591, 22);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(289, 58);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "GOODBITE";
            lblJudul.Click += label1_Click;
            // 
            // gbInput
            // 
            gbInput.BackColor = Color.LightSkyBlue;
            gbInput.Controls.Add(btnPesan);
            gbInput.Controls.Add(numJumlahPesanan);
            gbInput.Controls.Add(label3);
            gbInput.Controls.Add(cmbMenu);
            gbInput.Controls.Add(label2);
            gbInput.Controls.Add(txtNamaPelanggan);
            gbInput.Controls.Add(label1);
            gbInput.Location = new Point(27, 115);
            gbInput.Name = "gbInput";
            gbInput.Size = new Size(416, 386);
            gbInput.TabIndex = 1;
            gbInput.TabStop = false;
            gbInput.Text = "1. Input Pemesanan";
            // 
            // btnPesan
            // 
            btnPesan.BackColor = Color.SpringGreen;
            btnPesan.ForeColor = SystemColors.ActiveCaptionText;
            btnPesan.Location = new Point(122, 325);
            btnPesan.Name = "btnPesan";
            btnPesan.Size = new Size(177, 46);
            btnPesan.TabIndex = 3;
            btnPesan.Text = "Pesan Makanan";
            btnPesan.UseVisualStyleBackColor = false;
            // 
            // numJumlahPesanan
            // 
            numJumlahPesanan.Location = new Point(7, 244);
            numJumlahPesanan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numJumlahPesanan.Name = "numJumlahPesanan";
            numJumlahPesanan.Size = new Size(403, 27);
            numJumlahPesanan.TabIndex = 3;
            numJumlahPesanan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 208);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 6;
            label3.Text = "Jumlah Pesanan";
            // 
            // cmbMenu
            // 
            cmbMenu.FormattingEnabled = true;
            cmbMenu.Location = new Point(6, 154);
            cmbMenu.Name = "cmbMenu";
            cmbMenu.Size = new Size(151, 28);
            cmbMenu.TabIndex = 5;
            cmbMenu.Text = "Pilih Makanan";
            cmbMenu.SelectedIndexChanged += cmbMenu_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 121);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 4;
            label2.Text = "Menu Makanan";
            label2.Click += label2_Click;
            // 
            // txtNamaPelanggan
            // 
            txtNamaPelanggan.Location = new Point(6, 75);
            txtNamaPelanggan.Name = "txtNamaPelanggan";
            txtNamaPelanggan.Size = new Size(404, 27);
            txtNamaPelanggan.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 41);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 3;
            label1.Text = "Nama Pelanggan";
            // 
            // gbDetail
            // 
            gbDetail.BackColor = Color.SpringGreen;
            gbDetail.Controls.Add(lblTotalDetail);
            gbDetail.Controls.Add(lblJumlahDetail);
            gbDetail.Controls.Add(lblHargaDetail);
            gbDetail.Controls.Add(lblMenuDetail);
            gbDetail.Controls.Add(lblNamaDetail);
            gbDetail.Location = new Point(482, 115);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(531, 386);
            gbDetail.TabIndex = 2;
            gbDetail.TabStop = false;
            gbDetail.Text = "2. Detail Pemesanan";
            // 
            // lblTotalDetail
            // 
            lblTotalDetail.AutoSize = true;
            lblTotalDetail.Location = new Point(6, 282);
            lblTotalDetail.Name = "lblTotalDetail";
            lblTotalDetail.Size = new Size(110, 20);
            lblTotalDetail.TabIndex = 11;
            lblTotalDetail.Text = "Total Harga     :";
            lblTotalDetail.Click += lblTotal_Click;
            // 
            // lblJumlahDetail
            // 
            lblJumlahDetail.AutoSize = true;
            lblJumlahDetail.Location = new Point(6, 218);
            lblJumlahDetail.Name = "lblJumlahDetail";
            lblJumlahDetail.Size = new Size(135, 20);
            lblJumlahDetail.TabIndex = 10;
            lblJumlahDetail.Text = "Jumlah Pesanan     :";
            // 
            // lblHargaDetail
            // 
            lblHargaDetail.AutoSize = true;
            lblHargaDetail.Location = new Point(6, 154);
            lblHargaDetail.Name = "lblHargaDetail";
            lblHargaDetail.Size = new Size(122, 20);
            lblHargaDetail.TabIndex = 9;
            lblHargaDetail.Text = "Harga Satuan     :\r\n";
            lblHargaDetail.Click += lblHarga_Click;
            // 
            // lblMenuDetail
            // 
            lblMenuDetail.AutoSize = true;
            lblMenuDetail.Location = new Point(6, 95);
            lblMenuDetail.Name = "lblMenuDetail";
            lblMenuDetail.Size = new Size(217, 20);
            lblMenuDetail.TabIndex = 8;
            lblMenuDetail.Text = "Menu Makanan Yang Dipilih     :";
            // 
            // lblNamaDetail
            // 
            lblNamaDetail.AutoSize = true;
            lblNamaDetail.Location = new Point(6, 41);
            lblNamaDetail.Name = "lblNamaDetail";
            lblNamaDetail.Size = new Size(145, 20);
            lblNamaDetail.TabIndex = 7;
            lblNamaDetail.Text = "Nama Pelanggan     :";
            lblNamaDetail.Click += label4_Click;
            // 
            // gbStatus
            // 
            gbStatus.BackColor = Color.MediumPurple;
            gbStatus.Controls.Add(rtbRiwayat);
            gbStatus.Controls.Add(lblStatus);
            gbStatus.Location = new Point(1045, 115);
            gbStatus.Name = "gbStatus";
            gbStatus.Size = new Size(416, 386);
            gbStatus.TabIndex = 2;
            gbStatus.TabStop = false;
            gbStatus.Text = "3. Status Pemesanan";
            // 
            // rtbRiwayat
            // 
            rtbRiwayat.Location = new Point(6, 75);
            rtbRiwayat.Name = "rtbRiwayat";
            rtbRiwayat.ReadOnly = true;
            rtbRiwayat.Size = new Size(251, 40);
            rtbRiwayat.TabIndex = 13;
            rtbRiwayat.Text = "";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(6, 41);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(102, 20);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status Saat Ini";
            // 
            // gbInfoMenu
            // 
            gbInfoMenu.BackColor = Color.MistyRose;
            gbInfoMenu.Controls.Add(label6);
            gbInfoMenu.Controls.Add(label5);
            gbInfoMenu.Controls.Add(label4);
            gbInfoMenu.Location = new Point(27, 551);
            gbInfoMenu.Name = "gbInfoMenu";
            gbInfoMenu.Size = new Size(416, 177);
            gbInfoMenu.TabIndex = 3;
            gbInfoMenu.TabStop = false;
            gbInfoMenu.Text = "Informasi Menu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 135);
            label6.Name = "label6";
            label6.Size = new Size(163, 20);
            label6.TabIndex = 9;
            label6.Text = "Stock Yang Tersedia     :";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 90);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 8;
            label5.Text = "Harga per menu     :";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 45);
            label4.Name = "label4";
            label4.Size = new Size(164, 20);
            label4.TabIndex = 7;
            label4.Text = "Menu Yang Teresdia     :";
            label4.Click += label4_Click_1;
            // 
            // gbProses
            // 
            gbProses.BackColor = Color.NavajoWhite;
            gbProses.Controls.Add(btnBatalkan);
            gbProses.Controls.Add(label7);
            gbProses.Controls.Add(btnBayar);
            gbProses.Location = new Point(482, 551);
            gbProses.Name = "gbProses";
            gbProses.Size = new Size(531, 177);
            gbProses.TabIndex = 4;
            gbProses.TabStop = false;
            gbProses.Text = "Pembayaran";
            gbProses.Enter += groupBox1_Enter;
            // 
            // btnBatalkan
            // 
            btnBatalkan.BackColor = Color.Red;
            btnBatalkan.Location = new Point(320, 59);
            btnBatalkan.Name = "btnBatalkan";
            btnBatalkan.Size = new Size(146, 51);
            btnBatalkan.TabIndex = 11;
            btnBatalkan.Text = "Batalkan Pesanan";
            btnBatalkan.UseVisualStyleBackColor = false;
            btnBatalkan.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 135);
            label7.Name = "label7";
            label7.Size = new Size(460, 20);
            label7.TabIndex = 10;
            label7.Text = "Lanjutkan Bayar / Batal Untuk Mengubah Status Pembayaran Saat Ini";
            label7.Click += label7_Click;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = Color.LightSkyBlue;
            btnBayar.Location = new Point(6, 59);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(146, 51);
            btnBayar.TabIndex = 5;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.Location = new Point(1051, 610);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(146, 51);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset Pemesanan";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1051, 686);
            label8.Name = "label8";
            label8.Size = new Size(393, 20);
            label8.TabIndex = 11;
            label8.Text = "Gunakan Tombol Ini Apabila Salah Menginputkan Pesanan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1482, 755);
            Controls.Add(label8);
            Controls.Add(btnReset);
            Controls.Add(gbProses);
            Controls.Add(gbInfoMenu);
            Controls.Add(gbStatus);
            Controls.Add(gbDetail);
            Controls.Add(gbInput);
            Controls.Add(lblJudul);
            Name = "Form1";
            Text = "Form1";
            Load += txtNamaPelanggan_Load;
            gbInput.ResumeLayout(false);
            gbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlahPesanan).EndInit();
            gbDetail.ResumeLayout(false);
            gbDetail.PerformLayout();
            gbStatus.ResumeLayout(false);
            gbStatus.PerformLayout();
            gbInfoMenu.ResumeLayout(false);
            gbInfoMenu.PerformLayout();
            gbProses.ResumeLayout(false);
            gbProses.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private GroupBox gbInput;
        private GroupBox gbDetail;
        private GroupBox gbStatus;
        private Label label1;
        private TextBox txtNamaPelanggan;
        private Label label2;
        private ComboBox cmbMenu;
        private NumericUpDown numJumlahPesanan;
        private Label label3;
        private Button btnPesan;
        private Label lblNamaDetail;
        private Label lblTotalDetail;
        private Label lblJumlahDetail;
        private Label lblHargaDetail;
        private Label lblMenuDetail;
        private Label lblStatus;
        private RichTextBox rtbRiwayat;
        private GroupBox gbInfoMenu;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox gbProses;
        private Button btnBayar;
        private Label label7;
        private Button btnReset;
        private Label label8;
        private Button btnBatalkan;
    }
}
