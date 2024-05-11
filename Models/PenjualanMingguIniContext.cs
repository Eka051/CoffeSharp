using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    public class PenjualanMingguIniContext
    {
        string consStr = "Server=localhost;Port=5432;Username=postgres;Password=81104;Database=CoffeSharp;CommandTimeout=10";

        public double GetTotalPembayaranMingguIni()
        {
            Rekap rekap = new Rekap();
            rekap.Weekly = 0.0;
            string query = @"SELECT SUM(total_transaksi) AS total_transaksi_minggu_ini FROM transaksi WHERE tanggal_transaksi >= CURRENT_DATE - INTERVAL '1 week' AND tanggal_transaksi <= CURRENT_DATE;";
            using (NpgsqlConnection conn = new NpgsqlConnection(consStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    rekap.Weekly = Convert.ToDouble(cmd.ExecuteScalar());
                }
            }
            return rekap.Weekly;
        }
    }
}

