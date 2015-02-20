using System;
using System.Text;


namespace IsosacleTriangle
{
    class IsoscaleTriangle
    {
        static void Main(string[] args)
        { 
            Console.OutputEncoding = Encoding.UTF8;

            Encoding utf8 = Encoding.UTF8;
            char copyRight = '\u00A9';

            Console.WriteLine("         "+copyRight);
            Console.WriteLine("\n");
            Console.WriteLine("      " + copyRight+"      " + copyRight);
            Console.WriteLine("\n");
            Console.WriteLine("   " + copyRight + "             " + copyRight);
            Console.WriteLine("\n");
            Console.WriteLine("" + copyRight +"     "+copyRight +"      "+ copyRight+"      " + copyRight);
            Console.ReadLine();

            
        }
    }
}
