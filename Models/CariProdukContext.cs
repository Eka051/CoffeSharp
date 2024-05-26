using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    internal class CariProdukContext
    {
        string connStr = "Server=localhost;Port=5432;User Id=postgres;Password=lina123;Database=CoffeSharp";

        public CariProduk GetProduk(string nama_produk)
        {
            CariProduk cariProduk = new CariProduk();
            string sql = @" SELECT nama_produk, harga
			from produk
			where nama_produk = @nama_produk";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_produk", nama_produk);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cariProduk.nama_produk = reader["nama_produk"].ToString();
                            cariProduk.harga = (int)reader["harga"];
                        }
                    }
                }
            }
            return cariProduk;
        }
    }
}

