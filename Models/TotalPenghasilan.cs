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

                using (var cmd = new NpgsqlCommand("SELECT SUM(total_pembayaran_transaksi) - SUM(jumlah_produk * harga) FROM Transaksi JOIN Produk ON Transaksi.id_produk = Produk.id_produk", conn))
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