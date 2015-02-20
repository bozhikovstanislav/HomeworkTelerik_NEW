using System;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            ///Problem 9 Trapezoids
            //Write an expression that calculates trapezoid's 
            //area by given sides a and b and height h.
            ///
            Console.WriteLine("Welcom to the program that make a calculation of Trapezoid Area");
            Console.WriteLine("_____________________________________________________________________________");
            
            Console.WriteLine("Enter the 'a' side of the trapezoid");
            string aSide = Console.ReadLine();
            Console.WriteLine("Enter the 'b' side of the trapezoid");
            string bSide = Console.ReadLine();
            Console.WriteLine("Enter the 'h'  of the trapezoid");
            string hSide = Console.ReadLine();

            //verification of the input value....
            ulong aSideTrapezoid;
            ulong bSideTrapezoid;
            ulong hSideTrapezoid;
            bool isAsideNumber = ulong.TryParse(aSide, out aSideTrapezoid);
            bool isBsideNumber = ulong.TryParse(bSide, out bSideTrapezoid);
            bool ishsideNumber = ulong.TryParse(bSide, out hSideTrapezoid);
            if ((isAsideNumber && isBsideNumber) && ishsideNumber)
            {
               //Trapezid area S=((a+b)/2)*h

                ulong trapezoidArea = ((aSideTrapezoid + bSideTrapezoid) / 2) * hSideTrapezoid;
                Console.WriteLine("The area of the Trapezoid with a={0};b={1};h={2} is AREA = {3}", aSideTrapezoid, bSideTrapezoid, hSideTrapezoid, trapezoidArea);
                Console.WriteLine("Thank you for using the software . Have a nice Day :)");
            }
            else
            {
                Console.WriteLine("You put wrong niumber . Pleas put  an DIGIT ");
            }

            Console.ReadLine();

        }
    }
}
