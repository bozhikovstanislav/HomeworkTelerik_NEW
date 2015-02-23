using System;



    class Program
    {
        static double CalcSurface(double a,double hightA)
        {
            double result = (a * hightA) / 2;

            return result;
        }
        static double CalcSurface(double aSite,double bsate,double cSite)
        {
            double peri=(aSite+bsate+cSite)/2;
            double tempValue=peri*(peri-aSite)*(peri-bsate)*(peri-cSite);
            double result = Math.Sqrt(tempValue);
            return result;
        }
        static double CalcSurfaceDegrea(double ASite,double bSite,double abDegree)
        {
            double tempValue = (ASite * bSite) / 2;
            double tempValueSin = Math.Sin(abDegree);

            double area = tempValue * tempValueSin;

            return area;
        }
        static void Main()
        {
            /*
             Problem 4. Triangle surface
             Write methods that calculate the surface of a triangle by given:
             Side and an altitude to it;
             Three sides;
             Two sides and an angle between them;
                Use System.Math.
            
             */

            double a = 10;
            double hightA = 10;
            Console.WriteLine("The area of the triangle is {0}", CalcSurface(a, hightA));

            double aSite=3.1;
            double bSite = 12;
            double cSite = 13.6;

            Console.WriteLine("The area of the triangle with given A={0} B={1} C={2} is Area={3}", aSite, bSite, cSite, CalcSurface(aSite, bSite, cSite));


            double aSiteNext = 14;
            double bSiteNex = 19.3;
            double abDegrea = 1;

            Console.WriteLine("The area of the triangle with given A={0} B={1} and Degrea = {2} is Area = {3}",aSiteNext,bSiteNex,abDegrea,CalcSurfaceDegrea(aSiteNext,bSiteNex,abDegrea));


        }
    }

