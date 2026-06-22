namespace TUBES_GUI
{
    partial class FormMenu
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
            dgvMenu = new DataGridView();
            txtNamaProduk = new TextBox();
            txtHargaAsli = new TextBox();
            txtHargaSurplus = new TextBox();
            txtStok = new TextBox();
            cmbKategori = new ComboBox();
            btnTambah = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnEdit = new Button();
            btnHapus = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            SuspendLayout();
            // 
            // dgvMenu
            // 
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.AllowUserToDeleteRows = false;
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Location = new Point(49, 12);
            dgvMenu.Name = "dgvMenu";
            dgvMenu.ReadOnly = true;
            dgvMenu.RowHeadersWidth = 51;
            dgvMenu.Size = new Size(701, 188);
            dgvMenu.TabIndex = 0;
            dgvMenu.CellClick += dgvMenu_CellClick;
            // 
            // txtNamaProduk
            // 
            txtNamaProduk.Location = new Point(49, 236);
            txtNamaProduk.Name = "txtNamaProduk";
            txtNamaProduk.Size = new Size(125, 27);
            txtNamaProduk.TabIndex = 1;
            // 
            // txtHargaAsli
            // 
            txtHargaAsli.Location = new Point(196, 236);
            txtHargaAsli.Name = "txtHargaAsli";
            txtHargaAsli.Size = new Size(125, 27);
            txtHargaAsli.TabIndex = 2;
            // 
            // txtHargaSurplus
            // 
            txtHargaSurplus.Location = new Point(338, 236);
            txtHargaSurplus.Name = "txtHargaSurplus";
            txtHargaSurplus.Size = new Size(125, 27);
            txtHargaSurplus.TabIndex = 3;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(483, 236);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(125, 27);
            txtStok.TabIndex = 4;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(625, 236);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(151, 28);
            cmbKategori.TabIndex = 5;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(82, 309);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(155, 29);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Submit";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 213);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 7;
            label1.Text = "Nama Produk";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 213);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 8;
            label2.Text = "Harga Asli";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 213);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 9;
            label3.Text = "Harga Surplus";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(483, 216);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 10;
            label4.Text = "Stok";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(625, 216);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 11;
            label5.Text = "Kategori";
            label5.Click += label5_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(321, 309);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(155, 29);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(561, 309);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(155, 29);
            btnHapus.TabIndex = 13;
            btnHapus.Text = "Delete";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTambah);
            Controls.Add(cmbKategori);
            Controls.Add(txtStok);
            Controls.Add(txtHargaSurplus);
            Controls.Add(txtHargaAsli);
            Controls.Add(txtNamaProduk);
            Controls.Add(dgvMenu);
            Name = "FormMenu";
            Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMenu;
        private TextBox txtNamaProduk;
        private TextBox txtHargaAsli;
        private TextBox txtHargaSurplus;
        private TextBox txtStok;
        private ComboBox cmbKategori;
        private Button btnTambah;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnEdit;
        private Button btnHapus;
    }
}