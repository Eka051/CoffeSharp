using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    public class hapusProdukContext
    {
        private string connStr = "Server=localhost;Port=5432;Username=postgres;Password=Dani0805;Database=ProjectCoffeSharp";

        public string GetListProduk()
        {
            Produk produk = new Produk(1, "Cokelat Vanilla", 2, 25000, 23, "D:\\Ahmad\\Matkul Semester 2\\Pemrograman Beorientasi Objek\\Praktikum");

            string sql = @"insert into produk(id_produk, nama_produk, kategori_id, stok, harga, gambar_produk)
                                    SELECT id_produk, nama_produk, kategori_id, stok, harga, gambar_produk
                                    from produk
                                    where id_produk = @id_produk";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {

                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_produk", "@id_produk");

                    //NpgsqlDataReader reader = cmd.ExecuteReader();
                    //if (reader.Read())
                    //{
                    //    produk.Nama_Produk = reader["Nama_Produk"].ToString();
                    //}
                }

            }
            return produk.Nama_Produk;
        }

        public void HapusProduk(int id_produk)
        {
            string sql = @"delete from produk WHERE id_produk = @id_produk";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_produk", id_produk);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows >= 0)
                        {
                            MessageBox.Show("produk berhasil dihapus.");
                            GetListProduk();
                        }
                        else
                        {
                            MessageBox.Show("Produk tidak ditemukan atau stok sudah habis.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
