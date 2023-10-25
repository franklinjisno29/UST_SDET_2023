using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class BankDetails
    {
        public BankDetails(int custid, long accNo, string? name, string? status)
        {
            Custid = custid;
            AccNo = accNo;
            Name = name;
            Status = status;
        }

        public int Custid { get; set; }
        public long AccNo { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
        /* public static void WelcomeMessage()
         {
             Console.WriteLine("welcome !!");
         }*/
        public /*override*/ virtual void WelcomeMessage()
        {
            Console.WriteLine("wlcome !!");
        }
        public void ExitMessage()
        {
            Console.WriteLine("done");
        }
        public void GetAccDetails(int custid)
        {
            if (Custid == custid)
                Console.WriteLine("Acc No: {0}\t Name: {1}\t Status: {2}", AccNo, Name, Status);
            else { Console.WriteLine("Acc No Doesn't exist"); }
        }
        public void GetAccDetails(long accno)
        {
            if (AccNo == accno)
                Console.WriteLine("Acc No: {0}\t Name: {1}\t Status: {2}", AccNo, Name, Status);
            else { Console.WriteLine("Acc No Doesn't exist"); }
        }
        public void GetAccDetails(string? name)
        {
            if (Name == name)
                Console.WriteLine("Acc No: {0}\t Name: {1}\t Status: {2}", AccNo, Name, Status);
            else { Console.WriteLine("Acc No Doesn't exist"); }
        }
    }
}
