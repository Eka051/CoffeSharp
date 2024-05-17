namespace COFFE_SHARP
{
    partial class qr_pembayaran
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
            logoPanel = new Panel();
            panel1 = new Panel();
            Label_QR = new Label();
            Box_qr = new PictureBox();
            btn_QR_Pembayaran = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Box_qr).BeginInit();
            SuspendLayout();
            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.Transparent;
            logoPanel.BackgroundImage = Properties.Resources.adminLogo;
            logoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            logoPanel.Location = new Point(12, 12);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(160, 65);
            logoPanel.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Label_QR);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 89);
            panel1.TabIndex = 15;
            // 
            // Label_QR
            // 
            Label_QR.AutoSize = true;
            Label_QR.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_QR.Location = new Point(202, 24);
            Label_QR.Name = "Label_QR";
            Label_QR.Size = new Size(273, 42);
            Label_QR.TabIndex = 0;
            Label_QR.Text = "QR Pembayaran";
            // 
            // Box_qr
            // 
            Box_qr.Location = new Point(35, 116);
            Box_qr.Name = "Box_qr";
            Box_qr.Size = new Size(500, 500);
            Box_qr.SizeMode = PictureBoxSizeMode.Zoom;
            Box_qr.TabIndex = 16;
            Box_qr.TabStop = false;
            Box_qr.Click += pictureBox1_Click;
            // 
            // btn_QR_Pembayaran
            // 
            btn_QR_Pembayaran.BackColor = Color.Red;
            btn_QR_Pembayaran.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_QR_Pembayaran.ForeColor = Color.Cornsilk;
            btn_QR_Pembayaran.Location = new Point(133, 635);
            btn_QR_Pembayaran.Name = "btn_QR_Pembayaran";
            btn_QR_Pembayaran.Size = new Size(307, 43);
            btn_QR_Pembayaran.TabIndex = 17;
            btn_QR_Pembayaran.Text = "Lanjutkan";
            btn_QR_Pembayaran.UseVisualStyleBackColor = false;
            btn_QR_Pembayaran.Click += btn_QR_Pembayaran_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(16, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(535, 592);
            panel2.TabIndex = 18;
            // 
            // qr_pembayaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 707);
            Controls.Add(btn_QR_Pembayaran);
            Controls.Add(Box_qr);
            Controls.Add(logoPanel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "qr_pembayaran";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Box_qr).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel logoPanel;
        private Panel panel1;
        private PictureBox Box_qr;
        private Button btn_QR_Pembayaran;
        private Label Label_QR;
        private Panel panel2;
    }
}