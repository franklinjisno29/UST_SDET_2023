using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQEx
{
    internal class Linqex
    {
        public void example1()
        {
            List<string> courses = new List<string>();
            courses.Add("C Tutorial");
            courses.Add("C++ Tutorial");
            courses.Add("java Tutorial");
            courses.Add("Web Tech");
            courses.Add("DBMS");
            courses.Add("UI Exp");
            var res = from c in courses where c.Contains("Tutorial") select c; //query syntax
            var res1 = courses.Where(c => c.Contains("C")); //method syntax
            foreach (var c in res)
            {
                Console.WriteLine(c);
            }
            foreach (var r in res1)
            {
                Console.WriteLine(r);
            }
        }
        public void example2()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "AA", "SS"));
            students.Add(new Student(2, "BB", "TT"));
            students.Add(new Student(3, "CC", "SS"));
            students.Add(new Student(4, "DD", "VV"));
            students.Add(new Student(5, "EE", "SS"));

            var stud = students.Where(s => s.Id == 3);
            foreach (var r in stud)
            {
                Console.WriteLine(r.Id + "\t" + r.Name + "\t" + r.Dept);
            }
            Student? stud1 = students.FirstOrDefault(s => s.Name == "AA");
            if (stud1 != null)
            {
                Console.WriteLine(stud1.Id + "\t" + stud1.Name + "\t" + stud1.Dept);
            }
            else
            {
                Console.WriteLine("not found");
            }

            List<Student> stud2 = students.FindAll(s => s.Dept == "SS" || s.Name == "BB");
            foreach (var r in stud2)
            {
                Console.WriteLine(r.Id + "\t" + r.Name + "\t" + r.Dept);
            }
        }
        public void FilteringType()
        {
            ArrayList elements = new()
            {
                1,
                "Two",
                3,
                4,
                "Five"
            };
            var numbers = elements.OfType<int>();
            var strings = elements.OfType<string>();
            foreach (var s in numbers) { Console.WriteLine("integers:" + s); }
            foreach (var r in strings) { Console.WriteLine("string:" + r); }
        }
        public void SortStudent()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "AA", "SS"));
            students.Add(new Student(2, "BB", "TT"));
            students.Add(new Student(3, "CC", "SS"));
            students.Add(new Student(4, "AA", "VV"));
            students.Add(new Student(5, "EE", "SS"));
            IEnumerable<Student> stud = students.OrderBy(s=>s.Name).ThenBy(s=>s.Dept);
            foreach (var r in stud)
            {
                Console.WriteLine(r.Id + "\t" + r.Name + "\t" + r.Dept);
            }
            var stud1 = students.ToLookup(s=>s.Name);
            foreach(var s in stud1)
            {
                Console.WriteLine(s.Key);
                foreach(var c in s)
                {
                    Console.WriteLine(c.Id + "\t" + c.Name + "\t" + c.Dept);
                }

            }
        }
    }
}
