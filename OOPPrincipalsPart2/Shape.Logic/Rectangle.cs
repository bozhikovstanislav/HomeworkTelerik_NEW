namespace Shape.Logic
{
    using System;


    public class Rectungle : Shape
    {
        public Rectungle(double height, double width)
            : base(height, width)
        {

        }

        public override double CalculateSurface()
        {
            return Height * Width;
        }
        public override string ToString()
        {
            return this.GetType().Name + "\n" + "Height =" + Height + " " + "Widht =" + Width;
        }
    }
}
