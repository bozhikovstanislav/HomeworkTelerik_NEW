namespace Constructors
{
    using System;
    using System.Collections.Generic;
    using System.IO;

   public class Path
    {
      
       private List<Point3D> points;
       public Path()
       {
           this.Points = new List<Point3D>();
       }
       internal List<Point3D> Points
       {
           get { return points; }
           set 
           { 

               points=value;
           
           }
       }


    }
}
