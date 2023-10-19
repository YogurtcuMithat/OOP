using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protectedInternalprotected.Models
{
    public abstract class BaseClass
    {
        protected int protectedProperty { get; set; }
        internal protected int internalProtectedProperty { get; set; }
    }
}
