namespace SquareLib.Models
{
    public abstract class BaseShape
    {
        protected double S { get; set; }

        public abstract double CalculateSquare();
        
    }
}