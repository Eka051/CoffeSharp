using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    public class Transaksi
    {
        public int id { get; set; }
        public string nama_produk { get; set; }
        public int harga { get; set; }
        public int jumlah { get; set; }
    }
}
