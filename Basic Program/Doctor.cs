using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Doctor:Calculation,IDoctor, IAppoinment
    {
        public int DId { get; set; }

        public string? DName { get; set; }

        public void ADDNewDoctor(int did, string? dname)
        {
            DId = did;  DName = dname;
        }

        public void BookApp(int did, string pname)
        {
            Console.WriteLine("Booked app for {0} with Doctor {1}", pname, did);
        }

        public void DelApp(string pname)
        {
            Console.WriteLine("Cancelled app for {0}",pname);
        }

        public void DisplayDoctor()
        {
            Console.WriteLine("DId: {0} \nDName: {1}", DId, DName);
        }

        public void ModifyDoctor(int did, string? dname)
        {
            DId = did; DName = dname;
        }
    }
}
