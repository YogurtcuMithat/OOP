using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGiris.Models.Oyuncu
{
    internal class Oyuncu
    {
        public string Name { get; set; }
        public string Irk { get; set; }
        public string Brans { get; set; }
        public string Silah { get; set; }
        public int SaldiriGucu { get; set; }

        public int Saldir() 
        {
            SaldiriGucu = 33;
            return SaldiriGucu;
        }

    }
}
