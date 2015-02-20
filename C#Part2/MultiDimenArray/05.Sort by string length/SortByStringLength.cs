using System;
using System.Linq;
class SortByStringLength
{
    static void Main()
    {
        /*
         Problem 5. Sort by string length
         
         You are given an array of strings.
         Write a method that sorts the array by the length of its elements (the number of characters composing them).
         
         */

        string[] arrayString =
        {
            "My","name","is","Bay Blagoi","from","South Africa"
        };

        var sortedWords =
            from w in arrayString
            orderby w.Length
            select w;
        Console.WriteLine("The sorthed words are");

        foreach (var item in sortedWords)
        {
            Console.WriteLine(item);
        }
    }
}

