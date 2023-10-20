using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class TeachingStaff:StaffDetails
    {
        public string? Specializations { get; set; }
        public int Sem { get; set; }
        public void DisplayTSDetails()
        {
            Console.WriteLine("Specialization: {0} \nSem: {1}", Specializations, Sem);
        }
    }
}
