namespace Shape.Logic
{
    using System;


    public abstract class Shape
    {
        protected double width;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        protected double height;

        public double Height
        {
            get { return height; }
            set
            {
                if (Height <= 0)
                {
                    throw new ApplicationException("Enter positiv value for Height");
                }
                height = value;
            }
        }
        public abstract double CalculateSurface();

        public Shape(double height)
        {
            this.height = height;
        }
        public Shape(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

    }
}
