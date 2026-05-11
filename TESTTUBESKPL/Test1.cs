using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tubes.Models;
using Tubes.Service;

namespace TESTTUBESKPL
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TambahMenu_InputValid_BerhasilMenambahData()
        { 
            Serv testService = new Serv();
            Model menuValid = new Model
            {
                NamaProduk = "Menu Normal",
                Kategori = "Minuman",
                HargaAsli = 10000,
                HargaSurplus = 8000,
                Stok = 5
            };
             
            testService.TambahMenu(menuValid);
             
            Assert.AreEqual(1, testService.LihatSemuaMenu().Count);
        }

        [TestMethod]
        public void TambahMenu_StokNegatif_MelemparArgumentException()
        { 
            Serv testService = new Serv();
            Model menuStokMinus = new Model
            {
                NamaProduk = "Menu Minus",
                Kategori = "Minuman",
                HargaAsli = 10000,
                HargaSurplus = 8000,
                Stok = -2
            };

            try
            { 
                testService.TambahMenu(menuStokMinus);
                 
                Assert.Fail("Sistem gagal! Harusnya error karena stok negatif, tapi malah lolos.");
            }
            catch (ArgumentException)
            { 
            }
        }

        [TestMethod]
        public void TambahMenu_DiskonMelebihiBatas_MelemparArgumentException()
        { 
            Serv testService = new Serv();
            Model menuDiskonIlegal = new Model
            {
                NamaProduk = "Menu Murah",
                Kategori = "Roti & Kue",
                HargaAsli = 10000,
                HargaSurplus = 1000,
                Stok = 5
            };

            try
            { 
                testService.TambahMenu(menuDiskonIlegal);
                 
                Assert.Fail("Sistem gagal! Harusnya error karena harga surplus kemurahan, tapi malah lolos.");
            }
            catch (ArgumentException)
            { 
            }
        }
    }
}