using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double precision = 0.000001;
            
            string aPrecision=String.Format("{0:0.000000}",precision);
            string aPrecisionDotEmpty = new string(aPrecision.Where(char.IsDigit).ToArray());
            //Changing the format of the precision
            
            string presitionA = String.Format("{0:0.000000}", precision);
            //Input from the consol
            Console.WriteLine("Enter a number a = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b = ");
            double b = double.Parse(Console.ReadLine());

            //Converting the numbers into vhar array
            string aNumber = String.Format("{0:0.000000}", a);
            string bNumber = String.Format("{0:0.000000}", b);

            //Removing the dot
            string aNumberDotEmpty = new string(aNumber.Where(char.IsDigit).ToArray());
            string bNumberDotEmpty = new string(bNumber.Where(char.IsDigit).ToArray());


            char[] aCoverting = aNumberDotEmpty.ToCharArray();
            char[] bConverted = bNumberDotEmpty.ToCharArray();
           //checking the first number form the number array A
            int count = 0;
            do
            {
                int aNumberDotEmptyDigit = int.Parse(aCoverting[count].ToString());
                int bNumberDotEmptyDigit = int.Parse(bConverted[count].ToString());
              
                  if (aNumberDotEmptyDigit < bNumberDotEmptyDigit)
                    {
                        Console.WriteLine("Numbers are differend ");
                        count = aPrecisionDotEmpty.Length;
                    }
                    if (aNumberDotEmptyDigit == bNumberDotEmptyDigit)
                    {
                        count = aPrecisionDotEmpty.Length;
                        Console.WriteLine("Numbers are equal");
                    }
                 count++;
            } while (count != presitionA.Length);
            
           

            Console.ReadLine();
        }
    }
}
