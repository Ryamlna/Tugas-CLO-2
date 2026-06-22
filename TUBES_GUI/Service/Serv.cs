using System;
using System.Collections.Generic;
using System.Text;
using TUBES_GUI.Repositories;
using TUBES_GUI.Models;

namespace TUBES_GUI.Services
{
    public class Serv
    {
        private static Serv _instance;

        private readonly Repo<Model> menuRepository;
        private readonly Dictionary<string, double> kategoriDiskonBatas = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
        {
            { "Makanan Berat", 0.50 },
            { "Roti & Kue", 0.70 },
            { "Minuman", 0.60 }
        };

        private Serv()
        {
            menuRepository = new Repo<Model>();
        }

        public static Serv GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Serv();
            }
            return _instance;
        }


        public void TambahMenu(Model item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Data makanan tidak boleh kosong.");

            if (string.IsNullOrWhiteSpace(item.NamaProduk))
                throw new ArgumentException("Nama produk wajib diisi.");

            if (item.HargaAsli <= 0)
                throw new ArgumentException("Harga asli harus lebih besar dari 0.");

            if (item.Stok < 0)
                throw new ArgumentException("Stok tidak boleh bernilai negatif.");

            if (!kategoriDiskonBatas.ContainsKey(item.Kategori))
                throw new ArgumentException($"Kategori '{item.Kategori}' tidak terdaftar dalam sistem.");

            double maxDiskon = kategoriDiskonBatas[item.Kategori];
            double batasHargaMinimum = item.HargaAsli * (1.0 - maxDiskon);

            if (item.HargaSurplus < batasHargaMinimum)
                throw new ArgumentException($"Harga surplus terlalu rendah. Untuk kategori {item.Kategori}, harga minimal adalah {Math.Round(batasHargaMinimum)}.");

            if (item.HargaSurplus > item.HargaAsli)
                throw new ArgumentException("Harga surplus tidak boleh lebih mahal dari harga asli.");

            int initialCount = menuRepository.GetAll().Count;

            item.FoodId = Guid.NewGuid().ToString();
            menuRepository.Add(item);

            if (menuRepository.GetAll().Count != initialCount + 1)
                throw new InvalidOperationException("Gagal menambahkan menu ke dalam sistem.");

        }

        public void UpdateMenu(string id, Model dataBaru)
        { 
            var itemLama = menuRepository.GetAll().FirstOrDefault(m => m.FoodId == id);

            if (itemLama == null)
                throw new Exception("Menu tidak ditemukan di dalam sistem.");
             
            if (string.IsNullOrWhiteSpace(dataBaru.NamaProduk)) throw new ArgumentException("Nama produk wajib diisi.");
            if (dataBaru.HargaAsli <= 0) throw new ArgumentException("Harga asli harus lebih besar dari 0.");
            if (dataBaru.Stok < 0) throw new ArgumentException("Stok tidak boleh bernilai negatif.");
            if (!kategoriDiskonBatas.ContainsKey(dataBaru.Kategori)) throw new ArgumentException("Kategori tidak valid.");

            double maxDiskon = kategoriDiskonBatas[dataBaru.Kategori];
            double batasHargaMinimum = dataBaru.HargaAsli * (1.0 - maxDiskon);

            if (dataBaru.HargaSurplus < batasHargaMinimum)
                throw new ArgumentException($"Harga surplus terlalu rendah. Minimal harga adalah Rp {Math.Round(batasHargaMinimum)}.");
            if (dataBaru.HargaSurplus > dataBaru.HargaAsli)
                throw new ArgumentException("Harga surplus tidak boleh lebih mahal dari harga asli.");
             
            itemLama.NamaProduk = dataBaru.NamaProduk;
            itemLama.Kategori = dataBaru.Kategori;
            itemLama.HargaAsli = dataBaru.HargaAsli;
            itemLama.HargaSurplus = dataBaru.HargaSurplus;
            itemLama.Stok = dataBaru.Stok;
        }
        public void HapusMenu(string id)
        {
            var item = menuRepository.GetAll().FirstOrDefault(m => m.FoodId == id);
            if (item != null)
            {
                menuRepository.Delete(item);
            }
            else
            {
                throw new Exception("Menu tidak ditemukan untuk dihapus.");
            }
        }

        public List<Model> LihatSemuaMenu()
        {
            return menuRepository.GetAll();
        }
    }
}
