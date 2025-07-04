using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class MyOwnException : Exception
    {
        public MyOwnException(string message) : base(message)
        {
            
        }
    }
}
