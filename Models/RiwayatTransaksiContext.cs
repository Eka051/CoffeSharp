using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    internal class RiwayatTransaksiContext
    {
        private string connStr;  

        public RiwayatTransaksiContext()
        {
            connStr = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=CoffeSharpDBBaru;";
        }

        public DataTable GetData()
        {
            DataTable dt = new DataTable();   

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT transaksi.tanggal_transaksi, produk.id_produk, produk.nama_produk, produk.harga, transaksi.total_harga\r\nFROM transaksi\r\nJOIN produk ON produk.id_produk = produk.id_produk;"; 
                using (var command = new NpgsqlCommand(query, conn))
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dt);
                }

                conn.Close();
            }

            return dt;
        }
    }
}