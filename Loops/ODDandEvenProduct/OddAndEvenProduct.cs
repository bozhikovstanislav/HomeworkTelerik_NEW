using System;

class OddAndEvenProduct
{
    static void Main()
    {
        /*Problem 10.
         
         Odd and Even Product
         You are given n integers (given in a single line, separated by a space).
         Write a program that checks whether the product of the odd elements is equal 
         to the product of the even elements.
         Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
        
         */
        Console.WriteLine("Welcom to the program that calculates ood even product");
        Console.Write("\n");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("You are alaw to input only 100 integers");
      

        Console.Write("Enetr how much numbers you want to input N = ");
        string countNumbersInputed = Console.ReadLine();
        //validating for Not inoputed
        if(countNumbersInputed=="")
        {
            Console.WriteLine("You did not inout e number Pleas Start again");
            Console.WriteLine("The program will exit ");
            return;
        }
        int countnumbersInputed;
        bool isAnumber = int.TryParse(countNumbersInputed, out countnumbersInputed);
        if(isAnumber)
        {
            Console.WriteLine("You inout {0} sequance of numbers to work with ");
            
        }
        else
        {
            Console.WriteLine("There is an error in you inputs ");
            Console.WriteLine("The program will terminated :)");
            return;
        }
        Console.Clear();
        Console.WriteLine("********************************************************************");
        Console.Write("\n");
        Console.Write("Enter a sequance of numbers Integers  separate by space = ");
        string numbers = Console.ReadLine();
        //splinting the numbers 
        string[] splitnumbers = numbers.Split(' ');
        //validating the nubers
        int countNubers = splitnumbers.Length;
        //Seting a array with 100 to colect our numbers
        int[] inputIntegrs = new int[countnumbersInputed];
        for (int i = 0; i < splitnumbers.Length; i++)
        {
            //Validating the inoput numbers
            inputIntegrs[i] = new int();
            bool isInteger = int.TryParse(splitnumbers[i], out inputIntegrs[i]);
            if (isInteger)
            {
                Console.WriteLine("Input integers {0} is OK ", splitnumbers[i]);
            }
            else
            {
                Console.WriteLine("Input integers {0} is NOT OK ", splitnumbers[i]);
                Console.WriteLine("The program will now exit :)");
                return;
            }
            //clculating the odd and even product 


        }
        double productOdd=1;
        double productEvn=1;
        int count = 1;
        for (int i = 0; i < inputIntegrs.Length; i++)
        {
            //number is even
            if (count % 2 == 0)
            {
                productEvn *= inputIntegrs[i];

            }
               
            //Number is Odd
            else
            {
                productOdd *= inputIntegrs[i];
            }
            //
            count++;
        }
        Console.WriteLine("The odd product is {0}", productOdd);
        Console.WriteLine("The even product is {0}", productEvn);

        //checking if the products are equal
        bool equalProduct = productOdd == productEvn;

        if (equalProduct)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("NO");
        }




    }
}

