using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class StudentDetails :College
    {
        //public StudentDetails(int rollNo, string? studentName, string? city)
        //{
        //    RollNo = rollNo;
        //    StudentName = studentName;
        //    City = city;
        //}

        public int RollNo { get; set; }
        public string? StudentName { get; set; }
        public string? City { get; set; }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("Roll No: {0} \nName: {1} \nCity: {2}",RollNo,StudentName,City);
        }
    }
}
