using System;
namespace DivideBy7And5
{
    class DevidBy7And5
    {
        static void Main()
        {
            //Problem 3 devid by 7 and 5
            //Write a Boolean expression that checks for given integer 
            //if it can be divided (without remainder) by 7 and 5 at the same time.
            
            //Input from the use 

            Console.WriteLine("Welcom to the program that finds if a number is devided by 5 and 7 at the same time");
            Console.WriteLine("_____________________________________________________________________________");
            Console.WriteLine("Input your number in integer way ;)");
            string inputNumber = Console.ReadLine();
            //VerificTION OF THE STRING 
            int number;
            bool isNumber = int.TryParse(inputNumber, out number);

            if (isNumber == true)
            {
                //checing the input number if dividet by 7 and 5 
                
                int reminder5=number%5;
                int remindr7=number%7;
                bool isDevidedby7And5 = reminder5 == 0 && remindr7 == 0;

                if (isDevidedby7And5)
                {
                    Console.WriteLine(isDevidedby7And5);
                }
                else
                {
                    Console.WriteLine(isDevidedby7And5);
                }
             
            }
            if (isNumber == false)
            {
                Console.WriteLine("You put wrong niumber . Pleas put  a number of type integer ");
            }
          
            Console.ReadLine();

                
        }
    }
}
