using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    public class Produk
    {
        public int Id_Produk { get; set; }
        public string Nama_Produk { get; set; }
        public int Kategori_id { get; set; }
        public int Harga { get; set; }
        public int Stock { get; set; }
        public string Gambar { get; set; }


        public Produk(int Id_Produk, string Nama_Produk, int Kategori_id, int Harga, int Stock, string Gambar)
        {
            this.Id_Produk = Id_Produk;
            this.Nama_Produk = Nama_Produk;
            this.Kategori_id = Kategori_id;
            this.Harga = Harga;
            this.Stock = Stock;
            this.Gambar = Gambar;
        }
    }
}
