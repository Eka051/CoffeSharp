using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    internal class Dashboard
    {
        public int TotalProduk { get; set; }
        public int TotalPenjualan { get; set; }
        public decimal TotalPenghasilan { get; set; }

        public Dashboard()
        {
            TotalProduk = 0;
            TotalPenjualan = 0;
            TotalPenghasilan = 0;
        }
    }
}