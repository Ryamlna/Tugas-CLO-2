using System;
using System.Collections.Generic;
using System.Text;

namespace Tubes.Models
{
    public class Model
    {
        public string FoodId { get; set; }
        public string NamaProduk { get; set; }
        public double HargaAsli { get; set; }
        public double HargaSurplus { get; set; }
        public int Stok { get; set; }
        public string Kategori { get; set; }
    }
}
