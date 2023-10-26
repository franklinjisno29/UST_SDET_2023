using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program.ExceptionMessages
{
    internal class MyExceptions
    {
        //public static List<string> exmsglist = new List<string>()
        //{
        //    "Dont give 0 for denom",
        //    "Index out of range",
        //    "unknown exception"
        //};
         public static Dictionary<int, string> exmsglist = new Dictionary<int, string>()
        {
             {0,"Dont give zero for denom" },
             {1,"Index out of range" },
             {2, "unknown exception" },
             {3,"not hundred" },
             {4,"more hundred" }
        };
    }
}
