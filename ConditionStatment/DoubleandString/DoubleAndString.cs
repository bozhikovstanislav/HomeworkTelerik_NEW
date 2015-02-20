using System;

    class DubleAndString
    {
        static void Main()
        {
            /*Problem 9. Play with Int, Double and String
             
             Write a program that, depending on the user’s choice, inputs an int, double or string variable.
             if the variable is int or double, the program increases it by one.
             if the variable is a string, the program appends * at the end.
             Print the result at the console. Use switch statement.
             
             
             */

            Console.WriteLine("Welcom to the program Play with Int, Double and String");
            Console.Write("\n");
            Console.WriteLine("000000000000000000000000000000000000000000000000000");

            Console.WriteLine("Chose from the list of variable types");
            Console.Write("\n");
            Console.WriteLine("1 ---- int");
            Console.WriteLine("2 ---- double");
            Console.WriteLine("3 ---- string");

            string numberA = Console.ReadLine();
            int choiceOne;
            do
            {
                Console.WriteLine("The Choice {0} is accepted ", numberA);

            } while (!int.TryParse(numberA, out  choiceOne));
            Console.Write("\n");
            //Initializing the two numbers
            Console.WriteLine("Enter the variable type you chose ");
            string variable = Console.ReadLine();
            int variableInt=0;
            double variableDouble=0;
            if(choiceOne==1)
            {
                //validating the input 
               
                bool isvariableInt = int.TryParse(variable, out variableInt);
                if (isvariableInt)
                {
                    Console.WriteLine("Your variable is corectly enetred");
                }
                else
                {
                    Console.WriteLine("This is not the variable type you have chosen ");
                    Console.WriteLine("The program will close now Bye Bye");
                    return;
                }
            }
            else if(choiceOne==2)
            {
                //validating the input 
               
                bool isvariableDouble = double.TryParse(variable, out variableDouble);
                if (isvariableDouble)
                {
                    Console.WriteLine("Your variable is corectly enetred");
                }
                else
                {
                    Console.WriteLine("This is not the variable type you have chosen ");
                    Console.WriteLine("The program will close now Bye Bye");
                    return;
                }
            }

            Console.Write("\n");
            switch (choiceOne)
            {
                case 1:
                    {
                      
                       Console.WriteLine("The variable is {0}",++variableInt);
                        break;
                    }
                case 2:
                    {  

                         Console.WriteLine("The variable is {0}",++variableDouble);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(variable+"*");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error somewhere");
                        break;
                    }
                    
            }





        }
    }

