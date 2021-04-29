using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BankacılıkFinal
{
    public class Musteri : GenelBilgi,IEuro,IUSD
    {
        public string IBANUSD { get ; set; }
        public string miktarIBANUSD { get ; set ; }
        public string IBANEURO { get ; set; }
        public string miktarIBANEURO { get ; set ; }

        public Musteri(string hesapNO,string adSoyad,string IBANTR,string miktarIBANTR)
        {
            this.hesapNo = hesapNO;
            this.adSoyad = adSoyad;
            this.IBANTR = IBANTR;
            this.miktarIBANTR = miktarIBANTR;
            this.miktarIBANUSD = null;
            this.miktarIBANEURO = null;
            this.IBANEURO = null;
            this.IBANUSD = null;
            this.girisDenemesi = 3;
            this.kisitliMi = false;
            this.kisitTarihi = new DateTime(2040, 1, 1, 1, 1, 1);
        }
        public Musteri(string hesapNo, string adSoyad, string IBANTR, string miktarIBANTR, string IBANikinci, string miktarIBANikinci,string euromuDolar)
        {
            this.hesapNo = hesapNo;
            this.adSoyad = adSoyad;
            this.IBANTR = IBANTR;
            this.miktarIBANTR = miktarIBANTR;
            if (euromuDolar.Equals("USD"))
            {
                this.IBANUSD = IBANikinci;
                this.miktarIBANUSD = miktarIBANikinci;
                this.miktarIBANEURO = null;
                this.IBANEURO = null;
            }
            else
            {
                this.IBANEURO = IBANikinci;
                this.miktarIBANEURO = miktarIBANikinci;
                this.IBANUSD = null;
                this.miktarIBANUSD = null;

            }
            this.kisitliMi = false;
            this.girisDenemesi = 3;
            this.kisitTarihi = new DateTime(2040, 1, 1, 1, 1, 1);
        }
        public Musteri(string hesapNO, string adSoyad, string IBANTR, string miktarIBANTR, string IBANEURO, string miktarIBANEURO, string IBANUSD, string miktarIBANUSD)
        {
            this.hesapNo = hesapNO;
            this.adSoyad = adSoyad;
            this.IBANTR = IBANTR;
            this.miktarIBANTR = miktarIBANTR;
            this.IBANEURO = IBANEURO;
            this.miktarIBANEURO = miktarIBANEURO;
            this.IBANUSD = IBANUSD;
            this.miktarIBANUSD = miktarIBANUSD;
            this.girisDenemesi = 3;
            this.kisitliMi = false;
            this.kisitTarihi = new DateTime(2040, 1, 1, 1, 1, 1);
        }

        public Musteri()
        {

        }
        public override void TxtYazdir()
        {
            if (!File.Exists("C:\\final\\client.txt"))
            {
                StreamWriter streamWriter = new StreamWriter("C:\\final\\client.txt");
                string yazdirilacak = hesapNo + "," + IBANTR + "," + miktarIBANTR;
                streamWriter.WriteLine(yazdirilacak);
                if (this.miktarIBANEURO != null)
                {
                    yazdirilacak = hesapNo + "," + IBANEURO + "," + miktarIBANEURO;
                    streamWriter.WriteLine(yazdirilacak);
                }
                if (this.miktarIBANUSD != null)
                {
                    yazdirilacak = hesapNo + "," + IBANUSD + "," + miktarIBANUSD;
                    streamWriter.WriteLine(yazdirilacak);
                }
                streamWriter.Flush();
                streamWriter.Close();
            }
            else
            {
                StreamWriter streamWriter = File.AppendText("C:\\final\\client.txt");
                string yazdirilacak = hesapNo + "," + IBANTR + "," + miktarIBANTR;
                streamWriter.WriteLine(yazdirilacak);
                if ((this.miktarIBANEURO != null))
                {
                    yazdirilacak = hesapNo + "," + IBANEURO + "," + miktarIBANEURO;
                    streamWriter.WriteLine(yazdirilacak);
                }
                if ((this.miktarIBANUSD != null))
                {
                    yazdirilacak = hesapNo + "," + IBANUSD + "," + miktarIBANUSD;
                    streamWriter.WriteLine(yazdirilacak);
                }
                streamWriter.Flush();
                streamWriter.Close();
            }
            
            
        }
    }
}
