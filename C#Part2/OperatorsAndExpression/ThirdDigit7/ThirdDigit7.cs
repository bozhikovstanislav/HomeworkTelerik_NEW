using System;
namespace ThirdDigit7
{
    class ThirdDigit7
    {
        static void Main()
        {
            //Problem 5 Third Digit is 7
            //Write an expression that checks for given integer
            //if its third digit from right-to-left is 7.
            Console.WriteLine("Welcom to the program for finding if digit is in the tird place  in a number");
            Console.WriteLine("_____________________________________________________________________________");
            Console.WriteLine("Input your number in integer way ;)");
            string a = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(a, out number);
            if (isNumber == true)
            {
               char[] numberToArray= a.ToCharArray();
               
                //creating the nuber in revers order
                Array.Reverse(numberToArray);
                //Converting the char at tird position into an integer
                int thirdNumber = int.Parse(numberToArray[2].ToString());
                //Creating bool type variable to represent the condition
                bool is7existIn3Position = thirdNumber == 7;

                if(is7existIn3Position)
                {
                    Console.WriteLine("Number you input {0} have in it's 3 position the number 7 {1}", number, is7existIn3Position);
                }

            }
            if (isNumber == false)
            {
                Console.WriteLine("You put wrong niumber . Pleas put  an integer ");
            }
            Console.ReadLine();
        }
    }
}
