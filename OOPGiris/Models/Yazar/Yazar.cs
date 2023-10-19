using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGiris.Models.Yazar
{
    internal class Yazar
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void Yaz(string bookName)
        {
            MessageBox.Show($"{bookName} kitabı {Name} {Surname} kişi tarafından yazıldı");
        }
    }
}
