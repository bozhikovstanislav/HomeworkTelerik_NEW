using System;

internal class CheckForCard
{
    private static void Main()
    {
        /*Problem 3.   Check for a Play Card
         Classical play cards use the following signs to designate the card face:
         * `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
         * Write a program that enters a string and prints “yes” if it is
         * a valid card sign or “no” otherwise. Examples:

         */

        Console.WriteLine("Welcom to the program that check for a Play Card");
        Console.Write("\n");
        Console.WriteLine("==================================================");

        Console.WriteLine("Enter a string ");
        string checkLeter = Console.ReadLine();

        //creating a check statement
        bool checkleterIsCard = checkLeter == "2" || checkLeter == "3" || checkLeter == "4" || checkLeter == "5" || checkLeter == "6" ||
            checkLeter == "7" || checkLeter == "8" || checkLeter == "9" || checkLeter == "J" || checkLeter == "Q" || checkLeter == "K" || checkLeter == "A";
        if (checkleterIsCard)
        {
            Console.WriteLine("The string {0} you just have enter exist in the Card ", checkLeter);

            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("The string {0} you just have enter DO NOT exist in the Cards ", checkLeter);
            Console.WriteLine("No");
        }
    }
}