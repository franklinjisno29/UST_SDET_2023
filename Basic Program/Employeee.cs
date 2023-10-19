using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Employeee
    {
        private int eid;
        private string? ename, department;
        private double basicpay;
        private readonly int _bonus = 10;

        public Employeee(int eid, string? ename, string? department, double basicpay)
        {
            Eid = eid;
            Ename = ename;
            Department = department;
            Basicpay = basicpay;
        }

        public int Eid { get => eid; set => eid = value; }
        public string? Ename { get => ename; set => ename = value; }
        public string? Department { get => department; set => department = value; }
        public double Basicpay { get => basicpay; set => basicpay = value; }

        public int Bonus => _bonus;

        public double CalculateSalary()
        {
            double grosssalary, netsalary,
                deductions = (Basicpay * 0.1),
                allowances = (Basicpay * 0.3) + (Basicpay * 0.2) + (Basicpay * 0.15);
            grosssalary = Basicpay + allowances;
            netsalary = grosssalary - deductions;
            return netsalary;
        }
    }
}
