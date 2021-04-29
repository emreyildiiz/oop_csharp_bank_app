using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankacılıkFinal
{
    class KullaniciMetodlari
    {
        public Dictionary<string,Musteri> ManuelMusterileriOlustur()//Manuel olarak müşterileri oluşturup client txtsine hesap no iban ve paraları yazar.geriye müşteriler listesini döndürür.
        {
            Dictionary<string,Musteri> musteriler = new Dictionary<string, Musteri>();
            Musteri musteri1 = new Musteri("400129","Kamile Hurşitgiloğulları","TR610008324560000000400129","2980.45");
            musteriler.Add(musteri1.hesapNo,musteri1);
            Musteri musteri2 = new Musteri("326785", "İsmail Borazan", "TR610003200013900000326785","350.0","TR300003200016420000326785","8000.00","EUR");
            musteriler.Add(musteri2.hesapNo,musteri2);
            Musteri musteri3 = new Musteri("388000", "Zebercet Bak", "TR610007222250001200388000", "19150.00", "TR300007222249000001388000", "52.93", "TR300008222266600002388000", "2850.00");
            musteriler.Add(musteri3.hesapNo,musteri3);
            Musteri musteri4 = new Musteri("201005", "Naz Gül Uçan", "TR610032455466661200201005", "666.66", "TR300032455410080003201005", "10000.00","USD");
            musteriler.Add(musteri4.hesapNo,musteri4);
            IOIslemleri ioIslemleri = new IOIslemleri();
            ioIslemleri.MusterileriYazdir(musteriler);
            return musteriler;
        }
    }
}
