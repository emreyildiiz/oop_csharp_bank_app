using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankacılıkFinal
{
    class IOIslemleri
    {
        string clientPath = "C:\\final\\client.txt";
        public void MusterileriYazdir(Dictionary<string,Musteri> musteriler)
        {
            StreamWriter streamWriter = new StreamWriter("C:\\final\\client.txt");
            streamWriter.Flush();
            streamWriter.Close();

            foreach (KeyValuePair<string, Musteri> musteri in musteriler)
            {
                musteri.Value.TxtYazdir();
            }
        }
        public List<String[]> SatirlariOkuBilgileriAyir()
        {
            List<String[]> parcalanmisSatirlar = new List<string[]>();
            StreamReader streamReader = new StreamReader(clientPath);
            string satir = "";
            while((satir = streamReader.ReadLine()) != null)
            {
                String[] bolunmusSatir = satir.Split(',');
                parcalanmisSatirlar.Add(bolunmusSatir);
            }
            streamReader.Close();
            return parcalanmisSatirlar;
        }

        public void ButceGuncelle(string IBAN,string musteriNO,string yeniButce)
        {
            string text = File.ReadAllText(clientPath);
            String[] satirlaraBolunmus = text.Split('\n');
            string yeniText = "";
            for (int i = 0; i < satirlaraBolunmus.Length; i++)
            {
                if (satirlaraBolunmus[i].Contains(IBAN))
                {
                    satirlaraBolunmus[i] = musteriNO + "," + IBAN + "," + yeniButce;
                    if (i != satirlaraBolunmus.Length - 1)
                    {
                        satirlaraBolunmus[i]+="\r";
                    }
                }
                if(i != satirlaraBolunmus.Length - 1)
                {
                    yeniText += satirlaraBolunmus[i] + '\n';
                }
                
            }
            Console.WriteLine(yeniText);
            File.WriteAllText(clientPath, yeniText);
        }
    }
}
