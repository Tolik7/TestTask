using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLib.Models
{   

    public class Rectangle : Triangle
    {
        public double D { get; set; }
        public Rectangle(double a, double b, double c, double d) : base(a, b, c)
        {
            D = d;
        }

        public override double CalculateSquare()
        {
            // Есть формула также - не стал писать так как она длинная
            return S;
        }
    }
}
