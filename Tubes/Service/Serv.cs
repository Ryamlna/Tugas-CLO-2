using System;
using System.Collections.Generic;
using System.Text;
using Tubes.Models;
using Tubes.Repository;

namespace Tubes.Service
{
    public class Serv
    {
        private readonly Repo<Model> menuRepository;
         
        private readonly Dictionary<string, double> kategoriDiskonBatas = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
        {
            { "Makanan Berat", 0.50 },  
            { "Roti & Kue", 0.70 },    
            { "Minuman", 0.60 }        
        };

        public Serv()
        {
            menuRepository = new Repo<Model>();
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

        public List<Model> LihatSemuaMenu()
        {
            return menuRepository.GetAll();
        }
    }
}
