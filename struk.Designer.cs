namespace COFFE_SHARP
{
    partial class struk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(struk));
            panelPrint = new Panel();
            label9 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            Nama = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            labelDate = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBoxPrint = new PictureBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panelPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).BeginInit();
            SuspendLayout();
            // 
            // panelPrint
            // 
            panelPrint.Controls.Add(label9);
            panelPrint.Controls.Add(label8);
            panelPrint.Controls.Add(dataGridView1);
            panelPrint.Controls.Add(label7);
            panelPrint.Controls.Add(label6);
            panelPrint.Controls.Add(label5);
            panelPrint.Controls.Add(label4);
            panelPrint.Controls.Add(label3);
            panelPrint.Controls.Add(labelDate);
            panelPrint.Controls.Add(label2);
            panelPrint.Controls.Add(label1);
            panelPrint.Controls.Add(pictureBox2);
            panelPrint.Location = new Point(6, 74);
            panelPrint.Name = "panelPrint";
            panelPrint.Size = new Size(525, 696);
            panelPrint.TabIndex = 0;
            panelPrint.Paint += panel1_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(190, 660);
            label9.Name = "label9";
            label9.Size = new Size(147, 30);
            label9.TabIndex = 11;
            label9.Text = "Terimakasih Telah Berlanja \r\n       di Coffe Sharp!";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 423);
            label8.Name = "label8";
            label8.Size = new Size(511, 15);
            label8.TabIndex = 10;
            label8.Text = "===============================================================\r\n";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nama, Harga, Quantity, Total });
            dataGridView1.Location = new Point(25, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(438, 182);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.Name = "Nama";
            // 
            // Harga
            // 
            Harga.HeaderText = "Harga";
            Harga.Name = "Harga";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Qty";
            Quantity.Name = "Quantity";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 197);
            label7.Name = "label7";
            label7.Size = new Size(511, 15);
            label7.TabIndex = 8;
            label7.Text = "===============================================================\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(200, 181);
            label6.Name = "label6";
            label6.Size = new Size(114, 16);
            label6.TabIndex = 7;
            label6.Text = "Daftar Transaksi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 166);
            label5.Name = "label5";
            label5.Size = new Size(511, 15);
            label5.TabIndex = 6;
            label5.Text = "===============================================================\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 137);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 5;
            label4.Text = "Admin Coffe Sharp";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 135);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Cashier :";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(68, 111);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(12, 15);
            labelDate.TabIndex = 3;
            labelDate.Text = "?";
            labelDate.Click += labelDate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 111);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Date :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 56);
            label1.Name = "label1";
            label1.Size = new Size(174, 37);
            label1.TabIndex = 1;
            label1.Text = "Coffe Sharp";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._84581413_5587_4dd8_88bb_f8465f19d4cf_12;
            pictureBox2.Location = new Point(228, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBoxPrint
            // 
            pictureBoxPrint.Image = Properties.Resources.Desain_tanpa_judul__12_2;
            pictureBoxPrint.Location = new Point(440, 12);
            pictureBoxPrint.Name = "pictureBoxPrint";
            pictureBoxPrint.Size = new Size(67, 50);
            pictureBoxPrint.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPrint.TabIndex = 0;
            pictureBoxPrint.TabStop = false;
            pictureBoxPrint.Click += pictureBoxPrint_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // struk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 773);
            Controls.Add(pictureBoxPrint);
            Controls.Add(panelPrint);
            Name = "struk";
            Text = "struk";
            Load += struk_Load;
            panelPrint.ResumeLayout(false);
            panelPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrint;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxPrint;
        private Label label3;
        private Label labelDate;
        private Label label2;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}