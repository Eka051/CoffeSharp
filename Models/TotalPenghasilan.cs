using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    internal class TotalPenghasilan
    {
        private readonly string connStr;

        public TotalPenghasilan()
        {
            connStr = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=CoffeSharp;";
        }

        public decimal GetTotalPenghasilan()
        {
            decimal totalPenghasilan = 0;

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT SUM(transaksi.total_harga) - SUM(produk.harga * detail_transaksi.jumlah_produk) FROM transaksi JOIN detail_transaksi ON transaksi.id_transaksi = detail_transaksi.id_transaksi JOIN produk ON detail_transaksi.id_produk = produk.id_produk", conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalPenghasilan = Convert.ToDecimal(result);
                    }
                }
            }

            return totalPenghasilan;
        }
    }
}