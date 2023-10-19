using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR.Model
{
    internal class Futbolcu
    {
        public string Isim { get; set; }
        public string Ulke { get; set; }
        public int SutGucu { get; set; }
        public Futbolcu(string isim, string ulke)
        {
            Isim = isim;
            Ulke = ulke;
            int adUzunlugu = Isim.Length;
            int ulkeUzunluğu = Ulke.Length;
            if (25 < (adUzunlugu * ulkeUzunluğu / 2))
            {
                SutGucu = 30;
            }              
            else
                SutGucu = 15;
        }
    }
}
