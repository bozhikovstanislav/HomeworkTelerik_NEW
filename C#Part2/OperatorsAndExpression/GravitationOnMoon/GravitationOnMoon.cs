using System;
namespace GravitationOnMoon
{
    internal class GravitationOnMoon
    {
        private static void Main()
        {
            //Problem 2 Gravitation on the moon
            //The gravitational field of the Moon
            // is approximately 17% of that on the Earth.
            //Write a program that calculates
            // the weight of a man on the moon by a given weight on the Earth.

            //Known parameters.
            //calculating gMoon
            double gEarth=9.8;          //m/s^2
            double gMoon = (gEarth * 17) / 100;  //m/S^2

            //inputing the weight of a man from the console.
            Console.WriteLine("Input a mass in follaw format 00.0 kg");
            string a = Console.ReadLine();
            double weightEarth;
            bool isdouble = double.TryParse(a, out weightEarth);
            //Defining variables for weight on moon and earth.
             double weightMoon=0;
            //Checking the consistancy of input data
            if(isdouble==true)
            {
               //Calculating the mass ofthe man 
                double mass=weightEarth/9.8;
                //caculating the weight on the man on Moon 
                weightMoon=mass*gMoon;
                Console.WriteLine("The weight on the moon  is  =  {0}    kg",weightMoon);
            }
            else if(isdouble==false)
            {
                Console.WriteLine("Pleas input a number in format 00.0 for the mass you want to calculate");
            }
                Console.ReadLine();
        }
    }
}