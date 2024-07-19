using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLib.Models
{   
    public class Triangle : BaseShape
    {        
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(double a, double b, double c)
        {
            A = a;  B = b; C = c;  
        }

        public List<double>? isRectangular() {

            var list = new List<double>
            {
                A,
                B,
                C
            };

            list.OrderByDescending(q => q);

            var _c = list[0]; // Max side 
            var _a = list[1]; // Other 1 side
            var _b = list[2]; // Other 2 side

            if (Math.Pow(_c, 2) == Math.Pow(_a, 2) + Math.Pow(_b, 2))
                return list;
            else
                return null;
        
        }

        public override double CalculateSquare()
        {
            var orderedSides = this.isRectangular();
            
            if (orderedSides != null)
            {
                // Взять только катеты!
                S = orderedSides[1] * orderedSides[2] / 2;
                
            }
            else
            {
                // формула Герона 
                double P2 = (A + B + C) / 2;

                S = Math.Sqrt(P2 * (P2 - A) * (P2 - B) * (P2 - C));
            }

            return S;

        }
    }
}
