using System;



class Program
{
    public void GetLatsEnglish(int integer)
    {
        string lastDigitGet= integer.ToString();
        int last = 0;
        for (int i = 0; i < lastDigitGet.Length; i++)
        {
             last = lastDigitGet[lastDigitGet.Length - 1];
        }

        switch (last)

        {
            case 0:
                Console.WriteLine("zero");
                break;
            case 1:
              Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("tree");
                break;
            case 4:
                Console.WriteLine("four");
                break;
            case 5:
                Console.WriteLine("five");
                break;
            case 6:
                Console.WriteLine("six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("eith");
                break;
            case 9:
                Console.WriteLine("nine");
                break;
            default:

                break;
        }
       
    }
    static void Main()
    {
        /*
         Write a method that returns the last digit of given integer as an English word.
         
         */
        Console.Write("Enter an integer A = ");
        int; 
    }
}
