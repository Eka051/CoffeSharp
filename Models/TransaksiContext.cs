using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace COFFE_SHARP.Models
{
    public class TransaksiContext
    {
        string connStr = "Server=localhost;Port=5432;Username=postgres;Password=kairikumar;Database=Produk";

        public Transaksi GetListTransaksi(int id)
        {
            Transaksi transaksi = new Transaksi();
            string sql = @"insert into daftar_transaksi(id, nama_produk, harga, jumlah)
                            SELECT id, nama_produk, harga, 1
                            from produk
                            where id = @id
                            ON CONFLICT(id) DO UPDATE
                            SET  jumlah = daftar_transaksi.jumlah + 1";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    //cmd.ExecuteNonQuery();

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            transaksi.nama_produk = reader["nama_produk"].ToString();
                            //transaksi.jumlah = (int)reader["jumlah"];
                        }
                    }
                }
            }
            return transaksi;
        }
    }

}
