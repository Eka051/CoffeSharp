using COFFE_SHARP.Models;
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
    public partial class UserControlDashboard : UserControl
    {
        MainForm mainForm;
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
        private void button1_Click(object sender, EventArgs e)
        {
            Rekap rekap = new Rekap();
            UCRekapPenjualan uCRekapPenjualan = new UCRekapPenjualan(mainForm);
            PenjualanHariIniContext penjualanHariIniContext = new PenjualanHariIniContext();
            PenjualanMingguIniContext penjualanMingguIniContext = new PenjualanMingguIniContext();
            PenjualanBulanIni penjualanBulanIni = new PenjualanBulanIni();
            rekap.Today = penjualanHariIniContext.GetTotalPembayaranHariIni();
            rekap.Weekly = penjualanMingguIniContext.GetTotalPembayaranMingguIni();
            rekap.Monthly = penjualanBulanIni.GetTotalPembayaranBulanIni();

            mainForm.ShowKelolaRekap();

            // Mengatur LabelRekapHariIni
            uCRekapPenjualan.LabelRekapHariIni.Text = rekap.Today.ToString();

            // Mengatur LabelRekapMingguIni
            uCRekapPenjualan.LabelRekapMingguIni.Text = rekap.Weekly.ToString();

            // Mengatur LabelRekapBulanIni
            uCRekapPenjualan.LabelRekapBulanIni.Text = rekap.Monthly.ToString();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            mainForm.ShowDashboard();
        }
    }
}
