using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal interface IDoctor
    {
        //int DId { get; set; }

        //string? DName { get; set; }
        void ADDNewDoctor(int did, string? dname);
        void ModifyDoctor(int did, string? dname);
    }
}
