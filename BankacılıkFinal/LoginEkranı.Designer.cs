namespace BankacılıkFinal
{
    partial class LoginForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.baslik = new System.Windows.Forms.Label();
            this.GirisButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hesapNoTB = new System.Windows.Forms.TextBox();
            this.parolaTB = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sifreHataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(134, 9);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(437, 42);
            this.baslik.TabIndex = 0;
            this.baslik.Text = "Bankamıza Hoşgeldiniz...";
            // 
            // GirisButton
            // 
            this.GirisButton.BackColor = System.Drawing.Color.Linen;
            this.GirisButton.Enabled = false;
            this.GirisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.GirisButton.Location = new System.Drawing.Point(239, 172);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(189, 76);
            this.GirisButton.TabIndex = 1;
            this.GirisButton.Text = "GİRİŞ";
            this.GirisButton.UseVisualStyleBackColor = false;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(180, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(160, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hesap No:";
            // 
            // hesapNoTB
            // 
            this.hesapNoTB.Location = new System.Drawing.Point(266, 100);
            this.hesapNoTB.Name = "hesapNoTB";
            this.hesapNoTB.Size = new System.Drawing.Size(123, 20);
            this.hesapNoTB.TabIndex = 4;
            this.hesapNoTB.TextChanged += new System.EventHandler(this.hesapNoTB_TextChanged);
            // 
            // parolaTB
            // 
            this.parolaTB.Location = new System.Drawing.Point(266, 134);
            this.parolaTB.Name = "parolaTB";
            this.parolaTB.PasswordChar = '*';
            this.parolaTB.Size = new System.Drawing.Size(123, 20);
            this.parolaTB.TabIndex = 5;
            this.parolaTB.TextChanged += new System.EventHandler(this.parolaTB_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sifreHataLabel
            // 
            this.sifreHataLabel.AutoSize = true;
            this.sifreHataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreHataLabel.ForeColor = System.Drawing.Color.Red;
            this.sifreHataLabel.Location = new System.Drawing.Point(395, 134);
            this.sifreHataLabel.Name = "sifreHataLabel";
            this.sifreHataLabel.Size = new System.Drawing.Size(217, 20);
            this.sifreHataLabel.TabIndex = 6;
            this.sifreHataLabel.Text = "Şifre Hanesi Boş Kalamaz";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(710, 343);
            this.Controls.Add(this.sifreHataLabel);
            this.Controls.Add(this.parolaTB);
            this.Controls.Add(this.hesapNoTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GirisButton);
            this.Controls.Add(this.baslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hesapNoTB;
        private System.Windows.Forms.TextBox parolaTB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label sifreHataLabel;
    }
}

