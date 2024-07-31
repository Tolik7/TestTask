namespace SquareLib.Models
{
    public abstract class BaseShape
    {
        protected double S { get; set; }

        protected double SwithF0 { get; set; }
        protected double SwithF1 { get; set; }
        protected double SwithF2 { get; set; }

        protected double newField_2 { get; set; }
        protected double newField_2_2 { get; set; }
        protected double newField_2_3 { get; set; }

        public abstract double CalculateSquare();

        public abstract double CalculateSquareNewMain();

    }
}
