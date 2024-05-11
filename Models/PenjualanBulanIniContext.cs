using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    public class PenjualanBulanIni
    {
        string consStr = "Server=localhost;Port=5432;Username=postgres;Password=81104;Database=CoffeSharp;CommandTimeout=10";

        public double GetTotalPembayaranBulanIni()
        {
            Rekap rekap = new Rekap();
            rekap.Monthly = 0.0;

            string query = @"SELECT SUM(total_transaksi) AS total_transaksi_bulan_ini FROM transaksi WHERE tanggal_transaksi >= TO_DATE(TO_CHAR(CURRENT_DATE, 'YYYY-MM-01'), 'YYYY-MM-DD')  AND tanggal_transaksi < TO_DATE(TO_CHAR(CURRENT_DATE + INTERVAL '1 month', 'YYYY-MM-01'), 'YYYY-MM-DD');";
            
            using (NpgsqlConnection conn = new NpgsqlConnection(consStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    rekap.Monthly = Convert.ToDouble(cmd.ExecuteScalar());
                }
            }
            return rekap.Monthly;
        }
    }
}
