using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    internal class ProdukStok
    {
        public int id_produk { get; set; }

        public string nama_produk { get; set; }

        public int kategori_id { get; set; }

        public decimal harga { get; set; }

        public int stok { get; set; }

        public byte[] gambar_produk { get; set; }

        public int GetTotalStokRobusta { get; set; }
        public int GetTotalStokArabica { get; set; }
        
    }
}
