using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Student
    {
        //public string? studentname;
        //public int mark1, mark2, mark3;

        //public Student(string? studentname, int mark1, int mark2, int mark3)
        //{
        //    this.studentname = studentname;
        //    this.mark1 = mark1;
        //    this.mark2 = mark2;
        //    this.mark3 = mark3;
        //}
        //public double CalculateAverage()
        //{
        //    double average = (mark1 + mark2 + mark3) / 3;

        //    return average;
        //}

        private string? studentname, grade;
        int[] mark = new int[3];

        public string? Studentname { get => studentname; set => studentname = value; }
        public string? Grade { get => grade; set => grade = value; }
        public int[] Mark { get => mark; set => mark = value; }

        public Student(string? studentname, string? grade, int[] mark)
        {
            Studentname = studentname;
            Grade = grade;
            Mark = mark;
        }

        public double CalculateAverage()
        {
            double average = Mark.Average();
            Console.WriteLine("Average:" + average);

            return average;
        }
        public void DisplayStudents()
        {
            Console.WriteLine("Student Name:" + Studentname);
            Console.WriteLine("Grade:" + grade);
            int i = 1, total=0;
            foreach (int mk in mark)
            {
                Console.WriteLine("Mark {0}:{1}",i, mk);
                i++;
                total += mk;
            }
            Console.WriteLine("Total:" + total);
           
        }
        public void GetMarksSummary()
        {
            int highest = mark[0];
            int lowest = mark[0];
            foreach(int mk in mark)
            {
                if(mk > highest) highest = mk;
                if(mk < lowest) lowest = mk;
            }
            Console.WriteLine("Highest:" + highest);
            Console.WriteLine("Lowest:" + lowest);
        }

    }
}