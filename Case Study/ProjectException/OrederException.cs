using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study.ProjectException
{
    internal class OrederException : Exception
    {
        public OrederException(string message) :base(message)
        {
        }
    }
}
