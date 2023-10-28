using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study.Exception
{
    internal class Myexceptionss
    {
        public class OrderException : IOException
        {
            public OrderException(string message) : base(message) { }
        }
    }
}
