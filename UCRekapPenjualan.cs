using COFFE_SHARP.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COFFE_SHARP
{
    public partial class UCRekapPenjualan : UserControl
    {
        MainForm mainForm;
        public UCRekapPenjualan(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void UCRekapPenjualan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.ShowDashboard();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            mainForm.ShowDashboard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime tanggalAwal = dateTimePicker1.Value.Date;
            DateTime tanggalAkhir = dateTimePicker2.Value.Date;

            Rekap rekap = new Rekap();
            PenjualanDipilih penjualanDipilih = new PenjualanDipilih();
            rekap.Dipilih = penjualanDipilih.GetTotalPembayaranTanggalDipilih(tanggalAwal, tanggalAkhir);
            label10.Text = rekap.Dipilih.ToString();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void DisplaySalesData()
        {
        }
        public void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void button3_Click_1(object sender, EventArgs e)
        {
            Rekap rekap = new Rekap();
            PenjualanHariIniContext context = new PenjualanHariIniContext();
            rekap.Today = context.GetTotalPembayaranHariIni();
            label15.Text = rekap.Today.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rekap rekap = new Rekap();
            PenjualanMingguIniContext context = new PenjualanMingguIniContext();
            rekap.Weekly = context.GetTotalPembayaranMingguIni();
            label17.Text = rekap.Weekly.ToString();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rekap rekap = new Rekap();
            PenjualanBulanIni context = new PenjualanBulanIni();
            rekap.Weekly = context.GetTotalPembayaranBulanIni();
            label16.Text = rekap.Weekly.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnPengelolaanStok_Click(object sender, EventArgs e)
        {
            mainForm.ShowKelolaProduk();
        }

        private void btnPengelolaanProduk_Click(object sender, EventArgs e)
        {
            mainForm.ShowKelolaStok();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
        }
    }
}
