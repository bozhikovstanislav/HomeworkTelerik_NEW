using System;


namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            ///*Problem 6 Four-Digit Number
                //Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
                //Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
                //Prints on the console the number in reversed order: dcba (in our example 1102).
                //Puts the last digit in the first position: dabc (in our example 1201).
                //Exchanges the second and the third digits: acbd (in our example 2101).
            ///
            Console.WriteLine("Welcom to the program that make a calculation for a given four digit number");
            Console.WriteLine("_____________________________________________________________________________");
            Console.WriteLine("Enter a number with 4 digits and the first digit must not be a ZERO ");
            string a = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(a, out number);
            //Checking if the number is a digit
           
            if (isNumber == true)
            {

                //Converting the number to a array of chars
                char[] inputNumber=a.ToCharArray();
                
                int firstNumber = int.Parse(inputNumber[0].ToString());
                int digitLenght = inputNumber.Length;

                //Creating the bool conditions
                bool isFirstDigitZero = int.Parse(inputNumber[0].ToString()) != 0;
                bool isDigitLenght = inputNumber.Length == 4;

                //checking if the number starts with digi 0 and the lenght of the digit is 4
                if (isFirstDigitZero && isDigitLenght)
                {
                    Console.WriteLine("Pleas chose what do you want to do ");
                    Console.WriteLine("\n");
                    Console.WriteLine("1: Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4)");
                    Console.WriteLine("2: Prints on the console the number in reversed order: dcba (in our example 1102).");
                    Console.WriteLine("3: Puts the last digit in the first position: dabc (in our example 1201).");
                    Console.WriteLine("4: Exchanges the second and the third digits: acbd (in our example 2101).");
                    int swicher = int.Parse(Console.ReadLine());
                    switch (swicher)
                    {
                        case 1:

                            //Calculating the sum of the digits 
                            int sum = 0;
                            int tempSum = 0;
                            for (int i = 0; i < inputNumber.Length; i++)
                            {
                                sum = int.Parse(inputNumber[i].ToString());
                                tempSum =tempSum+sum;
                            }
                            Console.WriteLine("The sum of the digit you have enter is {0} ", tempSum);

                            break;
                        case 2:
                            //Prints on the console the number in reversed order: dcba (in our example 1102).
                            Array.Reverse(inputNumber);
                            Console.Write("Printing the number in revers order ");
                            for (int i = 0; i < inputNumber.Length; i++)
                            {
                                Console.Write( inputNumber[i]);
                            }
                            break;
                        case 3:
                            //Puts the last digit in the first position: dabc (in our example 1201).
                            Console.Write("Program puts the last digit into the first place \n");
                            
                            //Make revers of the array
                            Array.Reverse(inputNumber);
                            char tmp;
                            //swapint the numbers in the array
                            for (int i =1; i < inputNumber.Length; i++)
                            {
                                tmp = inputNumber[i-1];
                                inputNumber[i-1]=inputNumber[i];
                                inputNumber[i] = tmp;
                            }
                            //reversing the array again 
                            Array.Reverse(inputNumber);

                            //printing number on the console
                            for (int i = 0; i < inputNumber.Length; i++)
                            {
                                Console.Write(inputNumber[i]);
                            }
                            
                            break;
                        case 4:
                            //Exchanges the second and the third digits: acbd (in our example 2101).

                            //Creating temporary varables
                            char temp;
                            int count=0;
                            for (int i = 0; i < inputNumber.Length; i++)
                            {
                                //checking if we are on the second position of the number and flip it with ther tird
                                if(count==1)
                                {
                                    temp = inputNumber[i];
                                    inputNumber[i] = inputNumber[i+1];
                                    inputNumber[i + 1] = temp;
                                }
                                count++;
                                //Printing the number on the console one char by on char 
                                Console.Write(inputNumber[i]);
                            }


                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("The number you enter has a 0 digit in his first place - Please chose other number");
                    Console.WriteLine("The progtram will leav now bye bye ;)");
                }
            }
            if (isNumber == false)
            {
                Console.WriteLine("You put wrong niumber . Pleas put  an digit ");
            }
            Console.ReadLine();
        }
    }
}
