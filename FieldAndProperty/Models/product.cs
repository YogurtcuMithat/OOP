using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldAndProperty.Models
{
    internal class product
    {
        int _c;
        public int MyProperty 
        { 
            get
            {
                return _c;
            }
            set
            {
                _c= value;
            }
        }
        public product()
        {
            _c = 23;

            var b = MyProperty;
        }
    }
}
