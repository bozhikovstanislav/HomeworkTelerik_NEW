using System;

namespace PointInaCircle
{      
    class PointInASircle
    {
       
        static void Main()
        {
            ///Point in a Circle
                //Write an expression that checks if given point
                //(x, y) is inside a circle K({0, 0}, 2).
            ///

            //Equeation that have to be true is ((x-j)^2 + (y-k)^2 = r^2).
            // in our case j=0;k=0; r=2


            Console.WriteLine("Welcom to the program that checks if a given point is in the circle");

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Enter the point coordinat");

            Console.WriteLine("Enter a value for X1 ");
            string x1Entered = Console.ReadLine();
            Console.WriteLine("Enter a value for Y1 ");
            string y1Entered = Console.ReadLine();

            //Entering the radius of the circle
            Console.WriteLine("Enter a radius of the circle");
            string radius= Console.ReadLine();
            //Validation of the the input data
            double x1;
            double y1;
            double r;
            bool isNumberX1 = double.TryParse(x1Entered, out x1);
            bool isNumberY1 = double.TryParse(y1Entered, out y1);
            bool isRadius = double.TryParse(radius, out r);
            if (isNumberX1 && isNumberY1 && isRadius)
            {
                //enterCordinat.x = x1;
                //enterCordinat.y = y1;

                //Temporary R radius
                double  rTemp = Math.Sqrt((Math.Pow(x1, 2)) + Math.Pow(y1, 2));
               
                //Condition when the point is in the circle
                if(rTemp<=r)
                {
                    Console.WriteLine("The point with cordinats ({0},{1}) is IN the Circle with Radius r={2}",x1,y1,r);
                }
                else
                {
                    Console.WriteLine("The point with cordinats ({0},{1}) is NOT IN  the Circle with Radius r={2}", x1, y1, r);
                }
   
            }
            else
            {
                Console.WriteLine("You did not put coordinat - Please put an integr value for x and y");
            }

            Console.ReadLine();
            


           





        }
    }
}
