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
            button3 = new Button();
            ButtonBackDasboard = new Button();
            logoPanel = new Panel();
            leftPanel = new Panel();
            button4 = new Button();
            btnTransaksi = new Button();
            btnPengelolaanProduk = new Button();
            btnPengelolaanStok = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            label3 = new Label();
            LabelRekapHariIni = new Label();
            LabelStatusRekapHariIni = new Label();
            lblTotalPenghasilan = new Label();
            panel1 = new Panel();
            LabelRekapMingguIni = new Label();
            LabelStatusRekapMingguIni = new Label();
            label1 = new Label();
            label2 = new Label();
            lblDashboard = new Label();
            panel2 = new Panel();
            LabelRekapBulanIni = new Label();
            LabelStatusRekapBulanIni = new Label();
            label4 = new Label();
            label7 = new Label();
            button2 = new Button();
            label11 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            panel4 = new Panel();
            LabelPenjualanBerdasarkanPeriodeDipilih = new Label();
            LabelStatusPenjualanBerdasarkanPeriodeDipilih = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox1 = new GroupBox();
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
            topPanel.Controls.Add(ButtonBackDasboard);
            topPanel.Controls.Add(logoPanel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1920, 110);
            topPanel.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.SaddleBrown;
            button3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Menu;
            button3.Location = new Point(790, 411);
            button3.Name = "button3";
            button3.Size = new Size(422, 43);
            button3.TabIndex = 16;
            button3.Text = "Tampilkan Rekap";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // ButtonBackDasboard
            // 
            ButtonBackDasboard.BackColor = Color.SaddleBrown;
            ButtonBackDasboard.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonBackDasboard.ForeColor = SystemColors.Menu;
            ButtonBackDasboard.Location = new Point(303, 37);
            ButtonBackDasboard.Name = "ButtonBackDasboard";
            ButtonBackDasboard.Size = new Size(195, 43);
            ButtonBackDasboard.TabIndex = 3;
            ButtonBackDasboard.Text = "Back";
            ButtonBackDasboard.UseVisualStyleBackColor = false;
            ButtonBackDasboard.Click += button1_Click;
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
            panel3.Controls.Add(label3);
            panel3.Controls.Add(LabelRekapHariIni);
            panel3.Controls.Add(LabelStatusRekapHariIni);
            panel3.Controls.Add(lblTotalPenghasilan);
            panel3.Location = new Point(303, 226);
            panel3.Name = "panel3";
            panel3.Size = new Size(422, 154);
            panel3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(119, 99);
            label3.Name = "label3";
            label3.Size = new Size(132, 24);
            label3.TabIndex = 10;
            label3.Text = "Dari Penjualan";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelRekapHariIni
            // 
            LabelRekapHariIni.AutoSize = true;
            LabelRekapHariIni.BackColor = Color.Transparent;
            LabelRekapHariIni.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRekapHariIni.Location = new Point(175, 65);
            LabelRekapHariIni.Name = "LabelRekapHariIni";
            LabelRekapHariIni.Size = new Size(30, 31);
            LabelRekapHariIni.TabIndex = 7;
            LabelRekapHariIni.Text = "0";
            LabelRekapHariIni.TextAlign = ContentAlignment.BottomCenter;
            LabelRekapHariIni.Click += label15_Click;
            // 
            // LabelStatusRekapHariIni
            // 
            LabelStatusRekapHariIni.AutoSize = true;
            LabelStatusRekapHariIni.BackColor = Color.Transparent;
            LabelStatusRekapHariIni.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelStatusRekapHariIni.Location = new Point(119, 35);
            LabelStatusRekapHariIni.Name = "LabelStatusRekapHariIni";
            LabelStatusRekapHariIni.Size = new Size(76, 24);
            LabelStatusRekapHariIni.TabIndex = 6;
            LabelStatusRekapHariIni.Text = "Hari Ini";
            LabelStatusRekapHariIni.Click += lblNamaProduk_Click;
            // 
            // lblTotalPenghasilan
            // 
            lblTotalPenghasilan.AutoSize = true;
            lblTotalPenghasilan.BackColor = Color.Transparent;
            lblTotalPenghasilan.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPenghasilan.Location = new Point(119, 64);
            lblTotalPenghasilan.Name = "lblTotalPenghasilan";
            lblTotalPenghasilan.Size = new Size(60, 31);
            lblTotalPenghasilan.TabIndex = 4;
            lblTotalPenghasilan.Text = "Rp.";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Total_Penghasilan;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(LabelRekapMingguIni);
            panel1.Controls.Add(LabelStatusRekapMingguIni);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(790, 226);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 154);
            panel1.TabIndex = 7;
            // 
            // LabelRekapMingguIni
            // 
            LabelRekapMingguIni.AutoSize = true;
            LabelRekapMingguIni.BackColor = Color.Transparent;
            LabelRekapMingguIni.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRekapMingguIni.Location = new Point(176, 65);
            LabelRekapMingguIni.Name = "LabelRekapMingguIni";
            LabelRekapMingguIni.Size = new Size(30, 31);
            LabelRekapMingguIni.TabIndex = 9;
            LabelRekapMingguIni.Text = "0";
            LabelRekapMingguIni.TextAlign = ContentAlignment.BottomCenter;
            LabelRekapMingguIni.Click += label17_Click;
            // 
            // LabelStatusRekapMingguIni
            // 
            LabelStatusRekapMingguIni.AutoSize = true;
            LabelStatusRekapMingguIni.BackColor = Color.Transparent;
            LabelStatusRekapMingguIni.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelStatusRekapMingguIni.Location = new Point(119, 35);
            LabelStatusRekapMingguIni.Name = "LabelStatusRekapMingguIni";
            LabelStatusRekapMingguIni.Size = new Size(108, 24);
            LabelStatusRekapMingguIni.TabIndex = 7;
            LabelStatusRekapMingguIni.Text = "Minggu Ini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 96);
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
            label2.Location = new Point(119, 65);
            label2.Name = "label2";
            label2.Size = new Size(68, 31);
            label2.TabIndex = 4;
            label2.Text = "Rp. ";
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
            panel2.Controls.Add(LabelRekapBulanIni);
            panel2.Controls.Add(LabelStatusRekapBulanIni);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(1281, 226);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 154);
            panel2.TabIndex = 8;
            // 
            // LabelRekapBulanIni
            // 
            LabelRekapBulanIni.AutoSize = true;
            LabelRekapBulanIni.BackColor = Color.Transparent;
            LabelRekapBulanIni.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRekapBulanIni.Location = new Point(185, 64);
            LabelRekapBulanIni.Name = "LabelRekapBulanIni";
            LabelRekapBulanIni.Size = new Size(30, 31);
            LabelRekapBulanIni.TabIndex = 10;
            LabelRekapBulanIni.Text = "0";
            LabelRekapBulanIni.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LabelStatusRekapBulanIni
            // 
            LabelStatusRekapBulanIni.AutoSize = true;
            LabelStatusRekapBulanIni.BackColor = Color.Transparent;
            LabelStatusRekapBulanIni.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelStatusRekapBulanIni.Location = new Point(124, 35);
            LabelStatusRekapBulanIni.Name = "LabelStatusRekapBulanIni";
            LabelStatusRekapBulanIni.Size = new Size(91, 24);
            LabelStatusRekapBulanIni.TabIndex = 9;
            LabelStatusRekapBulanIni.Text = "Bulan Ini";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(124, 99);
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
            label7.Location = new Point(124, 64);
            label7.Name = "label7";
            label7.Size = new Size(68, 31);
            label7.TabIndex = 4;
            label7.Text = "Rp. ";
            // 
            // button2
            // 
            button2.BackColor = Color.SaddleBrown;
            button2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Menu;
            button2.Location = new Point(257, 77);
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
            label11.Location = new Point(936, 548);
            label11.Name = "label11";
            label11.Size = new Size(17, 24);
            label11.TabIndex = 10;
            label11.Text = "-";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(663, 19);
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
            panel4.Controls.Add(LabelPenjualanBerdasarkanPeriodeDipilih);
            panel4.Controls.Add(LabelStatusPenjualanBerdasarkanPeriodeDipilih);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Location = new Point(303, 503);
            panel4.Name = "panel4";
            panel4.Size = new Size(621, 248);
            panel4.TabIndex = 7;
            // 
            // LabelPenjualanBerdasarkanPeriodeDipilih
            // 
            LabelPenjualanBerdasarkanPeriodeDipilih.AutoSize = true;
            LabelPenjualanBerdasarkanPeriodeDipilih.BackColor = Color.Transparent;
            LabelPenjualanBerdasarkanPeriodeDipilih.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPenjualanBerdasarkanPeriodeDipilih.Location = new Point(241, 99);
            LabelPenjualanBerdasarkanPeriodeDipilih.Name = "LabelPenjualanBerdasarkanPeriodeDipilih";
            LabelPenjualanBerdasarkanPeriodeDipilih.Size = new Size(30, 31);
            LabelPenjualanBerdasarkanPeriodeDipilih.TabIndex = 8;
            LabelPenjualanBerdasarkanPeriodeDipilih.Text = "0";
            LabelPenjualanBerdasarkanPeriodeDipilih.TextAlign = ContentAlignment.BottomCenter;
            LabelPenjualanBerdasarkanPeriodeDipilih.Click += LabelPenjualanBerdasarkanPeriodeDipilih_Click;
            // 
            // LabelStatusPenjualanBerdasarkanPeriodeDipilih
            // 
            LabelStatusPenjualanBerdasarkanPeriodeDipilih.AutoSize = true;
            LabelStatusPenjualanBerdasarkanPeriodeDipilih.BackColor = Color.Transparent;
            LabelStatusPenjualanBerdasarkanPeriodeDipilih.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelStatusPenjualanBerdasarkanPeriodeDipilih.Location = new Point(175, 61);
            LabelStatusPenjualanBerdasarkanPeriodeDipilih.Name = "LabelStatusPenjualanBerdasarkanPeriodeDipilih";
            LabelStatusPenjualanBerdasarkanPeriodeDipilih.Size = new Size(420, 24);
            LabelStatusPenjualanBerdasarkanPeriodeDipilih.TabIndex = 6;
            LabelStatusPenjualanBerdasarkanPeriodeDipilih.Text = "Total Penjualan Berdasarkan Periode Dipilih";
            LabelStatusPenjualanBerdasarkanPeriodeDipilih.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(175, 140);
            label13.Name = "label13";
            label13.Size = new Size(132, 24);
            label13.TabIndex = 5;
            label13.Text = "Dari Penjualan";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(175, 99);
            label14.Name = "label14";
            label14.Size = new Size(60, 31);
            label14.TabIndex = 4;
            label14.Text = "Rp.";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(303, 788);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1066, 160);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pilih Periode Transaksi";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // UCRekapPenjualan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(lblDashboard);
            Controls.Add(label11);
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
        private Button ButtonBackDasboard;
        private Panel panel3;
        private Label lblTotalPenghasilan;
        private Panel panel1;
        private Label label2;
        private Label lblDashboard;
        private Panel panel2;
        private Label label4;
        private Label label7;
        private Label LabelStatusRekapMingguIni;
        private Button button2;
        private Label label11;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Panel panel4;
        private Label LabelStatusPenjualanBerdasarkanPeriodeDipilih;
        private Label label13;
        private Label label14;
        private GroupBox groupBox1;
        public Label LabelRekapHariIni;
        public Label LabelRekapMingguIni;
        public Label LabelRekapBulanIni;
        public Label LabelPenjualanBerdasarkanPeriodeDipilih;
        public Label LabelStatusRekapBulanIni;
        public Button button3;
        public Label LabelStatusRekapHariIni;
        public Label label1;
        public Label label3;
    }
}
