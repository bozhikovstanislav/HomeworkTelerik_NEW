using System;


class CharArray
{
    static void Main()
    {
        /*  Problem 3.                Compare char arrays
         
         Write a program that compares two char arrays lexicographically (letter by letter).
         
         */


        //initializng the arrays 
        char[] charArrayA = new char[]
        {
            'A','N','B','a','X','!'
        };

        char[] charArrayB = new char[]
        {
            'A','O','Q','a','C','#'
        };

        //compare the arrays

        for (int i = 0; i < charArrayA.Length; i++)
        {

            bool isEqual = charArrayA[i].CompareTo(charArrayB[i]) > 0;
            bool isEqualChar = charArrayA[i].CompareTo(charArrayB[i]) == 0;

            if(charArrayA.Length!=charArrayB.Length)
            {
                Console.WriteLine("The arrays are with diferend lenght");
                break;
            }
           else if(isEqual)
           {
               Console.WriteLine("{0} > {1}", charArrayA[i], charArrayB[i]);
           }
           else if(!isEqual && !isEqualChar)
           {
               Console.WriteLine("{0} < {1}", charArrayA[i], charArrayB[i]);
           }
           else if (isEqualChar)
           {
               Console.WriteLine("{0} = {1}", charArrayA[i], charArrayB[i]);
           }
        }



    }
}
