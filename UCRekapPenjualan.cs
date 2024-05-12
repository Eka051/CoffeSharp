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

        Rekap rekap = new Rekap();

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime tanggalAwal = dateTimePicker1.Value.Date;
            DateTime tanggalAkhir = dateTimePicker2.Value.Date;

            PenjualanDipilih penjualanDipilih = new PenjualanDipilih();
            rekap.Dipilih = penjualanDipilih.GetTotalPembayaranTanggalDipilih(tanggalAwal, tanggalAkhir);
            if (rekap.Dipilih == 0)
            {
                LabelPenjualanBerdasarkanPeriodeDipilih.Text = "0";
                MessageBox.Show("Tidak ada Penjualan Yang Terjadi Pada Tanggal Tersebut");
            }
            else
            {
                LabelPenjualanBerdasarkanPeriodeDipilih.Text = rekap.Dipilih.ToString();
            }
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
            PenjualanHariIniContext context = new PenjualanHariIniContext();
            rekap.Today = context.GetTotalPembayaranHariIni();
            PenjualanMingguIniContext penjualanMingguIniContext = new PenjualanMingguIniContext();
            rekap.Weekly = penjualanMingguIniContext.GetTotalPembayaranMingguIni();
            PenjualanBulanIni penjualanBulanIni = new PenjualanBulanIni();
            rekap.Monthly = penjualanBulanIni.GetTotalPembayaranBulanIni();
            if (rekap.Today == 0)
            {
                label3.Text = "Tidak Ada Penjualan Hari Ini";
            }
            else
            {
                LabelRekapHariIni.Text = rekap.Today.ToString();
            }

            LabelRekapMingguIni.Text = rekap.Weekly.ToString();
            if (rekap.Weekly == 0)
            {
                label1.Text = "Tidak ada Penjualan Minggu Ini";
            }
            else
            {
                LabelRekapMingguIni.Text = rekap.Weekly.ToString();
            }

            if (rekap.Monthly == 0)
            {
                label4.Text = "Tidak ada Penjualan Bulan Ini";
            }
            else
            {
                LabelRekapBulanIni.Text = rekap.Monthly.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
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

        private void lblNamaProduk_Click(object sender, EventArgs e)
        {
        }

        private void LabelPenjualanBerdasarkanPeriodeDipilih_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
