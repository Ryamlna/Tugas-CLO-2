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
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblTotalDetail = new Label();
            lblJumlahDetail = new Label();
            lblHargaDetail = new Label();
            lblMenuDetail = new Label();
            lblNamaDetail = new Label();
            gbStatus = new GroupBox();
            label14 = new Label();
            lblStatus = new Label();
            gbInfoMenu = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            lblStok = new Label();
            lblHargaMenu = new Label();
            lblMenuTersedia = new Label();
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
            btnPesan.Click += btnPesan_Click;
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
            cmbMenu.Click += Form1_Load;
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
            gbDetail.Controls.Add(label10);
            gbDetail.Controls.Add(label9);
            gbDetail.Controls.Add(label6);
            gbDetail.Controls.Add(label5);
            gbDetail.Controls.Add(label4);
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 282);
            label10.Name = "label10";
            label10.Size = new Size(110, 20);
            label10.TabIndex = 16;
            label10.Text = "Total Harga     :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 218);
            label9.Name = "label9";
            label9.Size = new Size(135, 20);
            label9.TabIndex = 15;
            label9.Text = "Jumlah Pesanan     :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 154);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 14;
            label6.Text = "Harga Satuan     :\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 95);
            label5.Name = "label5";
            label5.Size = new Size(217, 20);
            label5.TabIndex = 13;
            label5.Text = "Menu Makanan Yang Dipilih     :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 41);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 12;
            label4.Text = "Nama Pelanggan     :";
            label4.Click += label4_Click_2;
            // 
            // lblTotalDetail
            // 
            lblTotalDetail.AutoSize = true;
            lblTotalDetail.Font = new Font("Segoe UI", 13F);
            lblTotalDetail.Location = new Point(134, 277);
            lblTotalDetail.Name = "lblTotalDetail";
            lblTotalDetail.Size = new Size(22, 30);
            lblTotalDetail.TabIndex = 11;
            lblTotalDetail.Text = "-";
            lblTotalDetail.Click += lblTotal_Click;
            // 
            // lblJumlahDetail
            // 
            lblJumlahDetail.AutoSize = true;
            lblJumlahDetail.Location = new Point(152, 218);
            lblJumlahDetail.Name = "lblJumlahDetail";
            lblJumlahDetail.Size = new Size(15, 20);
            lblJumlahDetail.TabIndex = 10;
            lblJumlahDetail.Text = "-";
            // 
            // lblHargaDetail
            // 
            lblHargaDetail.AutoSize = true;
            lblHargaDetail.Location = new Point(134, 154);
            lblHargaDetail.Name = "lblHargaDetail";
            lblHargaDetail.Size = new Size(15, 20);
            lblHargaDetail.TabIndex = 9;
            lblHargaDetail.Text = "-";
            lblHargaDetail.Click += lblHarga_Click;
            // 
            // lblMenuDetail
            // 
            lblMenuDetail.AutoSize = true;
            lblMenuDetail.Location = new Point(235, 95);
            lblMenuDetail.Name = "lblMenuDetail";
            lblMenuDetail.Size = new Size(15, 20);
            lblMenuDetail.TabIndex = 8;
            lblMenuDetail.Text = "-";
            // 
            // lblNamaDetail
            // 
            lblNamaDetail.AutoSize = true;
            lblNamaDetail.Location = new Point(161, 41);
            lblNamaDetail.Name = "lblNamaDetail";
            lblNamaDetail.Size = new Size(15, 20);
            lblNamaDetail.TabIndex = 7;
            lblNamaDetail.Text = "-";
            lblNamaDetail.Click += label4_Click;
            // 
            // gbStatus
            // 
            gbStatus.BackColor = Color.MediumPurple;
            gbStatus.Controls.Add(label14);
            gbStatus.Controls.Add(lblStatus);
            gbStatus.Location = new Point(1045, 115);
            gbStatus.Name = "gbStatus";
            gbStatus.Size = new Size(416, 386);
            gbStatus.TabIndex = 2;
            gbStatus.TabStop = false;
            gbStatus.Text = "3. Status Pemesanan";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 41);
            label14.Name = "label14";
            label14.Size = new Size(102, 20);
            label14.TabIndex = 14;
            label14.Text = "Status Saat Ini";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 20F);
            lblStatus.ForeColor = Color.Yellow;
            lblStatus.Location = new Point(6, 82);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(34, 46);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "-";
            // 
            // gbInfoMenu
            // 
            gbInfoMenu.BackColor = Color.MistyRose;
            gbInfoMenu.Controls.Add(label13);
            gbInfoMenu.Controls.Add(label12);
            gbInfoMenu.Controls.Add(label11);
            gbInfoMenu.Controls.Add(lblStok);
            gbInfoMenu.Controls.Add(lblHargaMenu);
            gbInfoMenu.Controls.Add(lblMenuTersedia);
            gbInfoMenu.Location = new Point(27, 551);
            gbInfoMenu.Name = "gbInfoMenu";
            gbInfoMenu.Size = new Size(416, 177);
            gbInfoMenu.TabIndex = 3;
            gbInfoMenu.TabStop = false;
            gbInfoMenu.Text = "Informasi Menu";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 135);
            label13.Name = "label13";
            label13.Size = new Size(163, 20);
            label13.TabIndex = 12;
            label13.Text = "Stock Yang Tersedia     :";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 90);
            label12.Name = "label12";
            label12.Size = new Size(140, 20);
            label12.TabIndex = 11;
            label12.Text = "Harga per menu     :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 45);
            label11.Name = "label11";
            label11.Size = new Size(164, 20);
            label11.TabIndex = 10;
            label11.Text = "Menu Yang Teresdia     :";
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Location = new Point(176, 135);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(15, 20);
            lblStok.TabIndex = 9;
            lblStok.Text = "-";
            lblStok.Click += label6_Click;
            // 
            // lblHargaMenu
            // 
            lblHargaMenu.AutoSize = true;
            lblHargaMenu.Location = new Point(150, 90);
            lblHargaMenu.Name = "lblHargaMenu";
            lblHargaMenu.Size = new Size(15, 20);
            lblHargaMenu.TabIndex = 8;
            lblHargaMenu.Text = "-";
            lblHargaMenu.Click += label5_Click;
            // 
            // lblMenuTersedia
            // 
            lblMenuTersedia.AutoSize = true;
            lblMenuTersedia.Location = new Point(173, 45);
            lblMenuTersedia.Name = "lblMenuTersedia";
            lblMenuTersedia.Size = new Size(15, 20);
            lblMenuTersedia.TabIndex = 7;
            lblMenuTersedia.Text = "-";
            lblMenuTersedia.Click += label4_Click_1;
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
            btnBayar.Click += btnBayar_Click_1;
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
            btnReset.Click += btnReset_Click_1;
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
            Load += Form1_Load;
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
        private GroupBox gbInfoMenu;
        private Label lblStok;
        private Label lblHargaMenu;
        private Label lblMenuTersedia;
        private GroupBox gbProses;
        private Button btnBayar;
        private Label label7;
        private Button btnReset;
        private Label label8;
        private Button btnBatalkan;
        private Label label4;
        private Label label10;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label14;
    }
}
