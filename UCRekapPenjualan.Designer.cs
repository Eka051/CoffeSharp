namespace COFFE_SHARP
{
    partial class UCRekapPenjualan
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
            logoPanel = new Panel();
            leftPanel = new Panel();
            button4 = new Button();
            btnTransaksi = new Button();
            btnPengelolaanProduk = new Button();
            btnPengelolaanStok = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            label15 = new Label();
            lblNamaProduk = new Label();
            label6 = new Label();
            lblTotalPenghasilan = new Label();
            panel1 = new Panel();
            label17 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblDashboard = new Label();
            panel2 = new Panel();
            label16 = new Label();
            label9 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            label11 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            panel4 = new Panel();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            topPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(button1);
            topPanel.Controls.Add(logoPanel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1920, 110);
            topPanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Menu;
            button1.Location = new Point(303, 37);
            button1.Name = "button1";
            button1.Size = new Size(195, 43);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            leftPanel.TabIndex = 2;
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
            btnTransaksi.Click += btnTransaksi_Click;
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
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Total_Penghasilan;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Controls.Add(label15);
            panel3.Controls.Add(lblNamaProduk);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lblTotalPenghasilan);
            panel3.Location = new Point(303, 226);
            panel3.Name = "panel3";
            panel3.Size = new Size(422, 154);
            panel3.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(197, 64);
            label15.Name = "label15";
            label15.Size = new Size(30, 31);
            label15.TabIndex = 7;
            label15.Text = "0";
            label15.TextAlign = ContentAlignment.BottomCenter;
            label15.Click += label15_Click;
            // 
            // lblNamaProduk
            // 
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.BackColor = Color.Transparent;
            lblNamaProduk.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaProduk.Location = new Point(143, 35);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(76, 24);
            lblNamaProduk.TabIndex = 6;
            lblNamaProduk.Text = "Hari Ini";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(143, 95);
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
            lblTotalPenghasilan.Size = new Size(60, 31);
            lblTotalPenghasilan.TabIndex = 4;
            lblTotalPenghasilan.Text = "Rp.";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Total_Penghasilan;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(790, 226);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 154);
            panel1.TabIndex = 7;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(197, 65);
            label17.Name = "label17";
            label17.Size = new Size(30, 31);
            label17.TabIndex = 9;
            label17.Text = "0";
            label17.TextAlign = ContentAlignment.BottomCenter;
            label17.Click += label17_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(143, 40);
            label5.Name = "label5";
            label5.Size = new Size(180, 24);
            label5.TabIndex = 7;
            label5.Text = "1 Minggu Terakhir";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 96);
            label1.Name = "label1";
            label1.Size = new Size(132, 24);
            label1.TabIndex = 5;
            label1.Text = "Dari Penjualan";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(143, 64);
            label2.Name = "label2";
            label2.Size = new Size(68, 31);
            label2.TabIndex = 4;
            label2.Text = "Rp. ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(143, 35);
            label3.Name = "label3";
            label3.Size = new Size(98, 24);
            label3.TabIndex = 2;
            label3.Text = "Minggu Ini";
            label3.Click += label3_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(303, 136);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(366, 51);
            lblDashboard.TabIndex = 6;
            lblDashboard.Text = "Rekap Penjualan";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Total_Penghasilan;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(1281, 226);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 154);
            panel2.TabIndex = 8;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(204, 65);
            label16.Name = "label16";
            label16.Size = new Size(30, 31);
            label16.TabIndex = 10;
            label16.Text = "0";
            label16.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(143, 35);
            label9.Name = "label9";
            label9.Size = new Size(91, 24);
            label9.TabIndex = 9;
            label9.Text = "Bulan Ini";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(143, 96);
            label4.Name = "label4";
            label4.Size = new Size(132, 24);
            label4.TabIndex = 5;
            label4.Text = "Dari Penjualan";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(143, 64);
            label7.Name = "label7";
            label7.Size = new Size(68, 31);
            label7.TabIndex = 4;
            label7.Text = "Rp. ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(143, 35);
            label8.Name = "label8";
            label8.Size = new Size(98, 24);
            label8.TabIndex = 2;
            label8.Text = "Minggu Ini";
            // 
            // button2
            // 
            button2.BackColor = Color.SaddleBrown;
            button2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Menu;
            button2.Location = new Point(257, 63);
            button2.Name = "button2";
            button2.Size = new Size(165, 34);
            button2.TabIndex = 4;
            button2.Text = "Tampilkan";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(635, 23);
            label11.Name = "label11";
            label11.Size = new Size(17, 24);
            label11.TabIndex = 10;
            label11.Text = "-";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(684, 19);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(351, 29);
            dateTimePicker2.TabIndex = 11;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(257, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(352, 29);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Total_Penghasilan;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Location = new Point(303, 739);
            panel4.Name = "panel4";
            panel4.Size = new Size(621, 248);
            panel4.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(218, 99);
            label10.Name = "label10";
            label10.Size = new Size(30, 31);
            label10.TabIndex = 8;
            label10.Text = "0";
            label10.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(162, 66);
            label12.Name = "label12";
            label12.Size = new Size(420, 24);
            label12.TabIndex = 6;
            label12.Text = "Total Penjualan Berdasarkan Periode Dipilih";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(162, 140);
            label13.Name = "label13";
            label13.Size = new Size(132, 24);
            label13.TabIndex = 5;
            label13.Text = "Dari Penjualan";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(162, 99);
            label14.Name = "label14";
            label14.Size = new Size(60, 31);
            label14.TabIndex = 4;
            label14.Text = "Rp.";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(button2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(303, 566);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1070, 121);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pilih Periode Transaksi";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.BackColor = Color.SaddleBrown;
            button3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Menu;
            button3.Location = new Point(303, 384);
            button3.Name = "button3";
            button3.Size = new Size(165, 34);
            button3.TabIndex = 16;
            button3.Text = "Tampilkan";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.SaddleBrown;
            button5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Menu;
            button5.Location = new Point(790, 384);
            button5.Name = "button5";
            button5.Size = new Size(165, 34);
            button5.TabIndex = 17;
            button5.Text = "Tampilkan";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.SaddleBrown;
            button6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.Menu;
            button6.Location = new Point(1281, 384);
            button6.Name = "button6";
            button6.Size = new Size(165, 34);
            button6.TabIndex = 18;
            button6.Text = "Tampilkan";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // UCRekapPenjualan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(lblDashboard);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(leftPanel);
            Controls.Add(topPanel);
            Controls.Add(groupBox1);
            Name = "UCRekapPenjualan";
            Size = new Size(1920, 1080);
            Load += UCRekapPenjualan_Load;
            topPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel topPanel;
        private Panel logoPanel;
        private Panel leftPanel;
        private Button button4;
        private Button btnTransaksi;
        private Button btnPengelolaanProduk;
        private Button btnPengelolaanStok;
        private Button btnDashboard;
        private Button button1;
        private Panel panel3;
        private Label label6;
        private Label lblTotalPenghasilan;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblDashboard;
        private Panel panel2;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label lblNamaProduk;
        private Label label5;
        private Button button2;
        private Label label11;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Panel panel4;
        private Label label12;
        private Label label13;
        private Label label14;
        private GroupBox groupBox1;
        public Label label15;
        public Label label17;
        public Label label16;
        public Label label10;
        public Label label9;
        public Button button3;
        public Button button5;
        public Button button6;
    }
}
