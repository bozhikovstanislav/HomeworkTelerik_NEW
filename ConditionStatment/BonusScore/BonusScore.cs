using System;

    class BonusScore
    {
        static void Main()
        {
            /*  Problem 2.            Bonus Score
             Write a program that applies
             bonus score to given score in the range [1…9] by the following rules:

             * If the score is between 1 and 3, the program multiplies it by 10.
               If the score is between 4 and 6, the program multiplies it by 100.
               If the score is between 7 and 9, the program multiplies it by 1000.
             * If the score is 0 or more than 9, the program prints “invalid score”.
             *
             */

            Console.WriteLine("Wellcom to the BONUS SCORE Program");
            Console.WriteLine("_____________________________________________________");
            Console.Write("\n");

            Console.WriteLine("Eneter a Score between 0 and 9 ");
            string score = Console.ReadLine();
            int scornumber;
            do
            {
                Console.WriteLine("You have enter a score {0} ", score);
            } while (!int.TryParse(score,out scornumber));

            if(scornumber<=3&&scornumber>=1)
            {
                int bonusScore = scornumber * 10;

                Console.WriteLine("You get a bonus Score of {0}*10 = ", scornumber);
                Console.Write("\n");
                Console.WriteLine("Tour actual score is now {0}", bonusScore);
            }
            else if(scornumber<=6&&scornumber>=4)
            {
                int bonusScore = scornumber * 100;

                Console.WriteLine("You get a bonus Score of {0}*100  ", scornumber);
                Console.Write("\n");
                Console.WriteLine("Tour actual score is now {0}", bonusScore);
            }
            else if(scornumber<=9&&scornumber>=7)
            {
                int bonusScore = scornumber * 1000;

                Console.WriteLine("You get a bonus Score of {0}*1000  ", scornumber);
                Console.Write("\n");
                Console.WriteLine("Tour actual score is now {0}", bonusScore);
            }
            else
            {
                Console.WriteLine("Invalid score {0}", scornumber);
            }
        }
    }