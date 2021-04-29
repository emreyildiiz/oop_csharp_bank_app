using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankacılıkFinal
{
    
    public partial class LoginForm : Form
    {
        
        private LoginIslemleri loginIslemleri;
        private int gecenSure;
        
        Dictionary<string,Musteri> musteriler;
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void parolaTB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(parolaTB.Text))
            {
                sifreHataLabel.Visible = true;
                GirisButton.Enabled = false;
            }
            else
            {
                sifreHataLabel.Visible = false;
                GirisButton.Enabled = true;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(parolaTB.Text, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"))
            {
                MessageBox.Show("Şifre özel karakter içeremez.", "Hata!!!");
                parolaTB.Text = parolaTB.Text.Remove(parolaTB.Text.Length - 1);
            }
        }

        private void hesapNoTB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(hesapNoTB.Text,"[^0-9]"))
            {
                hesapNoTB.Text = hesapNoTB.Text.Remove(hesapNoTB.Text.Length - 1);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            loginIslemleri = new LoginIslemleri();
            hesapNoTB.MaxLength = 6;
            parolaTB.MaxLength = 8;
            KullaniciMetodlari kullaniciMetodlari = new KullaniciMetodlari();
            musteriler = kullaniciMetodlari.ManuelMusterileriOlustur();
            timer1.Start();
        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (musteriler[hesapNoTB.Text].kisitliMi != true)
                {
                    bool girisBasarilimi = loginIslemleri.GirisKontrol(hesapNoTB.Text, parolaTB.Text);
                    if (girisBasarilimi == true)
                    {
                        HesapIslemleriForm hesapIslemleriForm = new HesapIslemleriForm(hesapNoTB.Text, musteriler,this);
                        hesapIslemleriForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        musteriler[hesapNoTB.Text].girisDenemesi -= 1;
                        MessageBox.Show("Şifreniz hatalı.\n Kalan Deneme:" + musteriler[hesapNoTB.Text].girisDenemesi, "HATA!!!");
                        if(musteriler[hesapNoTB.Text].girisDenemesi == 0)
                        {
                            musteriler[hesapNoTB.Text].kisitliMi = true;
                            musteriler[hesapNoTB.Text].kisitTarihi = DateTime.Now + new TimeSpan(24, 0, 0);
                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bu kullanıcının giriş hakkı doldu.\nKısıtın Açılmasına Kalan Sure: "+musteriler[hesapNoTB.Text].kalanSure.Hours+":"+musteriler[hesapNoTB.Text].kalanSure.Minutes+":"+musteriler[hesapNoTB.Text].kalanSure.Seconds, "HATA!!!");
                }
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                MessageBox.Show("Bu kullanıcı sisteme kayıtlı değil.","HATA!!!");
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gecenSure += 1;
            foreach (KeyValuePair<string, Musteri> musteri in musteriler)
            {
                if(musteri.Value.kisitliMi == true)
                {
                    musteri.Value.kalanSure = musteri.Value.kisitTarihi - DateTime.Now;
                }
                if (musteri.Value.kalanSure.TotalSeconds < 1)
                {
                    musteri.Value.kisitliMi = false;
                }    
            }
            if (gecenSure > 300)
            {
                foreach (KeyValuePair<string, Musteri> musteri in musteriler)
                {
                    if(musteri.Value.kisitliMi!= true)
                    {
                        musteri.Value.girisDenemesi = 3;
                    }
                }
                gecenSure = 0;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
