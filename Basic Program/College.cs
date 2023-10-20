using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class College
    {
        public int Collegeid { get; set; }
        public string? CollegeName { get; set; }
        public void DisplayCollegeDetails()
        {
            Console.WriteLine("CollegeId: {0} \nCollege Name: {1}", Collegeid, CollegeName);
        }
    }
}
