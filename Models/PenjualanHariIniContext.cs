using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    public class PenjualanHariIniContext
    {
        string consStr = "Server=localhost;Port=5432;Username=postgres;Password=81104;Database=CoffeSharp;CommandTimeout=10";

        public double GetTotalPembayaranHariIni()
        {
            Rekap rekap = new Rekap();
            rekap.Today = 0.0;
            string query = @"SELECT SUM(total_transaksi) FROM transaksi WHERE tanggal_transaksi::date = CURRENT_DATE";
            using (NpgsqlConnection conn = new NpgsqlConnection(consStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    rekap.Today = Convert.ToDouble(cmd.ExecuteScalar());
                }
            }
            return rekap.Today;
        }
    }
}

