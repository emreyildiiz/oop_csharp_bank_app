using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankacılıkFinal
{
    public abstract class GenelBilgi
    {
        public string hesapNo;
        public string adSoyad;
        public string IBANTR;
        public string miktarIBANTR;
        public int girisDenemesi;
        public bool kisitliMi;
        public DateTime kisitTarihi;
        public TimeSpan kalanSure;
        public abstract void TxtYazdir();
    }
}
