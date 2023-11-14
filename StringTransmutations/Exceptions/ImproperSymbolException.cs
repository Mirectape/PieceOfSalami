using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTransmutations.Exceptions
{
    public class ImproperSymbolException : Exception
    {
        private const string _improperSymbolMessage = "Wrong symbol(s) was assigned";

        public ImproperSymbolException() :
                base(_improperSymbolMessage)
        {

        }
    }
}
