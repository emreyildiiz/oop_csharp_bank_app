using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.CompilerServices;

namespace BankacılıkFinal
{
    class DovizKurlari<Donusum,Deger>:Dictionary<Donusum,Deger>
    {
        public DovizKurlari(Donusum donusum1,Deger deger1,Donusum donusum2,Deger deger2,Donusum donusum3,Deger deger3,Donusum donusum4,Deger deger4,Donusum donusum5,Deger deger5,Donusum donusum6,Deger deger6,Donusum donusum7,Deger deger7)
        {
            this.Add(donusum1, deger1);
            this.Add(donusum2, deger2);
            this.Add(donusum3, deger3);
            this.Add(donusum4, deger4);
            this.Add(donusum5, deger5);
            this.Add(donusum6, deger6);
            this.Add(donusum7, deger7);
        }
        
    }
}
