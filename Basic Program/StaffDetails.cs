using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class StaffDetails:College
    {
        public int Staffid { get; set; }
        public string? Name { get; set; }
        public string? Dept { get; set; }
        public void DisplayStaffDetails()
        {
            Console.WriteLine("Id: {0} \nName: {1} \nDept: {2}", Staffid, Name, Dept);
        }
    }
}
