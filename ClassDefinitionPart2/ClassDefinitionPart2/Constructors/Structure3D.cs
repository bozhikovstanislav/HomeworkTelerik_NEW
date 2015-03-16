namespace Constructors
{
    using System;
    using System.Collections.Generic;

    struct Point3D
    {
        private static readonly Point3D start_O=new Point3D(0,0,0);

        public static Point3D Start_O
        {
            get { return Point3D.start_O; }
        } 

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
     
        public Point3D(int xPoint,int yPoint,int zPoint)
            :this()
        {
            this.X = xPoint;
            this.Y = yPoint;
            this.Z = zPoint;
        }
        public override string ToString()
        {
            return string.Format("Point3D ={0},{1},{2}",this.X,this.Y,this.Z) ;
        }
        
    }

    class Structure3D
    {

        static void Main()
        {

            Point3D point = new Point3D();
            Point3D point2 = new Point3D(3, 54, 6);

            List<Point3D> popints = new List<Point3D>();

            popints.Add(point);
            popints.Add(point2);

            Path pathPoint = new Path();
            pathPoint.Points = popints;
            PathStorage strorage = new PathStorage(pathPoint);
            strorage.SavePointInFile();
            point.X = 0;
            point.Y = 4;
            point.Z = 10;
            Console.WriteLine(point);
            Console.WriteLine(point2);
            Console.WriteLine(Point3D.Start_O);
            Console.WriteLine();
            Console.WriteLine("Load points from the file");
            strorage.LoadPoints3D();


        

           
        }
    }
}
