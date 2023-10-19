using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGiris.Models.AccessModifiers
{
    public class Plane//internal class Plane
    {
        public string Pilot { get; set; }
        internal string Model { get; set; }
        private void Uc()
        {
            MessageBox.Show("Uçuyoruz.");
        }
    }
}
