using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    internal class TotalPenjualan
    {
        private readonly string connStr;

        public TotalPenjualan()
        {
            connStr = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=CoffeSharp;";
        }

        public int GetTotalPenjualan()
        {
            int totalPenjualan = 0;

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT SUM(total_pembayaran_transaksi) FROM Transaksi", conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalPenjualan = Convert.ToInt32(result);
                    }
                }
            }

            return totalPenjualan;
        }
    }
}