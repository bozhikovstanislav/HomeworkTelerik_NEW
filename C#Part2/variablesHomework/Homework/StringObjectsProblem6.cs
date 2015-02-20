using System;


namespace StringObjects
{
    class StringObjects
    {
        static void Main(string[] args)
        {
            //Problem 6
            string variableHello = "Hello";
            string variableWorld = "World";

            object concatination = variableHello + " " + variableWorld;

            string helloWorld = (string)concatination;

            Console.WriteLine(helloWorld);

            Console.ReadLine();
        }
    }
}
