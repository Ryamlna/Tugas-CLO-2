using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TUBES_GUI.Models;
using TUBES_GUI.Services;

namespace TUBES_GUI
{
    public partial class FormMenu : Form
    {
        private Serv menuService;
        public FormMenu()
        {
            InitializeComponent();
            menuService = Serv.GetInstance();
            SetupDataGridView();
            IsiKategoriCombo();
            RefreshTabel();
        }

        private string selectedFoodId = "";

        private void SetupDataGridView()
        {
            dgvMenu.ColumnCount = 6;
            dgvMenu.Columns[0].Name = "Nama Produk";
            dgvMenu.Columns[1].Name = "Kategori";
            dgvMenu.Columns[2].Name = "Stok";
            dgvMenu.Columns[3].Name = "Harga Asli";
            dgvMenu.Columns[4].Name = "Harga Surplus";
            dgvMenu.Columns[5].Name = "FoodId";
            dgvMenu.Columns[5].Visible = false;

            dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void IsiKategoriCombo()
        {
            cmbKategori.Items.Clear();
            cmbKategori.Items.Add("Makanan Berat");
            cmbKategori.Items.Add("Roti & Kue");
            cmbKategori.Items.Add("Minuman");
            cmbKategori.SelectedIndex = 0;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Model itemBaru = new Model
                {
                    NamaProduk = txtNamaProduk.Text,
                    Kategori = cmbKategori.SelectedItem.ToString(),
                    HargaAsli = Convert.ToDouble(txtHargaAsli.Text),
                    HargaSurplus = Convert.ToDouble(txtHargaSurplus.Text),
                    Stok = Convert.ToInt32(txtStok.Text)
                };

                menuService.TambahMenu(itemBaru);

                MessageBox.Show($"[BERHASIL] '{itemBaru.NamaProduk}' berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshTabel();
                BersihkanInput();
            }
            catch (FormatException)
            {
                MessageBox.Show("[GAGAL] Input angka tidak valid! Pastikan harga dan stok diisi dengan angka.", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[GAGAL] Error: {ex.Message}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void RefreshTabel()
        {
            dgvMenu.Rows.Clear();
            var semuaMenu = menuService.LihatSemuaMenu();

            foreach (var item in semuaMenu)
            {
                dgvMenu.Rows.Add(
                    item.NamaProduk,
                    item.Kategori,
                    item.Stok,
                    $"Rp {item.HargaAsli}",
                    $"Rp {item.HargaSurplus}",
                    item.FoodId
                );
            }
        }
        private void BersihkanInput()
        {
            txtNamaProduk.Clear();
            txtHargaAsli.Clear();
            txtHargaSurplus.Clear();
            txtStok.Clear();
            cmbKategori.SelectedIndex = 0;

            txtNamaProduk.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMenu.Rows[e.RowIndex];

                txtNamaProduk.Text = row.Cells[0].Value.ToString();
                cmbKategori.SelectedItem = row.Cells[1].Value.ToString();
                txtStok.Text = row.Cells[2].Value.ToString();

                txtHargaAsli.Text = row.Cells[3].Value.ToString().Replace("Rp ", "");
                txtHargaSurplus.Text = row.Cells[4].Value.ToString().Replace("Rp ", "");

                selectedFoodId = row.Cells[5].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFoodId))
            {
                MessageBox.Show("Pilih data di tabel dulu yang mau diedit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Model dataUpdate = new Model
                {
                    NamaProduk = txtNamaProduk.Text,
                    Kategori = cmbKategori.SelectedItem.ToString(),
                    HargaAsli = Convert.ToDouble(txtHargaAsli.Text),
                    HargaSurplus = Convert.ToDouble(txtHargaSurplus.Text),
                    Stok = Convert.ToInt32(txtStok.Text)
                };

                menuService.UpdateMenu(selectedFoodId, dataUpdate);
                MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshTabel();
                BersihkanInput();
                selectedFoodId = ""; // Reset ID
            }
            catch (FormatException)
            {
                MessageBox.Show("[GAGAL] Input angka tidak valid!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[GAGAL] Error: {ex.Message}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFoodId))
            {
                MessageBox.Show("Pilih data di tabel dulu yang mau dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Yakin mau hapus menu ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                menuService.HapusMenu(selectedFoodId);
                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshTabel();
                BersihkanInput();
                selectedFoodId = "";  
            }
        }
    }
}
