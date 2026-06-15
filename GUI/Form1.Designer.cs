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
            cmbMenu = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            gbDetail = new GroupBox();
            gbStatus = new GroupBox();
            label3 = new Label();
            numJumlah = new NumericUpDown();
            btnPesan = new Button();
            lblNama = new Label();
            lblMenu = new Label();
            lblHarga = new Label();
            lblJumlah = new Label();
            lblTotal = new Label();
            lblStatus = new Label();
            gbInput.SuspendLayout();
            gbDetail.SuspendLayout();
            gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).BeginInit();
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
            gbInput.Controls.Add(numJumlah);
            gbInput.Controls.Add(label3);
            gbInput.Controls.Add(cmbMenu);
            gbInput.Controls.Add(label2);
            gbInput.Controls.Add(textBox1);
            gbInput.Controls.Add(label1);
            gbInput.Location = new Point(27, 115);
            gbInput.Name = "gbInput";
            gbInput.Size = new Size(416, 386);
            gbInput.TabIndex = 1;
            gbInput.TabStop = false;
            gbInput.Text = "1. Input Pemesanan";
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
            // textBox1
            // 
            textBox1.Location = new Point(6, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 27);
            textBox1.TabIndex = 3;
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
            gbDetail.Controls.Add(lblTotal);
            gbDetail.Controls.Add(lblJumlah);
            gbDetail.Controls.Add(lblHarga);
            gbDetail.Controls.Add(lblMenu);
            gbDetail.Controls.Add(lblNama);
            gbDetail.Location = new Point(482, 115);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(531, 386);
            gbDetail.TabIndex = 2;
            gbDetail.TabStop = false;
            gbDetail.Text = "2. Detail Pemesanan";
            // 
            // gbStatus
            // 
            gbStatus.BackColor = Color.MediumPurple;
            gbStatus.Controls.Add(lblStatus);
            gbStatus.Location = new Point(1045, 115);
            gbStatus.Name = "gbStatus";
            gbStatus.Size = new Size(416, 386);
            gbStatus.TabIndex = 2;
            gbStatus.TabStop = false;
            gbStatus.Text = "3. Status Pemesanan";
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
            // numJumlah
            // 
            numJumlah.Location = new Point(7, 244);
            numJumlah.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numJumlah.Name = "numJumlah";
            numJumlah.Size = new Size(403, 27);
            numJumlah.TabIndex = 3;
            numJumlah.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(6, 41);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(145, 20);
            lblNama.TabIndex = 7;
            lblNama.Text = "Nama Pelanggan     :";
            lblNama.Click += label4_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Location = new Point(6, 95);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(217, 20);
            lblMenu.TabIndex = 8;
            lblMenu.Text = "Menu Makanan Yang Dipilih     :";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(6, 154);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(122, 20);
            lblHarga.TabIndex = 9;
            lblHarga.Text = "Harga Satuan     :\r\n";
            lblHarga.Click += lblHarga_Click;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Location = new Point(6, 218);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(135, 20);
            lblJumlah.TabIndex = 10;
            lblJumlah.Text = "Jumlah Pesanan     :";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(6, 282);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(110, 20);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total Harga     :";
            lblTotal.Click += lblTotal_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1482, 853);
            Controls.Add(gbStatus);
            Controls.Add(gbDetail);
            Controls.Add(gbInput);
            Controls.Add(lblJudul);
            Name = "Form1";
            Text = "Form1";
            Load += txtNamaPelanggan_Load;
            gbInput.ResumeLayout(false);
            gbInput.PerformLayout();
            gbDetail.ResumeLayout(false);
            gbDetail.PerformLayout();
            gbStatus.ResumeLayout(false);
            gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private GroupBox gbInput;
        private GroupBox gbDetail;
        private GroupBox gbStatus;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox cmbMenu;
        private NumericUpDown numJumlah;
        private Label label3;
        private Button btnPesan;
        private Label lblNama;
        private Label lblTotal;
        private Label lblJumlah;
        private Label lblHarga;
        private Label lblMenu;
        private Label lblStatus;
    }
}
