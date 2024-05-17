using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace COFFE_SHARP
{
    public partial class qr_pembayaran : Form
    {
        public qr_pembayaran()
        {
            InitializeComponent();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_QR_Pembayaran_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void code_qr(string text)
        {
            QRCoder.QRCodeGenerator qr_baru = new QRCoder.QRCodeGenerator();
            var Data_qr = qr_baru.CreateQrCode(text, QRCodeGenerator.ECCLevel.H);
            var QR = new QRCoder.QRCode(Data_qr);
            Box_qr.Image = QR.GetGraphic(100);
        }
    }
}
