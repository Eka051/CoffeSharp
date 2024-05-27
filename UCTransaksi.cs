using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COFFE_SHARP.Models;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COFFE_SHARP
{
    public partial class UCTransaksi : UserControl
    {
        MainForm mainForm;
        public UCTransaksi(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                mainForm.ShowLogin();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            mainForm.ShowDashboard();
        }

        private void btnPengelolaanStok_Click(object sender, EventArgs e)
        {
            mainForm.ShowKelolaStok();
        }

        private void btnPengelolaanProduk_Click(object sender, EventArgs e)
        {
            mainForm.ShowKelolaProduk();
        }

        private void addProdukTrs_Click(object sender, EventArgs e)
        {
            TransaksiContext transaksiContext = new TransaksiContext();
            int id = 1;
            Transaksi transaksi = transaksiContext.GetListTransaksi(id);
            NamaProduk.Text = transaksi.nama_produk;
            //labelTotalProduk.Text = transaksi.jumlah.ToString();
        }

        private void addTotal_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalProduk_Click(object sender, EventArgs e)
        {

        }

        private void UCTransaksi_Load(object sender, EventArgs e)
        {

        }
    }
}
