using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class NonTeachingStaff:StaffDetails
    {
        public string? Responsibilities { get; set; }
        public int Experience { get; set; }
        public void DisplayNTSDetails()
        {
            Console.WriteLine("Responsibilities: {0} \nExperience: {1}", Responsibilities, Experience);
        }
    }
}
