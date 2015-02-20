using System;

internal class CirclePerimeter
{
    private static void Main()
    {
        /*Problem 3. Circle Perimeter and Area
         *
         * Write a program that reads the radius r of a circle and prints its perimeter
         * and area formatted with 2 digits after the decimal point.
         *
         */
        Console.WriteLine("Wecom to the program that calculates Area and Perimeter of a Circle");
        Console.WriteLine("-----------------------------------------------------");
        Console.Write("\n");
        Console.WriteLine("Pleace enter the  radius of the Circle");
        string radius = Console.ReadLine();
        double numberR;
        bool isNumberR = double.TryParse(radius, out numberR);

        //initialization

        double Pi = Math.PI;

        string roundPi = String.Format("{0:0.000}", Pi);
        //Validationg the numbers
        if (isNumberR)
        {
            //calculating the PERIMETER  and PERIMETER of the numbers
            double piConverted = double.Parse(roundPi);
            double perimeterCircle = 2 * piConverted * numberR;
            //calculating the AREA  and PERIMETER of the numbers
            double areaCircle = numberR * numberR * piConverted;

            Console.WriteLine("The PERIMETER of the CIRCLE is {0} ", perimeterCircle);
            Console.WriteLine("The AREA of the CIRCLE is {0} ", areaCircle);
            Console.WriteLine("Thank you for using the software have a nice Day :)");
        }
        else
        {
            Console.WriteLine("You put wrong niumber . Pleas put  an integer ");
        }
    }
}