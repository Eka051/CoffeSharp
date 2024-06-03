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
    public partial class metode : Form
    {
        public metode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            struk Struk = new struk();
            Struk.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
