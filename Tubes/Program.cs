using System;
using Tubes.Models;
using Tubes.Service;

namespace Tubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Serv menuService = new Serv();

            Console.WriteLine("=== SISTEM PENGELOLAAN MENU GOODBITE ===");

            while (true)
            {
                Console.WriteLine("\n-- Tambah Menu Baru --");
                try
                {
                    Model itemBaru = new Model();

                    Console.Write("Nama Produk: ");
                    itemBaru.NamaProduk = Console.ReadLine() ?? "";

                    Console.Write("Kategori (Makanan Berat / Roti & Kue / Minuman): ");
                    itemBaru.Kategori = Console.ReadLine() ?? "";

                    Console.Write("Harga Asli (Rp): ");
                    itemBaru.HargaAsli = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Harga Jual Surplus (Rp): ");
                    itemBaru.HargaSurplus = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Jumlah Stok: ");
                    itemBaru.Stok = Convert.ToInt32(Console.ReadLine());
                     
                    menuService.TambahMenu(itemBaru);
                    Console.WriteLine($"\n[BERHASIL] '{itemBaru.NamaProduk}' berhasil ditambahkan ke sistem!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("\n[GAGAL] Input angka tidak valid! Pastikan harga dan stok diisi dengan angka.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n[GAGAL] Error: {ex.Message}");
                }

                var semuaMenu = menuService.LihatSemuaMenu();
                Console.WriteLine($"\nTotal menu tersimpan saat ini: {semuaMenu.Count}");

                if (semuaMenu.Count > 0)
                {
                    Console.WriteLine("--- Daftar Menu Tersimpan ---");
                    int nomor = 1;
                    foreach (var item in semuaMenu)
                    {
                        Console.WriteLine($"{nomor}. {item.NamaProduk} ({item.Kategori}) | Stok: {item.Stok} | Harga Asli: Rp{item.HargaAsli} -> Jual: Rp{item.HargaSurplus}");
                        nomor++;
                    }
                    Console.WriteLine("-----------------------------");
                }

                Console.Write("\nMau tambah menu lagi? (y/n): ");
                string lanjut = Console.ReadLine() ?? "";
                if (lanjut.ToLower() != "y")
                {
                    break;
                }
            }

            Console.WriteLine("\nTerima kasih. Tekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}