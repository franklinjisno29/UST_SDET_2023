using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Rectangle : Shape, IDrawable
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        public void Draw()
        {
            Console.WriteLine("Area: {0}\t Perimeter: {1}", CalculateArea(), CalculatePerimeter());
        }
    }
}
