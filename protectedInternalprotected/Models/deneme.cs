using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protectedInternalprotected.Models
{
    public class Deneme:BaseClass
    {
        public Deneme() 
        {
            internalProtectedProperty = 23;
            protectedProperty = 23;
        }
    }
}
