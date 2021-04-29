namespace BankacılıkFinal
{
    partial class HesapIslemleriForm
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
            this.components = new System.ComponentModel.Container();
            this.eftIsimComboBox = new System.Windows.Forms.ComboBox();
            this.eftIBANComboBox = new System.Windows.Forms.ComboBox();
            this.eftYapanIbanComboBox = new System.Windows.Forms.ComboBox();
            this.kisiLabel = new System.Windows.Forms.Label();
            this.eftKisiIbanLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eftYapButton = new System.Windows.Forms.Button();
            this.CikisButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.USDIBANLabel = new System.Windows.Forms.Label();
            this.EUROIBANLabel = new System.Windows.Forms.Label();
            this.TLIBANLabel = new System.Windows.Forms.Label();
            this.HesapBakiyeLabel = new System.Windows.Forms.Label();
            this.eftMiktariTextBox = new System.Windows.Forms.MaskedTextBox();
            this.paraBirimiLbl = new System.Windows.Forms.Label();
            this.hesapTimer = new System.Windows.Forms.Timer(this.components);
            this.guvenlikGroupBox = new System.Windows.Forms.GroupBox();
            this.saniyeLbl = new System.Windows.Forms.Label();
            this.uyariLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hosgeldinLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.guvenlikGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // eftIsimComboBox
            // 
            this.eftIsimComboBox.BackColor = System.Drawing.Color.PowderBlue;
            this.eftIsimComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eftIsimComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eftIsimComboBox.FormattingEnabled = true;
            this.eftIsimComboBox.Location = new System.Drawing.Point(462, 66);
            this.eftIsimComboBox.Name = "eftIsimComboBox";
            this.eftIsimComboBox.Size = new System.Drawing.Size(194, 24);
            this.eftIsimComboBox.TabIndex = 0;
            this.eftIsimComboBox.SelectedIndexChanged += new System.EventHandler(this.eftIsimComboBox_SelectedIndexChanged);
            // 
            // eftIBANComboBox
            // 
            this.eftIBANComboBox.BackColor = System.Drawing.Color.PowderBlue;
            this.eftIBANComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eftIBANComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eftIBANComboBox.FormattingEnabled = true;
            this.eftIBANComboBox.Location = new System.Drawing.Point(462, 119);
            this.eftIBANComboBox.Name = "eftIBANComboBox";
            this.eftIBANComboBox.Size = new System.Drawing.Size(193, 24);
            this.eftIBANComboBox.TabIndex = 1;
            this.eftIBANComboBox.SelectedIndexChanged += new System.EventHandler(this.eftIBANComboBox_SelectedIndexChanged);
            // 
            // eftYapanIbanComboBox
            // 
            this.eftYapanIbanComboBox.BackColor = System.Drawing.Color.PowderBlue;
            this.eftYapanIbanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eftYapanIbanComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eftYapanIbanComboBox.FormattingEnabled = true;
            this.eftYapanIbanComboBox.Location = new System.Drawing.Point(463, 174);
            this.eftYapanIbanComboBox.Name = "eftYapanIbanComboBox";
            this.eftYapanIbanComboBox.Size = new System.Drawing.Size(194, 24);
            this.eftYapanIbanComboBox.TabIndex = 2;
            this.eftYapanIbanComboBox.SelectedIndexChanged += new System.EventHandler(this.eftYapanIbanComboBox_SelectedIndexChanged);
            // 
            // kisiLabel
            // 
            this.kisiLabel.AutoSize = true;
            this.kisiLabel.BackColor = System.Drawing.Color.Beige;
            this.kisiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kisiLabel.Location = new System.Drawing.Point(460, 50);
            this.kisiLabel.Name = "kisiLabel";
            this.kisiLabel.Size = new System.Drawing.Size(161, 13);
            this.kisiLabel.TabIndex = 4;
            this.kisiLabel.Text = "Eft Yapılacak Kişiyi Seçiniz";
            // 
            // eftKisiIbanLabel
            // 
            this.eftKisiIbanLabel.AutoSize = true;
            this.eftKisiIbanLabel.BackColor = System.Drawing.Color.Beige;
            this.eftKisiIbanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eftKisiIbanLabel.Location = new System.Drawing.Point(459, 102);
            this.eftKisiIbanLabel.Name = "eftKisiIbanLabel";
            this.eftKisiIbanLabel.Size = new System.Drawing.Size(217, 13);
            this.eftKisiIbanLabel.TabIndex = 5;
            this.eftKisiIbanLabel.Text = "Eft Yapılacak Kişinin Iban Numaraları";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(459, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Eft Yapmak İstediğiniz IBAN numaranız";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(460, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Eft Miktarı:";
            // 
            // eftYapButton
            // 
            this.eftYapButton.BackColor = System.Drawing.Color.SkyBlue;
            this.eftYapButton.Enabled = false;
            this.eftYapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eftYapButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.eftYapButton.Location = new System.Drawing.Point(468, 279);
            this.eftYapButton.Name = "eftYapButton";
            this.eftYapButton.Size = new System.Drawing.Size(176, 71);
            this.eftYapButton.TabIndex = 8;
            this.eftYapButton.Text = "EFT YAP";
            this.eftYapButton.UseVisualStyleBackColor = false;
            this.eftYapButton.Click += new System.EventHandler(this.eftYapButton_Click);
            // 
            // CikisButton
            // 
            this.CikisButton.BackColor = System.Drawing.Color.SkyBlue;
            this.CikisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CikisButton.ForeColor = System.Drawing.Color.Red;
            this.CikisButton.Location = new System.Drawing.Point(468, 366);
            this.CikisButton.Name = "CikisButton";
            this.CikisButton.Size = new System.Drawing.Size(176, 72);
            this.CikisButton.TabIndex = 9;
            this.CikisButton.Text = "ÇIKIŞ";
            this.CikisButton.UseVisualStyleBackColor = false;
            this.CikisButton.Click += new System.EventHandler(this.CikisButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.USDIBANLabel);
            this.groupBox1.Controls.Add(this.EUROIBANLabel);
            this.groupBox1.Controls.Add(this.TLIBANLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 213);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // USDIBANLabel
            // 
            this.USDIBANLabel.AutoSize = true;
            this.USDIBANLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.USDIBANLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.USDIBANLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.USDIBANLabel.Location = new System.Drawing.Point(6, 150);
            this.USDIBANLabel.Name = "USDIBANLabel";
            this.USDIBANLabel.Size = new System.Drawing.Size(121, 16);
            this.USDIBANLabel.TabIndex = 14;
            this.USDIBANLabel.Text = "Dolar Hesabı: YOK";
            // 
            // EUROIBANLabel
            // 
            this.EUROIBANLabel.AutoSize = true;
            this.EUROIBANLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.EUROIBANLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EUROIBANLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EUROIBANLabel.Location = new System.Drawing.Point(6, 82);
            this.EUROIBANLabel.Name = "EUROIBANLabel";
            this.EUROIBANLabel.Size = new System.Drawing.Size(116, 16);
            this.EUROIBANLabel.TabIndex = 13;
            this.EUROIBANLabel.Text = "Euro Hesabı: YOK";
            // 
            // TLIBANLabel
            // 
            this.TLIBANLabel.AutoSize = true;
            this.TLIBANLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.TLIBANLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TLIBANLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TLIBANLabel.Location = new System.Drawing.Point(6, 18);
            this.TLIBANLabel.Name = "TLIBANLabel";
            this.TLIBANLabel.Size = new System.Drawing.Size(150, 16);
            this.TLIBANLabel.TabIndex = 12;
            this.TLIBANLabel.Text = "Türk Lirası Hesabı: YOK";
            // 
            // HesapBakiyeLabel
            // 
            this.HesapBakiyeLabel.AutoSize = true;
            this.HesapBakiyeLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.HesapBakiyeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HesapBakiyeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HesapBakiyeLabel.Location = new System.Drawing.Point(92, 100);
            this.HesapBakiyeLabel.Name = "HesapBakiyeLabel";
            this.HesapBakiyeLabel.Size = new System.Drawing.Size(195, 16);
            this.HesapBakiyeLabel.TabIndex = 11;
            this.HesapBakiyeLabel.Text = "Hesaplarınızdaki Bakiyeler";
            // 
            // eftMiktariTextBox
            // 
            this.eftMiktariTextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.eftMiktariTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eftMiktariTextBox.Location = new System.Drawing.Point(462, 223);
            this.eftMiktariTextBox.Mask = "999,999.999";
            this.eftMiktariTextBox.Name = "eftMiktariTextBox";
            this.eftMiktariTextBox.Size = new System.Drawing.Size(194, 26);
            this.eftMiktariTextBox.TabIndex = 11;
            this.eftMiktariTextBox.Text = "000000000";
            this.eftMiktariTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.eftMiktariTextBox_MaskInputRejected);
            // 
            // paraBirimiLbl
            // 
            this.paraBirimiLbl.AutoSize = true;
            this.paraBirimiLbl.BackColor = System.Drawing.Color.SkyBlue;
            this.paraBirimiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.paraBirimiLbl.Location = new System.Drawing.Point(557, 226);
            this.paraBirimiLbl.Name = "paraBirimiLbl";
            this.paraBirimiLbl.Size = new System.Drawing.Size(44, 20);
            this.paraBirimiLbl.TabIndex = 12;
            this.paraBirimiLbl.Text = "USD";
            // 
            // hesapTimer
            // 
            this.hesapTimer.Enabled = true;
            this.hesapTimer.Interval = 1000;
            this.hesapTimer.Tick += new System.EventHandler(this.hesapTimer_Tick);
            // 
            // guvenlikGroupBox
            // 
            this.guvenlikGroupBox.BackColor = System.Drawing.Color.LightGray;
            this.guvenlikGroupBox.Controls.Add(this.saniyeLbl);
            this.guvenlikGroupBox.Controls.Add(this.uyariLbl);
            this.guvenlikGroupBox.Location = new System.Drawing.Point(12, 350);
            this.guvenlikGroupBox.Name = "guvenlikGroupBox";
            this.guvenlikGroupBox.Size = new System.Drawing.Size(366, 88);
            this.guvenlikGroupBox.TabIndex = 13;
            this.guvenlikGroupBox.TabStop = false;
            this.guvenlikGroupBox.Visible = false;
            this.guvenlikGroupBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // saniyeLbl
            // 
            this.saniyeLbl.AutoSize = true;
            this.saniyeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saniyeLbl.ForeColor = System.Drawing.Color.Red;
            this.saniyeLbl.Location = new System.Drawing.Point(20, 64);
            this.saniyeLbl.Name = "saniyeLbl";
            this.saniyeLbl.Size = new System.Drawing.Size(24, 16);
            this.saniyeLbl.TabIndex = 15;
            this.saniyeLbl.Text = "60";
            // 
            // uyariLbl
            // 
            this.uyariLbl.AutoSize = true;
            this.uyariLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyariLbl.Location = new System.Drawing.Point(20, 16);
            this.uyariLbl.Name = "uyariLbl";
            this.uyariLbl.Size = new System.Drawing.Size(255, 64);
            this.uyariLbl.TabIndex = 0;
            this.uyariLbl.Text = "GÜVENLİK UYARISI !!!\r\n\r\nBu ekran son 4 dakikadır aktif değil.\r\n     Saniye sonra " +
    "çıkış yapılacak.\r\n";
            this.uyariLbl.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.hosgeldinLbl);
            this.groupBox3.Location = new System.Drawing.Point(12, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 53);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // hosgeldinLbl
            // 
            this.hosgeldinLbl.AutoSize = true;
            this.hosgeldinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosgeldinLbl.Location = new System.Drawing.Point(73, 16);
            this.hosgeldinLbl.Name = "hosgeldinLbl";
            this.hosgeldinLbl.Size = new System.Drawing.Size(83, 18);
            this.hosgeldinLbl.TabIndex = 0;
            this.hosgeldinLbl.Text = "Hoşgeldin";
            this.hosgeldinLbl.Click += new System.EventHandler(this.hosgeldinLbl_Click);
            // 
            // HesapIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(744, 470);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.guvenlikGroupBox);
            this.Controls.Add(this.paraBirimiLbl);
            this.Controls.Add(this.eftMiktariTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HesapBakiyeLabel);
            this.Controls.Add(this.CikisButton);
            this.Controls.Add(this.eftYapButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eftKisiIbanLabel);
            this.Controls.Add(this.kisiLabel);
            this.Controls.Add(this.eftYapanIbanComboBox);
            this.Controls.Add(this.eftIBANComboBox);
            this.Controls.Add(this.eftIsimComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "HesapIslemleriForm";
            this.Text = "EFT İŞLEMLERİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HesapIslemleriForm_FormClosing);
            this.Load += new System.EventHandler(this.HesapIslemleriForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HesapIslemleriForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guvenlikGroupBox.ResumeLayout(false);
            this.guvenlikGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox eftIsimComboBox;
        private System.Windows.Forms.ComboBox eftIBANComboBox;
        private System.Windows.Forms.ComboBox eftYapanIbanComboBox;
        private System.Windows.Forms.Label kisiLabel;
        private System.Windows.Forms.Label eftKisiIbanLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button eftYapButton;
        private System.Windows.Forms.Button CikisButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label USDIBANLabel;
        private System.Windows.Forms.Label EUROIBANLabel;
        private System.Windows.Forms.Label TLIBANLabel;
        private System.Windows.Forms.Label HesapBakiyeLabel;
        private System.Windows.Forms.MaskedTextBox eftMiktariTextBox;
        private System.Windows.Forms.Label paraBirimiLbl;
        private System.Windows.Forms.Timer hesapTimer;
        private System.Windows.Forms.GroupBox guvenlikGroupBox;
        private System.Windows.Forms.Label saniyeLbl;
        private System.Windows.Forms.Label uyariLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label hosgeldinLbl;
    }
}