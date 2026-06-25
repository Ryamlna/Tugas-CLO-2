using TugasCLO2Libraries;

namespace GUI
{
    public partial class Form1 : Form
    {
        private MenuMakanan menu1;
        private Pesanan pesanan1;
        private bool pesananAktif = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMenu.Items.Clear();

            menu1 = new MenuMakanan
            {
                NamaMakanan = "Nasi Goreng",
                Harga = 15000,
                Stok = 10
            };

            cmbMenu.Items.Add("Nasi Goreng");
            cmbMenu.Items.Add("Mie Goreng");
            cmbMenu.Items.Add("Ayam Geprek");

            cmbMenu.SelectedIndex = 0;
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            try
            {
                // Defensive Programming

                if (string.IsNullOrWhiteSpace(txtNamaPelanggan.Text))
                {
                    MessageBox.Show("Nama pelanggan tidak boleh kosong!");
                    return;
                }

                if ((int)numJumlahPesanan.Value <= 0)
                {
                    MessageBox.Show("Jumlah pesanan harus lebih dari 0!");
                    return;
                }

                if ((int)numJumlahPesanan.Value > menu1.Stok)
                {
                    MessageBox.Show("Jumlah pesanan melebihi stok!");
                    return;
                }

                pesanan1 = new Pesanan();

                pesanan1.NamaPelanggan = txtNamaPelanggan.Text;
                pesanan1.Menu = menu1;
                pesanan1.JumlahPesanan = (int)numJumlahPesanan.Value;
                pesanan1.TotalHarga = menu1.Harga * pesanan1.JumlahPesanan;
                pesanan1.Status = StatusPesanan.MenungguPembayaran;

                lblNamaDetail.Text = pesanan1.NamaPelanggan;
                lblMenuDetail.Text = pesanan1.Menu.NamaMakanan;
                lblHargaDetail.Text = "Rp " + pesanan1.Menu.Harga;
                lblJumlahDetail.Text = pesanan1.JumlahPesanan.ToString();
                lblTotalDetail.Text = "Rp " + pesanan1.TotalHarga;

                lblStatus.Text = pesanan1.Status.ToString();

                pesananAktif = true;

                MessageBox.Show("Pesanan berhasil dibuat!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (!pesananAktif)
            {
                MessageBox.Show("Buat pesanan terlebih dahulu!");
                return;
            }

            if (pesanan1.Status == StatusPesanan.Dibatalkan)
            {
                MessageBox.Show("Pesanan sudah dibatalkan!");
                return;
            }

            if (pesanan1.Status == StatusPesanan.Selesai)
            {
                MessageBox.Show("Pesanan sudah selesai!");
                return;
            }

            pesanan1.Status = StatusPesanan.Dibayar;
            lblStatus.Text = pesanan1.Status.ToString();

            MessageBox.Show("Pembayaran berhasil!");

            pesanan1.Status = StatusPesanan.Selesai;
            lblStatus.Text = pesanan1.Status.ToString();

            MessageBox.Show("Pesanan selesai.");
        }

        private void btnBatalkan_Click(object sender, EventArgs e)
        {
            if (!pesananAktif)
            {
                MessageBox.Show("Belum ada pesanan!");
                return;
            }

            if (pesanan1.Status == StatusPesanan.Selesai)
            {
                MessageBox.Show("Pesanan sudah selesai dan tidak bisa dibatalkan!");
                return;
            }

            if (pesanan1.Status == StatusPesanan.Dibatalkan)
            {
                MessageBox.Show("Pesanan sudah dibatalkan!");
                return;
            }

            pesanan1.Status = StatusPesanan.Dibatalkan;

            lblStatus.Text = pesanan1.Status.ToString();

            MessageBox.Show("Pesanan dibatalkan.");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNamaPelanggan.Clear();

            cmbMenu.SelectedIndex = 0;

            numJumlahPesanan.Value = 1;

            lblNamaDetail.Text = "-";
            lblMenuDetail.Text = "-";
            lblHargaDetail.Text = "-";
            lblJumlahDetail.Text = "-";
            lblTotalDetail.Text = "-";

            lblStatus.Text = "-";

            pesanan1 = null;
            pesananAktif = false;

            MessageBox.Show("Form berhasil direset.");
        }

        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMenu.Text == "Nasi Goreng")
            {
                menu1 = new MenuMakanan
                {
                    NamaMakanan = "Nasi Goreng",
                    Harga = 15000,
                    Stok = 10
                };

                lblMenuTersedia.Text = "Nasi Goreng";
                lblHargaMenu.Text = "Rp 15000";
                lblStok.Text = "10";
            }
            else if (cmbMenu.Text == "Mie Goreng")
            {
                menu1 = new MenuMakanan
                {
                    NamaMakanan = "Mie Goreng",
                    Harga = 12000,
                    Stok = 8
                };

                lblMenuTersedia.Text = "Mie Goreng";
                lblHargaMenu.Text = "Rp 12000";
                lblStok.Text = "8";
            }
            else if (cmbMenu.Text == "Ayam Geprek")
            {
                menu1 = new MenuMakanan
                {
                    NamaMakanan = "Ayam Geprek",
                    Harga = 18000,
                    Stok = 5
                };

                lblMenuTersedia.Text = "Ayam Geprek";
                lblHargaMenu.Text = "Rp 18000";
                lblStok.Text = "5";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNamaPelanggan_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblHarga_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!pesananAktif)
            {
                MessageBox.Show("Belum ada pesanan!");
                return;
            }

            if (pesanan1.Status == StatusPesanan.Dibayar)
            {
                MessageBox.Show("Pesanan sudah dibayar dan tidak bisa dibatalkan!");
                return;
            }

            if (pesanan1.Status == StatusPesanan.Dibatalkan)
            {
                MessageBox.Show("Pesanan sudah dibatalkan!");
                return;
            }

            pesanan1.Status = StatusPesanan.Dibatalkan;

            lblStatus.Text = pesanan1.Status.ToString();

            MessageBox.Show("Pesanan berhasil dibatalkan.");
        }

        private void btnBayar_Click_1(object sender, EventArgs e)
        {
            if (!pesananAktif)
            {
                MessageBox.Show("Buat pesanan terlebih dahulu!");
                return;
            }

            if (pesanan1.Status == StatusPesanan.Dibatalkan)
            {
                MessageBox.Show("Pesanan sudah dibatalkan!");
                return;
            }

            if (pesanan1.Status == StatusPesanan.Dibayar)
            {
                MessageBox.Show("Pesanan sudah dibayar!");
                return;
            }

            pesanan1.Status = StatusPesanan.Dibayar;

            lblStatus.Text = pesanan1.Status.ToString();

            MessageBox.Show("Pembayaran berhasil.");
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtNamaPelanggan.Clear();

            cmbMenu.SelectedIndex = 0;

            numJumlahPesanan.Value = 1;

            // Reset detail pesanan
            lblNamaDetail.Text = "-";
            lblMenuDetail.Text = "-";
            lblHargaDetail.Text = "-";
            lblJumlahDetail.Text = "-";
            lblTotalDetail.Text = "-";

            // Reset status pesanan
            lblStatus.Text = "-";

            // Hapus objek pesanan
            pesanan1 = null;
            pesananAktif = false;

            MessageBox.Show("Pesanan berhasil direset.");
        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void rtbRiwayat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}