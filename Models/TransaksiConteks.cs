using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace COFFE_SHARP.Models
{
    public class Struk
    {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Total => Quantity * Price;
    }

    public class transaksi
    {
        public DateTime TanggalTransaksi { get; set; }
        public List<Struk> Struks { get; set; } = new List<Struk>();
    }
    public class TransaksiConteks
    {
        private readonly string connStr;
        public TransaksiConteks()
        {
            connStr = "Server=localhost;Port=5432;Username=postgres;Password=arifa01;Database=coffeshap;CommandTimeout=10";
        }

        public List<Transaksi> GetDataTransaksi()
        {
            var transaksiList = new List<Transaksi>();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT TanggalTransaksi FROM Transaksi"; // Replace with your actual query

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Transaksi transaksi = new Transaksi
                                {
                                    
                                };
                                transaksiList.Add(transaksi);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return transaksiList;
        }
    }

    /*public void GetDataTransaksi()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
        {
            conn.Open();
            using (NpgsqlCommand cmd = conn.CreateCommand())
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Transaksi transaksi = new Transaksi
                        {
                            TanggalTransaksi = reader.GetData
                        }
                    }
                }
            }
        }
    }*/
}



    /*public List<struk> GetItemsForTransaction(int transaksiId)
    {
        List<struk> items = new List<struk>();

        using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
        {
            conn.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT p.name, dt.jumlahproduk, dt.hargaproduk FROM detailtransaksi dt JOIN produk p ON dt.idproduk = p.idproduk WHERE dt.idtransaksi = @idtransaksi", conn))
            {
                cmd.Parameters.AddWithValue("@idtransaksi", transaksiId);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        struk item = new struk
                        {
                            Name = reader.GetString(0),
                            Quantity = reader.GetInt32(1),
                            Price = reader.GetDecimal(2)
                        };
                        items.Add(item);
                    }
                }
            }
        }

        return items;
    }

}

}*/