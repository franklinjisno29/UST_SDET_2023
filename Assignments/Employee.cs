using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public double PerformanceRating { get; set; }

        public static double BonusCalculation(double perfrate)
        {
            double Bonus = perfrate * 100;
            Console.WriteLine("Bonus:");
            return Bonus;
        }
        public static double CalculateBonus(double perfrate)
        {
            double Bonus = perfrate *20* 100;
            Console.WriteLine("Bonus:");
            return Bonus;
        }
    }
}
