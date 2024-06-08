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

namespace COFFE_SHARP
{
    public partial class UCTransaksi : UserControl
    {
        private MainForm mainForm;
        private DataGridView dataGridView;

        public UCTransaksi(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;


            dataGridView = new DataGridView();
            dataGridView.Visible = false;
            dataGridView.Dock = DockStyle.Fill;
            this.Controls.Add(dataGridView);
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

        private void btnRiwayatTrs_Click(object sender, EventArgs e)
        {
            if (dataGridView.Visible)
            {
                dataGridView.Visible = false;
            }
            else
            {
                RiwayatTransaksiContext riwayatTransaksiContext = new RiwayatTransaksiContext();
                DataTable dt = riwayatTransaksiContext.GetData();

                dataGridView.DataSource = dt;
                dataGridView.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Visible = false;
        }
    }
}