using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankacılıkFinal
{
    
    public partial class HesapIslemleriForm : Form
    {
        int pasiflikSuresi;
        string hesapNo;
        Dictionary<string,Musteri> musteriler;
        EFTIslemleri eftIslemleri = new EFTIslemleri();
        Form LoginEkrani;
        string eftHesapNo;
        public HesapIslemleriForm(string hesapNo,Dictionary<string,Musteri>musteriler,Form LoginEkrani)
        {
            InitializeComponent();
            this.hesapNo = hesapNo;
            this.musteriler = musteriler;
            this.LoginEkrani = LoginEkrani;
        }

        private void HesapIslemleriForm_Load(object sender, EventArgs e)
        {
            pasiflikSuresi = 0;
            hosgeldinLbl.Text += " " + musteriler[hesapNo].adSoyad + "...";
            List<string> isimler = new List<string>();
            isimler = eftIslemleri.EftYapilabilecekIsimleriBul(musteriler, hesapNo);
            List<string> kullaniciIBANNumaralari = eftIslemleri.SecilenKisiIbanListele(musteriler, musteriler[hesapNo].adSoyad);
            eftIslemleri.BakiyeleriListele(TLIBANLabel, USDIBANLabel, EUROIBANLabel, musteriler[hesapNo]);
            

            eftMiktariTextBox.Text.Replace('_', '0');
            foreach (string isim in isimler)
            {
                eftIsimComboBox.Items.Add(isim);
            }
            foreach (string IBAN in kullaniciIBANNumaralari)
            {
                eftYapanIbanComboBox.Items.Add(IBAN);
            }
            
            
        }

        private void eftIsimComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            eftIBANComboBox.Items.Clear();
            List<string> IBANNumaralari = eftIslemleri.SecilenKisiIbanListele(musteriler, eftIsimComboBox.Text);
            foreach (string IBANNo in IBANNumaralari)
            {
                eftIBANComboBox.Items.Add(IBANNo);
            }
            pasiflikSuresi = 0;
        }

        private void HesapIslemleriForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginEkrani.Show();
        }

        private void eftYapButton_Click(object sender, EventArgs e)
        {
            
            bool basariliMi = eftIslemleri.EftYap(musteriler[hesapNo], musteriler[eftHesapNo], eftYapanIbanComboBox.Text, eftIBANComboBox.Text, Convert.ToDouble(eftMiktariTextBox.Text));
            if(basariliMi == true)
            {
                eftIslemleri.BakiyeleriListele(TLIBANLabel, USDIBANLabel, EUROIBANLabel, musteriler[hesapNo]);
                MessageBox.Show("EFT İşleminiz Başarıyla Tamamlandı.","Başarılı!!!");
            }
            else
            {
                MessageBox.Show("Bakiyeniz yetersiz!\nEFT İşlemi başarısız.", "Hata!!!");
            }
            pasiflikSuresi = 0;
        }

        private void eftIBANComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            eftHesapNo = eftIslemleri.EftHesapNoBul(eftIBANComboBox.Text);
            pasiflikSuresi = 0;
        }

        private void eftYapanIbanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            paraBirimiLbl.Text = eftIslemleri.IBANParaBirimiOgren(musteriler[hesapNo], eftYapanIbanComboBox.SelectedItem.ToString());
            pasiflikSuresi = 0;
        }

        private void eftMiktariTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            pasiflikSuresi = 0;
        }

        private void hesapTimer_Tick(object sender, EventArgs e)
        {
            pasiflikSuresi += 1;
            if(pasiflikSuresi >= 240)
            {
                guvenlikGroupBox.Visible = true;
                uyariLbl.Visible = true;
                saniyeLbl.Text = (Convert.ToInt32(saniyeLbl.Text) - 1).ToString();
            }
            if(pasiflikSuresi == 300)
            {
                this.Close();
            }
            if (!eftYapanIbanComboBox.SelectedIndex.Equals(-1) && !eftIsimComboBox.SelectedIndex.Equals(-1) && !eftIBANComboBox.SelectedIndex.Equals(-1))
            {
                eftYapButton.Enabled = true;
            }
        }

        private void HesapIslemleriForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void CikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void hosgeldinLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
