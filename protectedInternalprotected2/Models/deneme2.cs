using protectedInternalprotected.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protectedInternalprotected2.Models
{
    internal class deneme2:BaseClass
    {
        public deneme2()
        {
            protectedProperty = 22;
            internalProtectedProperty = 33;
        }
    }
}
