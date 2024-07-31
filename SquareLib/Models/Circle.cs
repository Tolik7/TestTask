using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLib.Models
{
    public class Circle : BaseShape
    {
        const double PI = 3.14;

        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateSquare()
        {
            S = PI * Math.Pow(Radius, 2);
            
            return S;
        }

        public override double CalculateSquareNewMain()
        {
            throw new NotImplementedException();
        }
    }   


}
