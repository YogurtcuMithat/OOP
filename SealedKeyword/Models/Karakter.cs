using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedKeyword.Models
{
    public class Karakter
    {
        public string Name { get; set; }
        public virtual void Yuru()
        {
            MessageBox.Show("Normal yürüdü");
        }
    }
}
