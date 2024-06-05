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
    public partial class UCPengelolaanProduk : UserControl
    {
        MainForm mainForm;
        public UCPengelolaanProduk(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            mainForm.ShowDashboard();
        }

        private void btnPengelolaanStok_Click(object sender, EventArgs e)
        {
            mainForm.ShowKelolaStok();
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
            Button btnProduct = sender as Button;
            int productId = 1;

            var confirmResult = MessageBox.Show("Yakin menghapus stok produk?", "Konfirmasi Pengurangan Stok", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                hapusProdukContext hapus = new hapusProdukContext();
                hapus.HapusProduk(productId);
            }
        }
    }
}
