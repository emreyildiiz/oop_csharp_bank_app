using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankacılıkFinal
{
    class EFTIslemleri
    {
        IOIslemleri ioIslemleri = new IOIslemleri();
        List<String[]> clientSatirlar;
        DovizKurlari<string, double> dovizKurlari = new DovizKurlari<string, double>("EUR->TL",7.9283,"USD->TL",7.1094,"TL->EUR",1/7.9283,"TL->USD",1/7.1094,"TL->TL",1,"EUR->EUR",1,"USD->USD",1);
        
        public List<string> EftYapilabilecekIsimleriBul(Dictionary<string,Musteri>musteriler,string eftYapacakHesapNo)
        {
            List<string> eftYapilacakMusteriler = new List<string>();
            foreach (KeyValuePair<string, Musteri> musteri in musteriler)
            {
                if (!musteri.Key.Equals(eftYapacakHesapNo))
                {
                    eftYapilacakMusteriler.Add(musteri.Value.adSoyad);
                }
            }
            return eftYapilacakMusteriler;
        }
        public List<string> SecilenKisiIbanListele(Dictionary<string, Musteri> musteriler,string adSoyad)
        {
            List<string> IBANNumaralari = new List<string>();
            string arananHesapNo = "";
            foreach (KeyValuePair<string, Musteri> musteri in musteriler)
            {
                if (musteri.Value.adSoyad.Equals(adSoyad))
                {
                    arananHesapNo = musteri.Value.hesapNo;
                }
            }
            clientSatirlar = ioIslemleri.SatirlariOkuBilgileriAyir();
            foreach(String[] satirParcalanmis in clientSatirlar)
            {
                if (satirParcalanmis[0].Equals(arananHesapNo))
                {
                    IBANNumaralari.Add(satirParcalanmis[1]);
                }
            }
            return IBANNumaralari;
        }

        public void BakiyeleriListele(System.Windows.Forms.Control TLLabel,System.Windows.Forms.Control USDLabel,System.Windows.Forms.Control EUROLabel,Musteri musteri)
        {
            clientSatirlar = ioIslemleri.SatirlariOkuBilgileriAyir();
            foreach(String[] satirParcali in clientSatirlar)
            {
                if (satirParcali[0].Equals(musteri.hesapNo))
                {
                    if (satirParcali[1].Equals(musteri.IBANTR))
                    {
                        TLLabel.Text = "Türk Lirası Hesabı:\nIBAN: " + satirParcali[1] + "\nBakiye: " + satirParcali[2]+"TL\n";
                    }
                    else if (satirParcali[1].Equals(musteri.IBANEURO))
                    {
                        EUROLabel.Text = "Euro Hesabı:\nIBAN: " + satirParcali[1] + "\nBakiye: " + satirParcali[2] + "€\n";
                    }
                    else
                    {
                        USDLabel.Text = "Dolar Hesabı:\nIBAN: " + satirParcali[1] + "\nBakiye: " + satirParcali[2] + "$\n";
                    }
                }
            }
        }
        public bool EftYap(Musteri eftYapacakMusteri,Musteri eftYapilacakMusteri,string eftYapanIBAN,string eftYapilacakIBAN,double miktar)
        {
            bool eftBasariliMi = false;
            double bakiye = BakiyeOgren(eftYapanIBAN);
            double bakiyeEftYapilan = BakiyeOgren(eftYapilacakIBAN);
            string gonderilecekParaBirimi = IBANParaBirimiOgren(eftYapacakMusteri, eftYapanIBAN);
            string eftYapilacakParaBirimi = IBANParaBirimiOgren(eftYapilacakMusteri, eftYapilacakIBAN);
            if (bakiye>=miktar)
            {
                
                if (gonderilecekParaBirimi.Equals("EUR") && eftYapilacakParaBirimi.Equals("USD")|| gonderilecekParaBirimi.Equals("USD") && eftYapilacakParaBirimi.Equals("EUR"))
                {
                    string donusum1 = gonderilecekParaBirimi + "->TL";
                    string donusum2 = "TL->" + eftYapilacakParaBirimi;
                    double cevrilmisMiktar = ParaCevir(dovizKurlari[donusum1], miktar, dovizKurlari[donusum2]);
                    string yeniButceEftYapan = (bakiye - miktar).ToString().Replace(',','.');
                    string yeniButceEftYapilan = (bakiyeEftYapilan + cevrilmisMiktar).ToString().Replace(',', '.');
                    ioIslemleri.ButceGuncelle(eftYapanIBAN, bakiye.ToString().Replace(',','.'), yeniButceEftYapan);
                    ioIslemleri.ButceGuncelle(eftYapilacakIBAN, bakiyeEftYapilan.ToString().Replace(',', '.'), yeniButceEftYapilan);
                }
                else
                {
                    string donusum = gonderilecekParaBirimi + "->" + eftYapilacakParaBirimi;
                    double cevrilmisMiktar = ParaCevir(miktar, dovizKurlari[donusum]);
                    string yeniButceEftYapan = (bakiye - miktar).ToString().Replace(',', '.');
                    string yeniButceEftYapilan = (bakiyeEftYapilan + cevrilmisMiktar).ToString().Replace(',', '.');
                    ioIslemleri.ButceGuncelle(eftYapanIBAN, eftYapacakMusteri.hesapNo, yeniButceEftYapan);
                    ioIslemleri.ButceGuncelle(eftYapilacakIBAN, eftYapilacakMusteri.hesapNo, yeniButceEftYapilan);
                }
                eftBasariliMi = true;
            }
            return eftBasariliMi;
            
        }
        private double BakiyeOgren(string eftYapanIBAN)
        {
            double bakiye = 0;
            clientSatirlar = ioIslemleri.SatirlariOkuBilgileriAyir();
            foreach(String[] satirParcalanmis in clientSatirlar)
            {
                string txtIBAN = satirParcalanmis[1];
                
                if (txtIBAN.Equals(eftYapanIBAN))
                {
                    bakiye = Convert.ToDouble(satirParcalanmis[2].Replace('.',','));
                }
            }
            return bakiye;
        }
        public string IBANParaBirimiOgren(Musteri musteri,string IBAN)
        {
            if (IBAN.Equals(musteri.IBANTR))
            {
                return "TL";
            }
            else if (IBAN.Equals(musteri.IBANUSD))
            {
                return "USD";
            }
            else
            {
                return "EUR";
            }
        }
        private double ParaCevir(double miktar,double kur)
        {
            return miktar* kur;
        }
        private double ParaCevir(double tlyeCevrilecek,double miktar,double tldenCevrilecekKur)
        {
            return ParaCevir(ParaCevir(tldenCevrilecekKur, miktar), tldenCevrilecekKur);
        }

        public string EftHesapNoBul(string IBAN)
        {
            string hesapNo = "";
            List<String[]>parcalanmisSatirlar = ioIslemleri.SatirlariOkuBilgileriAyir();
            foreach (String[] parcalanmisSatir in parcalanmisSatirlar)
            {
                if (parcalanmisSatir[1].Equals(IBAN))
                {
                    hesapNo = parcalanmisSatir[0];
                    break;
                }
            }
            return hesapNo;
        }

    }
}
