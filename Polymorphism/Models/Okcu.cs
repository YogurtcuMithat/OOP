using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class Okcu:Karakter
    {
        public override void Saldir()
        {
            MessageBox.Show("Ok ile saldır.");
        }
    }
}
