using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    public class PenjualanDipilih
    {
        string consStr = "Server=localhost;Port=5432;Username=postgres;Password=81104;Database=CoffeSharp;CommandTimeout=10";
        public double GetTotalPembayaranTanggalDipilih(DateTime tanggalAwal, DateTime tanggalAkhir)
        {
            Rekap rekap = new Rekap();
            rekap.Dipilih = 0.0;

            string query = @"SELECT SUM(total_transaksi) FROM transaksi WHERE tanggal_transaksi BETWEEN @tanggal_awal AND @tanggal_akhir";

            using (NpgsqlConnection conn = new NpgsqlConnection(consStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tanggal_awal", tanggalAwal);
                    cmd.Parameters.AddWithValue("@tanggal_akhir", tanggalAkhir);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        rekap.Dipilih = Convert.ToDouble(result);
                    }
                }
            }
            return rekap.Dipilih;
        }

    }
}
