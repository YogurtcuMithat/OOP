using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public abstract class Karakter
    {
        public virtual void Saldir()
        {
            MessageBox.Show("saldırıldı");
        }
    }
}
