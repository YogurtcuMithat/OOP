using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstaction.Models.Araba
{
    public abstract class Tasit
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yıl { get; set; }

    }
}
