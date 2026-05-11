using System;
using System.Collections.Generic;
using System.Text;

namespace TugasCLO2Libraries
{
    public class Pesanan
    {
        public string NamaPelanggan { get; set; }
        public MenuMakanan Menu { get; set; }
        public int JumlahPesanan { get; set; }
        public int TotalHarga { get; set; }
        public StatusPesanan Status { get; set; }
    }
}
