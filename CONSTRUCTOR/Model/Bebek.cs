using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR.Model
{
    internal class Bebek
    {
        public int Ay { get; set; }
        public string Cinsiyet { get; set; }
        public double Kilo { get; set; }
        public Bebek(int Ay, string Cinsiyet, double Kilo=0)
        {
            this.Ay = Ay;
            this.Cinsiyet = Cinsiyet;
            this.Kilo = Kilo;
        }
    }
}
