using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Exceptions
{
    internal class MyException
    {
        public static Dictionary<int, string> exmlist = new Dictionary<int, string>()
        {
             {0,"patient name and diagnosis should not be null" },
             {1,"Treatment cost should be positive" }
        };
    }
    public class InvalidPatientDataException : Exception
    {
        public InvalidPatientDataException(string msg) : base(msg)
        {

        }
    }
    public class InvalidMedicalRecordException : Exception
    {
        public InvalidMedicalRecordException(string msg) : base(msg)
        {

        }
    }
}
