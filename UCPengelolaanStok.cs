using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using COFFE_SHARP.Models;
using Npgsql;
using System.Reflection.Emit;

namespace COFFE_SHARP
{
    public partial class UCPengelolaanStok : UserControl
    {
        private MainForm mainForm;
        private ProdukStokContext produkStokContext;
        private Timer timer;

        public UCPengelolaanStok(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += timer_Tick;
            timer.Start();

            UpdateLabels();

            this.produkStokContext = new ProdukStokContext();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            mainForm.ShowDashboard();
        }

        private void btnPengelolaanProduk_Click(object sender, EventArgs e)
        {
            mainForm.ShowKelolaProduk();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                mainForm.ShowLogin();
            }
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            mainForm.ShowTransaksi();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            produkStokContext.TambahStok("Robusta", 1);
            MessageBox.Show("Stok kopi robusta berhasil ditambahkan.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            produkStokContext.KurangiStok("Robusta", 1);
            MessageBox.Show("Stok kopi robusta berhasil dikurangi.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            produkStokContext.KurangiStok("Arabica", 1);
            MessageBox.Show("Stok kopi arabica berhasil dikurangi.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            produkStokContext.TambahStok("Arabica", 1);
            MessageBox.Show("Stok kopi arabica berhasil ditambahkan.");
        }

        private void UpdateLabels()
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=CoffeSharpDB;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();

                string queryTotalRobusta = "SELECT SUM(stok) FROM produk WHERE nama_produk = 'Robusta'";
                using (NpgsqlCommand command = new NpgsqlCommand(queryTotalRobusta, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        int totalRobusta = Convert.ToInt32(result);
                        label1.Text = $"{totalRobusta}";
                    }
                    else
                    {
                        label1.Text = "0";
                    }
                }

                string queryTotalArabica = "SELECT SUM(stok) FROM produk WHERE nama_produk = 'Arabica'";
                using (NpgsqlCommand command = new NpgsqlCommand(queryTotalArabica, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        int totalArabica = Convert.ToInt32(result);
                        label4.Text = $"{totalArabica}";
                    }
                    else
                    {
                        label4.Text = "0";
                    }
                }
            }
        }

        private void tambah_arabica_Click(object sender, EventArgs e)
        {
            produkStokContext.TambahStok("Arabica", 1);
            MessageBox.Show("Stok kopi Arabica berhasil ditambahkan.");
        }

        private void kurang_arabica_Click(object sender, EventArgs e)
        {
            produkStokContext.KurangiStok("Arabica", 1);
            MessageBox.Show("Stok kopi Arabica berhasil dikurangi.");
        }
    }
}