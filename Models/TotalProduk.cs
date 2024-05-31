using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    internal class TotalProduk
    {
        private readonly string connStr;

        public TotalProduk()
        {
            connStr = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=CoffeSharp;";
        }

        public int GetTotalProduk()
        {
            int totalProduk = 0;

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM Produk", conn))
                {
                    totalProduk = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return totalProduk;
        }
    }
}