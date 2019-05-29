using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Storeble : IStoreable
    {
        IComparable IStoreable.Id {
            get => throw new NotImplementedException();  set => throw new NotImplementedException(); 
        }
    }
}
