﻿namespace COFFE_SHARP
{
    partial class UserControlDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            topPanel = new Panel();
            button1 = new Button();
            panelSB = new Panel();
            srcBox = new TextBox();
            logoPanel = new Panel();
            leftPanel = new Panel();
            button4 = new Button();
            btnTransaksi = new Button();
            btnPengelolaanProduk = new Button();
            btnPengelolaanStok = new Button();
            btnDashboard = new Button();
            lblDashboard = new Label();
            panel1 = new Panel();
            lblTotalProduk = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lblTotalPenjualan = new Label();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            lblTotalPenghasilan = new Label();
            label5 = new Label();
            dspProduk = new Panel();
            lblHrgProduk = new Label();
            lblNamaProduk = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label7 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            topPanel.SuspendLayout();
            panelSB.SuspendLayout();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            dspProduk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(button1);
            topPanel.Controls.Add(panelSB);
            topPanel.Controls.Add(logoPanel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1920, 110);
            topPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Menu;
            button1.Location = new Point(898, 34);
            button1.Name = "button1";
            button1.Size = new Size(238, 41);
            button1.TabIndex = 3;
            button1.Text = "Rekap Penjualan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelSB
            // 
            panelSB.BackgroundImage = Properties.Resources.searchBox;
            panelSB.BackgroundImageLayout = ImageLayout.Zoom;
            panelSB.Controls.Add(srcBox);
            panelSB.Location = new Point(396, 30);
            panelSB.Name = "panelSB";
            panelSB.Size = new Size(304, 47);
            panelSB.TabIndex = 2;
            // 
            // srcBox
            // 
            srcBox.BackColor = SystemColors.ControlLight;
            srcBox.BorderStyle = BorderStyle.None;
            srcBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            srcBox.Location = new Point(49, 15);
            srcBox.Name = "srcBox";
            srcBox.Size = new Size(228, 19);
            srcBox.TabIndex = 2;
            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.Transparent;
            logoPanel.BackgroundImage = Properties.Resources.adminLogo;
            logoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            logoPanel.Location = new Point(-2, -2);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(266, 112);
            logoPanel.TabIndex = 2;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.White;
            leftPanel.Controls.Add(button4);
            leftPanel.Controls.Add(btnTransaksi);
            leftPanel.Controls.Add(btnPengelolaanProduk);
            leftPanel.Controls.Add(btnPengelolaanStok);
            leftPanel.Controls.Add(btnDashboard);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 110);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(264, 970);
            leftPanel.TabIndex = 1;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.Red;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.logoutBtn;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 262);
            button4.Name = "button4";
            button4.Padding = new Padding(20, 0, 0, 0);
            button4.Size = new Size(258, 58);
            button4.TabIndex = 6;
            button4.Text = "             Logout";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // btnTransaksi
            // 
            btnTransaksi.AutoSize = true;
            btnTransaksi.BackColor = Color.Transparent;
            btnTransaksi.BackgroundImageLayout = ImageLayout.Zoom;
            btnTransaksi.Cursor = Cursors.Hand;
            btnTransaksi.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransaksi.ForeColor = Color.Black;
            btnTransaksi.Image = Properties.Resources.transaksiBlack;
            btnTransaksi.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransaksi.Location = new Point(3, 198);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Padding = new Padding(20, 0, 0, 0);
            btnTransaksi.Size = new Size(258, 58);
            btnTransaksi.TabIndex = 5;
            btnTransaksi.Text = "             Transaksi";
            btnTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            btnTransaksi.UseVisualStyleBackColor = false;
            // 
            // btnPengelolaanProduk
            // 
            btnPengelolaanProduk.AutoSize = true;
            btnPengelolaanProduk.BackColor = Color.Transparent;
            btnPengelolaanProduk.BackgroundImageLayout = ImageLayout.Zoom;
            btnPengelolaanProduk.Cursor = Cursors.Hand;
            btnPengelolaanProduk.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPengelolaanProduk.ForeColor = Color.Black;
            btnPengelolaanProduk.Image = Properties.Resources.kelolaProdukBlack;
            btnPengelolaanProduk.ImageAlign = ContentAlignment.MiddleLeft;
            btnPengelolaanProduk.Location = new Point(3, 134);
            btnPengelolaanProduk.Name = "btnPengelolaanProduk";
            btnPengelolaanProduk.Padding = new Padding(20, 0, 0, 0);
            btnPengelolaanProduk.Size = new Size(276, 58);
            btnPengelolaanProduk.TabIndex = 4;
            btnPengelolaanProduk.Text = "             Pengelolaan Produk";
            btnPengelolaanProduk.TextAlign = ContentAlignment.MiddleLeft;
            btnPengelolaanProduk.UseVisualStyleBackColor = false;
            btnPengelolaanProduk.Click += btnPengelolaanProduk_Click;
            // 
            // btnPengelolaanStok
            // 
            btnPengelolaanStok.AutoSize = true;
            btnPengelolaanStok.BackColor = Color.Transparent;
            btnPengelolaanStok.BackgroundImageLayout = ImageLayout.Zoom;
            btnPengelolaanStok.Cursor = Cursors.Hand;
            btnPengelolaanStok.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPengelolaanStok.ForeColor = Color.Black;
            btnPengelolaanStok.Image = Properties.Resources.kelolaStokBlack;
            btnPengelolaanStok.ImageAlign = ContentAlignment.MiddleLeft;
            btnPengelolaanStok.Location = new Point(3, 70);
            btnPengelolaanStok.Name = "btnPengelolaanStok";
            btnPengelolaanStok.Padding = new Padding(20, 0, 0, 0);
            btnPengelolaanStok.Size = new Size(258, 58);
            btnPengelolaanStok.TabIndex = 3;
            btnPengelolaanStok.Text = "             Pengelolaan Stok";
            btnPengelolaanStok.TextAlign = ContentAlignment.MiddleLeft;
            btnPengelolaanStok.UseVisualStyleBackColor = false;
            btnPengelolaanStok.Click += btnPengelolaanStok_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSize = true;
            btnDashboard.BackColor = Color.SaddleBrown;
            btnDashboard.BackgroundImageLayout = ImageLayout.Zoom;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.dashboardWhite;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 6);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(20, 0, 0, 0);
            btnDashboard.Size = new Size(258, 58);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "             Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(396, 137);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(242, 51);
            lblDashboard.TabIndex = 2;
            lblDashboard.Text = "Dashboard";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Total_Produk;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(lblTotalProduk);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(396, 224);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 154);
            panel1.TabIndex = 3;
            // 
            // lblTotalProduk
            // 
            lblTotalProduk.AutoSize = true;
            lblTotalProduk.BackColor = Color.Transparent;
            lblTotalProduk.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProduk.Location = new Point(130, 64);
            lblTotalProduk.Name = "lblTotalProduk";
            lblTotalProduk.Size = new Size(30, 31);
            lblTotalProduk.TabIndex = 2;
            lblTotalProduk.Text = "2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(130, 99);
            label2.Name = "label2";
            label2.Size = new Size(45, 24);
            label2.TabIndex = 1;
            label2.Text = "Item";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(130, 35);
            label1.Name = "label1";
            label1.Size = new Size(116, 24);
            label1.TabIndex = 0;
            label1.Text = "Total Produk";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Total_Penjualan;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(lblTotalPenjualan);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(898, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 154);
            panel2.TabIndex = 4;
            // 
            // lblTotalPenjualan
            // 
            lblTotalPenjualan.AutoSize = true;
            lblTotalPenjualan.BackColor = Color.Transparent;
            lblTotalPenjualan.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPenjualan.Location = new Point(139, 64);
            lblTotalPenjualan.Name = "lblTotalPenjualan";
            lblTotalPenjualan.Size = new Size(30, 31);
            lblTotalPenjualan.TabIndex = 3;
            lblTotalPenjualan.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(139, 99);
            label4.Name = "label4";
            label4.Size = new Size(108, 24);
            label4.TabIndex = 2;
            label4.Text = "Item Terjual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(139, 35);
            label3.Name = "label3";
            label3.Size = new Size(140, 24);
            label3.TabIndex = 1;
            label3.Text = "Total Penjualan";
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Total_Penghasilan;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lblTotalPenghasilan);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(1398, 224);
            panel3.Name = "panel3";
            panel3.Size = new Size(422, 154);
            panel3.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(143, 96);
            label6.Name = "label6";
            label6.Size = new Size(132, 24);
            label6.TabIndex = 5;
            label6.Text = "Dari Penjualan";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPenghasilan
            // 
            lblTotalPenghasilan.AutoSize = true;
            lblTotalPenghasilan.BackColor = Color.Transparent;
            lblTotalPenghasilan.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPenghasilan.Location = new Point(143, 64);
            lblTotalPenghasilan.Name = "lblTotalPenghasilan";
            lblTotalPenghasilan.Size = new Size(84, 31);
            lblTotalPenghasilan.TabIndex = 4;
            lblTotalPenghasilan.Text = "Rp. 0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(143, 35);
            label5.Name = "label5";
            label5.Size = new Size(160, 24);
            label5.TabIndex = 2;
            label5.Text = "Total Penghasilan";
            // 
            // dspProduk
            // 
            dspProduk.BackgroundImage = Properties.Resources.dspProduk;
            dspProduk.BackgroundImageLayout = ImageLayout.Zoom;
            dspProduk.Controls.Add(lblHrgProduk);
            dspProduk.Controls.Add(lblNamaProduk);
            dspProduk.Controls.Add(pictureBox1);
            dspProduk.Location = new Point(396, 432);
            dspProduk.Name = "dspProduk";
            dspProduk.Size = new Size(190, 286);
            dspProduk.TabIndex = 6;
            // 
            // lblHrgProduk
            // 
            lblHrgProduk.AutoSize = true;
            lblHrgProduk.BackColor = Color.Transparent;
            lblHrgProduk.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHrgProduk.ForeColor = Color.DarkOrange;
            lblHrgProduk.Location = new Point(40, 208);
            lblHrgProduk.Name = "lblHrgProduk";
            lblHrgProduk.Size = new Size(109, 24);
            lblHrgProduk.TabIndex = 2;
            lblHrgProduk.Text = "Rp. 55.000";
            lblHrgProduk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNamaProduk
            // 
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.BackColor = Color.Transparent;
            lblNamaProduk.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaProduk.Location = new Point(32, 181);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(134, 24);
            lblNamaProduk.TabIndex = 1;
            lblNamaProduk.Text = "Kopi Robusta";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.coffe_beans;
            pictureBox1.Location = new Point(32, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.dspProduk;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(628, 432);
            panel4.Name = "panel4";
            panel4.Size = new Size(190, 286);
            panel4.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkOrange;
            label7.Location = new Point(40, 208);
            label7.Name = "label7";
            label7.Size = new Size(109, 24);
            label7.TabIndex = 2;
            label7.Text = "Rp. 75.000";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(32, 181);
            label8.Name = "label8";
            label8.Size = new Size(129, 24);
            label8.TabIndex = 1;
            label8.Text = "Kopi Arabica";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.coffe_beans;
            pictureBox2.Location = new Point(32, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // UserControlDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(dspProduk);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblDashboard);
            Controls.Add(leftPanel);
            Controls.Add(topPanel);
            Name = "UserControlDashboard";
            Size = new Size(1920, 1080);
            topPanel.ResumeLayout(false);
            panelSB.ResumeLayout(false);
            panelSB.PerformLayout();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            dspProduk.ResumeLayout(false);
            dspProduk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel topPanel;
        private Panel leftPanel;
        private Panel logoPanel;
        private Button button4;
        private Button btnTransaksi;
        private Button btnPengelolaanProduk;
        private Button btnPengelolaanStok;
        private Button btnDashboard;
        private Panel panelSB;
        private TextBox srcBox;
        private Label lblDashboard;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel dspProduk;
        private Label lblTotalProduk;
        private Label label2;
        private Label label1;
        private Label lblTotalPenjualan;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label lblTotalPenghasilan;
        private Label label5;
        private Label lblHrgProduk;
        private Label lblNamaProduk;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox2;
        private Button button1;
    }
}
