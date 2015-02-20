using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValues
{
    class NullValues
    {
        static void Main(string[] args)
        {
            //Problem 12 Null Values Arithmetic

            int? valuenull = null;
            double? valuedouble = null;
            valuedouble = 4.333;
            
            Console.WriteLine("Int null value = {0}", valuenull);
            Console.WriteLine("Double null value = {0}", valuedouble);
            Console.ReadLine();
        }
    }
}
