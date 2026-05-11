using TugasCLO2Libraries;

// DATA MENU MAKANAN

MenuMakanan menu1 = new MenuMakanan();

menu1.NamaMakanan = "Nasi Goreng";
menu1.Harga = 15000;
menu1.Stok = 10;

// INPUT DATA PESANAN

Pesanan pesanan1 = new Pesanan();

Console.WriteLine("=== SISTEM PEMESANAN MAKANAN GOODBITE ===");

Console.Write("Masukkan Nama Pelanggan : ");
pesanan1.NamaPelanggan = Console.ReadLine();

Console.Write("Masukkan Jumlah Pesanan : ");
string inputJumlah = Console.ReadLine();

// Defensive programming + DbC
// Nama pelanggan tidak boleh kosong

if (string.IsNullOrWhiteSpace(pesanan1.NamaPelanggan))
{
    throw new ArgumentException("Nama pelanggan tidak boleh kosong");
}

// Defensive programming
// Jumlah pesanan harus berupa angka

if (!int.TryParse(inputJumlah, out int jumlahPesanan))
{
    throw new ArgumentException("Jumlah pesanan harus berupa angka");
}

pesanan1.JumlahPesanan = jumlahPesanan;

// Defensive programming
// Jumlah pesanan harus lebih dari 0

if (pesanan1.JumlahPesanan <= 0)
{
    throw new ArgumentException("Jumlah pesanan harus lebih dari 0");
}

// Defensive programming
// Jumlah pesanan tidak boleh melebihi stok

if (pesanan1.JumlahPesanan > menu1.Stok)
{
    throw new InvalidOperationException("Stok makanan tidak cukup");
}

// PROSES PEMESANAN

pesanan1.Menu = menu1;

pesanan1.TotalHarga =
    pesanan1.Menu.Harga * pesanan1.JumlahPesanan;

// AUTOMATA

// Status awal pesanan

pesanan1.Status = StatusPesanan.MenungguPembayaran;

Console.WriteLine();
Console.WriteLine("Status Pesanan : " + pesanan1.Status);

Console.WriteLine();
Console.WriteLine("Pilih Aksi:");
Console.WriteLine("1. Bayar Pesanan");
Console.WriteLine("2. Batalkan Pesanan");

Console.Write("Masukkan pilihan : ");
string pilihan = Console.ReadLine();


if (pilihan == "1")
{
    pesanan1.Status = StatusPesanan.Dibayar;

    Console.WriteLine("Pesanan berhasil dibayar");

    pesanan1.Status = StatusPesanan.Selesai;
}

else if (pilihan == "2")
{
    pesanan1.Status = StatusPesanan.Dibatalkan;

    Console.WriteLine("Pesanan dibatalkan");
}

else
{
    Console.WriteLine("Pilihan tidak valid");
}

Console.WriteLine();
Console.WriteLine("=== DATA PESANAN ===");

Console.WriteLine("Nama Pelanggan : " + pesanan1.NamaPelanggan);
Console.WriteLine("Menu Makanan   : " + pesanan1.Menu.NamaMakanan);
Console.WriteLine("Jumlah Pesanan : " + pesanan1.JumlahPesanan);
Console.WriteLine("Total Harga    : " + pesanan1.TotalHarga);
Console.WriteLine("Status Akhir   : " + pesanan1.Status);
