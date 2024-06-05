using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace COFFE_SHARP.Models
{
    internal class ProdukStokContext
    {
        private string connStr;

        public ProdukStokContext()
        {
            connStr = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=CoffeSharpDB;";
        }

        private void ExecuteQuery(string query)
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                using (var command = new NpgsqlCommand(query, conn))
                {
                    command.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public void TambahStok(string nama_produk, int jumlah)
        {
            if (nama_produk == "Robusta")
            {
                string query = $"UPDATE produk SET Stok = Stok + {jumlah} WHERE nama_produk = 'Robusta'";
                ExecuteQuery(query);
            }
            else if (nama_produk == "Arabica")
            {
                string query = $"UPDATE produk SET Stok = Stok + {jumlah} WHERE nama_produk = 'Arabica'";
                ExecuteQuery(query);
            }
        }

        public void KurangiStok(string nama_produk, int jumlah)
        {
            if (nama_produk == "Robusta")
            {
                string query = $"UPDATE produk SET Stok = Stok - {jumlah} WHERE nama_produk = 'Robusta'";
                ExecuteQuery(query);
            }
            else if (nama_produk == "Arabica")
            {
                string query = $"UPDATE produk SET Stok = Stok - {jumlah} WHERE nama_produk = 'Arabica'";
                ExecuteQuery(query);
            }
        }

        public int GetTotalStok(string nama_produk)
        {
            int totalProduk = 0;

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                string query = $"SELECT SUM(stok) FROM produk WHERE nama_produk = '{nama_produk}'";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalProduk = Convert.ToInt32(result);
                    }
                }
            }

            return totalProduk;
        }
    }
}