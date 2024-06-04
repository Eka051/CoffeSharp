using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using Npgsql;

namespace COFFE_SHARP
{
    public partial class UserControlDashboard : UserControl
    {
        private MainForm mainForm;
        private Timer timer;

        public UserControlDashboard(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            // Memperbarui label saat UserControlDashboard pertama kali dibuat
            UpdateLabels();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void btnPengelolaanStok_Click(object sender, EventArgs e)
        {
            mainForm.ShowKelolaStok();
        }

        private void btnPengelolaanProduk_Click(object sender, EventArgs e)
        {
            mainForm.ShowKelolaProduk();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            mainForm.ShowTransaksi();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                mainForm.ShowLogin();
            }
        }

        private void UpdateLabels()
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=CoffeSharp;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();

                // Mengambil jumlah produk
                string queryTotalProduk = "SELECT SUM(stok) AS jumlah_produk FROM produk";
                using (NpgsqlCommand command = new NpgsqlCommand(queryTotalProduk, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        int totalProduk = Convert.ToInt32(result);
                        lblTotalProduk.Text = totalProduk.ToString();
                    }
                    else
                    {
                        lblTotalProduk.Text = "0";
                    }
                }

                // Mengambil total penjualan
                string queryTotalPenjualan = "SELECT SUM(jumlah_produk) AS total_penjualan FROM detail_transaksi";
                using (NpgsqlCommand command = new NpgsqlCommand(queryTotalPenjualan, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        int totalPenjualan = Convert.ToInt32(result);
                        lblTotalPenjualan.Text = totalPenjualan.ToString();
                    }
                    else
                    {
                        lblTotalPenjualan.Text = "0";
                    }
                }

                // Mengambil total penghasilan
                string queryTotalPenghasilan = "SELECT SUM(transaksi.total_harga) - SUM(produk.harga * detail_transaksi.jumlah_produk) FROM transaksi JOIN detail_transaksi ON transaksi.id_transaksi = detail_Transaksi.id_transaksi JOIN produk ON detail_transaksi.id_produk = produk.id_produk";
                using (NpgsqlCommand command = new NpgsqlCommand(queryTotalPenghasilan, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal totalPenghasilan = Convert.ToDecimal(result);
                        lblTotalPenghasilan.Text = totalPenghasilan.ToString("Rp. 0");
                    }
                    else
                    {
                        lblTotalPenghasilan.Text = "Rp. 0";
                    }
                }
            }
        }
    }
}