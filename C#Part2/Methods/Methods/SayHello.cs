using System;


class SayHello
{
    public static void  Wathis()
    {
        Console.WriteLine("What is your name");
        string name = Console.ReadLine();

        Console.Write("Hello {0}", name);
        Console.WriteLine();

    }
    static void Main()
    {
        /*
         Problem 1. Say Hello
         
         Write a method that asks the user for his name and prints “Hello, <name>”
         Write a program to test this method.
         
         */
        SayHello.Wathis();
    }
}

