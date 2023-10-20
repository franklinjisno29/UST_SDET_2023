using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal abstract class Vehicle
    {
        public int Vehiclenum { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? type { get; set; }
        public abstract string? SetTypeForVeh();
        public void Disp()
        {
            Console.WriteLine("Vehicle num: {0} \nBrand: {1} \nModel: {2}", Vehiclenum, Brand, Model);
        }
    }
}
