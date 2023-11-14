using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTransmutations.Exceptions
{
    class ValueOverflowException : Exception
    {
        private const string _valueOverflowMessage = "Wrong symbol(s) was assigned";

        public ValueOverflowException() :
                base(_valueOverflowMessage)
        {

        }
    }
}
