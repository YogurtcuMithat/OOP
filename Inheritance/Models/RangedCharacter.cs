using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class RangedCharacter :Character
    {
        public int Range { get; set; }
        public int RangeDamaged()
        {
            return (Damage * Range) / 4;
        }
    }
}
