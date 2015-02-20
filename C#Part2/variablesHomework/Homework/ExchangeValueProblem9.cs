using System;

namespace ExchangeValue
{
    class ExchangeValue
    {
        static void Main(string[] args)
        {
            //Problem 9 Exchange Variable Value
            int a = 5;
            int b = 10;
            Console.WriteLine("Number a= {0} ; Number b={1};", a, b);
            //Exchange Values
            int tempValue=a;
            a = b;
            b = tempValue;
            //Print on the console
            Console.WriteLine("Number a= {0} ; Number b={1};", a, b);
            Console.ReadLine();
        }
    }
}
