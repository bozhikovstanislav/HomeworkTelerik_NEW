using System;


namespace Sequence
{
    class Print_10
    {
        static void Main(string[] args)
        {
         

            //Problem 9 Printing sequance of numbers 2,-3,4,-5,6.....
             int i=2;
             int a = 2;
            do
            {
                if (i % 2 != 0)
                {
                    i = -i;
                   
                }
                Console.WriteLine(i);
               if(i<0)
               {
                   i = Math.Abs(i);
               }
              i++;
              a++;
            } while (a <= 11);
        
            Console.ReadLine();
        }
    }
}
