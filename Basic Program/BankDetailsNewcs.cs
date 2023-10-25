using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class BankDetailsNewcs : BankDetails
    {
        public BankDetailsNewcs(int custid, long accNo, string? name, string? status) : base(custid, accNo, name, status)
        {
        }
        public override void WelcomeMessage()
        {
            Console.WriteLine("welcome {0} !!", Name);
        }
    }
}
