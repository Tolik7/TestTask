namespace SquareLib.Models
{
    public abstract class BaseShape
    {
        protected double __S { get; set; }
        protected double S { get; set; }

        protected double SwithF1 { get; set; }
        protected double SwithF2 { get; set; }


        public abstract double CalculateSquare();

        public abstract double CalculateSquareNewMain();

    }
}