using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructor.Models
{
    internal class BaseClass
    {
        public string Name { get; set; }
        public DateTime KayitTarihi { get; set; }
        private string Deneme { get; set; }
        protected BaseClass()
        {
            KayitTarihi=DateTime.Now;
        }
    }
}
