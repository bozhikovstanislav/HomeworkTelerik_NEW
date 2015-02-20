using System;
namespace Rectangle
{
    class Rectangle
    {
        static void Main()
        {
            //Problem 4 Rectangle
            //Write an expression that calculates
            //rectangle’s perimeter and area by
            //given width and height.
            Console.WriteLine("Welcom to the program for calculating the rectangle's perimeter and area");

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Input the width of the recatangle ");
            string width = Console.ReadLine();
            Console.WriteLine("Input the height of the recatangle ");
            string height = Console.ReadLine();
            //Check the values input from th euser
            double numberWidth;
            double numberHeight;
            bool isNumberWidth = double.TryParse(width, out numberWidth);
            bool isNumberHeight = double.TryParse(height, out numberHeight);
            if (isNumberWidth == true && isNumberHeight==true)
            {
                int choiceNumber;
                Console.WriteLine("Chose what do you want to calculate");
                Console.WriteLine("1 : for calculating perimeter");
                Console.WriteLine("2 : for calculating area");
                Console.WriteLine("3 : for calculating area and perimenter");
                choiceNumber = int.Parse(Console.ReadLine());
                switch (choiceNumber)
                {
                    case 1:
                        //Calculating the perimeter of the rectungle
                        double perimeter = (2 * numberWidth) + (2 * numberHeight);
                        Console.WriteLine("The perimeter of the Rectungle is = {0} ", perimeter);
                        Console.WriteLine("Thank you for using the software :) Have a nice day");
                        break;
                    case 2:
                        double area = numberHeight * numberWidth;
                        Console.WriteLine("The AREA of the Rectungle is = {0} ", area);
                        Console.WriteLine("Thank you for using the software :) Have a nice day");
                        break;
                    case 3:
                        double aPerimeter = (2 * numberWidth) + (2 * numberHeight);
                        double aArea = numberHeight * numberWidth;
                        Console.WriteLine("The perimeter of the Rectungle is = {0} ", aPerimeter);
                        Console.WriteLine("The AREA of the Rectungle is = {0} ", aArea);
                        Console.WriteLine("Thank you for using the software :) Have a nice day");
                        break;
                    default:
                        Console.WriteLine("Sorry there is somethimng wrong :(");
                        break;
                }

            }
            if (isNumberWidth == false || isNumberHeight==false)
            {
                Console.WriteLine("You put wrong niumber . Pleas put  a number ");
            }
            Console.ReadLine();

        }
    }
}
