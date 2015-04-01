namespace shape
{
    using System;
    using System.Collections.Generic;
    using Shape.Logic;


    class ShapeTest
    {
        static void Main(string[] args)
        {
            var shape = new List<Shape>
            {
                new Triangle(23,13),
                new Circle(23,23),
                new Rectungle(21,13)
            };

            foreach (var shape1 in shape)
            {

                Console.WriteLine("Shape of {0}" + "\nS={1} cm", shape1.ToString(), shape1.CalculateSurface());
                Console.WriteLine("\n---------------------------------------");
            }
            Console.ReadLine();
        }
    }
}
