namespace Constructors
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class PathStorage
    {
        private Path path;

        public Path Path
        {
            get { return path; }
            set
            {
                path = value;
            }
        }
        public PathStorage(Path path)
        {
            this.Path = path;
        }

        public void SavePointInFile()
        {
            var pathPoints = this.path.Points;
            StreamWriter writer = new StreamWriter(@"..\..\resultToPoint3D.txt");
            using (writer)
            {
                for (int i = 0; i < pathPoints.Count; i++)
                {

                    writer.WriteLine(pathPoints[i]);
                }


            }

        }
        public void LoadPoints3D()
        {
            var Points = this.path.Points;

            List<string> loadPoints = new List<string>();
            StreamReader reader = new StreamReader(@"..\..\resultToPoint3D.txt");

            using(reader)
            {
                for (int i = 0; i < Points.Count; i++)
                {
                   loadPoints.Add(reader.ReadLine());
                }
            }

            foreach (var item in loadPoints)
            {
                Console.WriteLine(item);
            }
        }

    }
}
