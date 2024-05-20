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

namespace COFFE_SHARP
{
    public partial class UserControlDashboard : UserControl
    {
        MainForm mainForm;
        UserControlLogin login;
        private System.Windows.Forms.Timer timer;

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
            string connectionString = "Server=localhost;Database=CoffeSharp;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Mengambil jumlah produk
                string queryTotalProduk = "SELECT COUNT(*) AS jumlah_produk FROM Produk";
                using (SqlCommand command = new SqlCommand(queryTotalProduk, connection))
                {
                    int totalProduk = (int)command.ExecuteScalar();
                    lblTotalProduk.Text = totalProduk.ToString();
                }

                // Mengambil total penjualan
                string queryTotalPenjualan = "SELECT COUNT(*) AS total_penjualan FROM Transaksi";
                using (SqlCommand command = new SqlCommand(queryTotalPenjualan, connection))
                {
                    int totalPenjualan = (int)command.ExecuteScalar();
                    lblTotalPenjualan.Text = totalPenjualan.ToString();
                }

                // Mengambil total penghasilan
                string queryTotalPenghasilan = "SELECT SUM(total_pembayaran_transaksi) - SUM(jumlah_produk * harga) AS total_penghasilan FROM Transaksi JOIN Produk ON Transaksi.id_produk = Produk.id_produk";
                using (SqlCommand command = new SqlCommand(queryTotalPenghasilan, connection))
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