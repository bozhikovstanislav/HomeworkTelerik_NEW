using System;


namespace PointCercleRecangle
{
    class PointCercleRectangle
    {


        public struct PointStruct
        {
            public double x,y;
            public PointStruct(double x1,double y1)
            {
                this.x=x1;
                this.y=y1;
            }
        }
        static void Main()
        {

            /*Problem 10 Point Inside a Circle & Outside of a Rectangle
             * 
                            Write an expression that checks for given point (x, y) if 
                            it is within the circle K({1, 1}, 1.5) and out of 
                            the rectangle R(top=1, left=-1, width=6, height=2).
             * 
            */
            /* There is a Quarter-Circle with a r=1.5 which intersect the rectangle.
             * The Area of this Quarter-Circle is given by Area=(Pi*r^2)/4;
             * The area of the rectangle is areaRectangle=width*hight;
             * 
             * and r^2=x^2+y^2
             * so the condition will be  
             * the distance d=SQRT((center_x1-x)^2+(cenetr_y-y1)^2)
             * and if the distance d<=r the point will be in the circle.
             * so insted of distance we calculate the area of the segment with th
             * 
             * The condition in witch a point will be in inside the circle and outside of the rectangle will be
             * if the point is ouside of the segment . 
             * 
             * 
             */

            //Creating the points of the Recangle.
            PointStruct centerRectangle = new PointStruct(1, -1);// 
            PointStruct endDownRectangle = new PointStruct(1, 2);
            PointStruct endRightRectangle = new PointStruct(6, 1);
            //Start angle of the sector is 90;
            //End Angle of the sector is 180;


            //Points of the sector
            PointStruct centerCircle = new PointStruct(1, 1);
            PointStruct downSector = new PointStruct(1,1.5);
            Console.WriteLine("Welcom to the program that checks if a given point is in the circle and out of \n recanle");

            Console.WriteLine("*************************************************************************");
    
            Console.WriteLine("Enter the point coordinat");

            Console.WriteLine("Enter a value for X1 ");
            string x1Entered = Console.ReadLine();
            Console.WriteLine("Enter a value for Y1 ");
            string y1Entered = Console.ReadLine();
            //Validation of the the input data
            double x1;
            double y1;
            double r=1.5;
            bool isNumberX1 = double.TryParse(x1Entered, out x1);
            bool isNumberY1 = double.TryParse(y1Entered, out y1);
          
            if (isNumberX1 && isNumberY1 )
            {
                //enterCordinat.x = x1;
                //enterCordinat.y = y1;

                //Temporary R radius
                double rTemp = Math.Sqrt((Math.Pow(centerCircle.x-x1, 2)) + Math.Pow(centerCircle.y-y1, 2));

                double angleTemp = Math.Tanh((y1 / x1));

                //Defining the sector in polar coordinats
                double angleSectorStart = Math.Tanh((1 / 2.5));

                double angleSectorEnd = Math.Tanh((1 / -0.5));

                //Condition when the point is in the circle
                if (rTemp <= r && (angleTemp>angleSectorStart   &&  angleTemp>angleSectorEnd) )
                {
                    Console.WriteLine("The point with cordinats ({0},{1}) is IN the Circle with Radius and out of Rectangle ", x1, y1);
                    
                }
                else
                {
                    Console.WriteLine("The point with cordinats ({0},{1}) is NOT IN  the Circle with Radius", x1, y1);
                }

            }
            else
            {
                Console.WriteLine("You did not put coordinat - Please put an integr value for x and y");
            }

            Console.SetCursorPosition(1, 1);
            Console.Write("*");
            Console.ReadLine();
            
        }
    }
}
