
namespace Shape.Logic
{
    using System;

    public class Circle : Shape
    {
        private const double Pi = Math.PI;

        public Circle(double height, double width)
            : base(height, width)
        {
            if (height != width)
            {
                throw new ApplicationException("There is no Circle with height!=width = Make them  equal !!");
            }
        }

        public override double CalculateSurface()
        {
            return Pi * Height * Height;
        }

        public override string ToString()
        {
            return this.GetType().Name + "\n" + "Radius =" + this.Height;
        }
    }
}
