using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Wizard : Character
    {
        public Wizard()
        {
            Damage = 4;
        }
        public int Magic()
        {
            return Damage*3 ;
        }
    }
}
