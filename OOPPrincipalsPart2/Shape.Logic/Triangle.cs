namespace Shape.Logic
{
    using System;

    public class Triangle : Shape
    {
        public Triangle(double height, double width)
            : base(height, width)
        {

        }

        public override double CalculateSurface()
        {
            return Height * Width / 2;
        }
        public override string ToString()
        {
            return this.GetType().Name + "\n" + "Height =" + Height + " " + "Widht =" + Width;
        }
    }
}
