using COFFE_SHARP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFE_SHARP
{
    public partial class UserControlDashboard : UserControl
    {
        MainForm mainForm;
        UserControlLogin login;
        public UserControlDashboard(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
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

        private void srcBox_TextChanged(object sender, EventArgs e)
        {
            /*CariProdukContext cariProdukContext = new CariProdukContext();*/
            /* CariProduk cariProduk = cariProdukContext.GetProduk(nama_produk);*/
            //lblNamaProduk.Text = cariProduk.nama_produk;
            //lblHrgProduk.Text = cariProduk.harga.ToString();
            TextBox srcBox = sender as TextBox;
            string nama_produk = srcBox.Text;

            if (!string.IsNullOrEmpty(nama_produk))
            {
                CariProdukContext cariProdukContext = new CariProdukContext();
                CariProduk cariProduk = cariProdukContext.GetProduk(nama_produk);

                if (cariProduk != null)
                {
                    lblNamaProduk.Text = cariProduk.nama_produk;
                    lblHrgProduk.Text = cariProduk.harga.ToString();
                }
                else
                {
                    lblNamaProduk.Text = "Produk tidak ditemukan";
                    lblHrgProduk.Text = string.Empty;
                }
            }
            else
            {
                lblNamaProduk.Text = string.Empty;
                lblHrgProduk.Text = string.Empty;
            }
        }
    }
}
        