namespace Constructors
{
    using System;



    static class CalculateDistance
    {

        public static double CalculateDistancein3DSpace(Point3D pointOne, Point3D pointTwo)
        {


            double calculateDistance = Math.Sqrt(Math.Pow((pointOne.X-pointTwo.X),2)+Math.Pow((pointOne.Y-pointTwo.Y),2)+Math.Pow((pointOne.Z-pointTwo.Z),2));


            return calculateDistance;
        }
    }
}
