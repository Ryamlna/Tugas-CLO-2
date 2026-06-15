using Microsoft.VisualStudio.TestTools.UnitTesting;
using TugasCLO2Libraries;

namespace TugasCLO2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTotalHarga()
        {
            MenuMakanan menu = new MenuMakanan();

            menu.Harga = 15000;

            Pesanan pesanan = new Pesanan();

            pesanan.Menu = menu;
            pesanan.JumlahPesanan = 2;

            pesanan.TotalHarga =
                pesanan.Menu.Harga * pesanan.JumlahPesanan;

            Assert.AreEqual(30000, pesanan.TotalHarga);
        }
    }
}