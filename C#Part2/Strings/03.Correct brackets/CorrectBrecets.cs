

namespace _03.Correct_brackets
{
    using System;

    class CorrectBrecets
    {
        static bool IsBracketsCorect(string expresion)
        {
            int countOpen = 0;
            int countClosed = 0;
            for (int i = 0; i < expresion.Length; i++)
            {
                if( string.Compare("(",expresion[i].ToString())==0)
                {
                    countOpen++;
                }
                if (string.Compare(")", expresion[i].ToString()) == 0)
                {
                    countClosed++;
                }
            }
            if(countOpen==countClosed)
            {
                return true;
                
            }
            return false;
        }

        static void Main()
        {
            /*Problem 3. Correct brackets
             
             Write a program to check if in a given expression the brackets are put correctly.
             Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
             
             */

            string expresion="((a+b)/5-d)";
           
            bool isBrecetsCorect = IsBracketsCorect(expresion);
            Console.WriteLine(isBrecetsCorect);
          
        }
    }
}
