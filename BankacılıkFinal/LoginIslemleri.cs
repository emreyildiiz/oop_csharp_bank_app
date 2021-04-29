using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;

namespace BankacılıkFinal
{
    public class LoginIslemleri
    {
        private Dictionary<string,string> KayitliKullanicilariOku()
        {
            Dictionary<string, string> hesapNoParolaDict = new Dictionary<string, string>();
            StreamReader streamReader = new StreamReader("C:\\final\\auth.txt");
            string satir;
            while ((satir = streamReader.ReadLine()) != null)
            {
                String[] satirBolunmus = satir.Split(',');
                hesapNoParolaDict.Add(satirBolunmus[0], satirBolunmus[1]);
            }
            return hesapNoParolaDict;
        }
        public bool GirisKontrol(string hesapNo,string parola)
        {
            
            bool basariliMi = false;
            Dictionary<string, string> kayitliKullanicilar = KayitliKullanicilariOku();
            string sifrelenmisParola = SHA256Sifrele(parola); 
            if (sifrelenmisParola.Equals(kayitliKullanicilar[hesapNo]))
            {
                basariliMi = true;
            }
            return basariliMi;
        }
        public string SHA256Sifrele(string parola)
        {
            SHA256 sha256 = new SHA256CryptoServiceProvider();
            string sifrelenmisParola = BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(parola)));
            sifrelenmisParola = sifrelenmisParola.Replace("-", "").ToLower();
            return sifrelenmisParola;
        }
    }
}
