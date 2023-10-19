using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedKeyword.Models
{
    public abstract class Boss:Karakter
    {
        public sealed override void Yuru()
        {
            MessageBox.Show("Boss gibi yürüdük");
        }
    }
}
