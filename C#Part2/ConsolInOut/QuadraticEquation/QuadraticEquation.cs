using System;


    class QuadraticEquation
    {
        static void Main()
        {
            /*Problem 6.   Quadratic Equation
             
             Write a program that reads the coefficients a, b and c of 
             a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
             
             */
            Console.WriteLine("Whelcom to the program that calculates the roots of a Quadratic Equation ");
            Console.WriteLine("\n");

            Console.WriteLine("***********************************************************");

            Console.WriteLine("The quadratic equation ax^2+bx+c=0 is presented");

            Console.WriteLine("Enter the First number a of the eqation");
            string numberA = Console.ReadLine();
            int aNumber;
            do
            {
                Console.WriteLine("The number a {0} is inputed", numberA);


            } while (!int.TryParse(numberA,out aNumber));

            Console.WriteLine("Enter the Second number b of the eqation");
            string numberB = Console.ReadLine();
            int bNumber;
            do
            {

                Console.WriteLine("The number b {0} is inputed", numberB);


            } while (!int.TryParse(numberB, out bNumber));

            Console.WriteLine("Enter the Second number c of the eqation");
            string numberC = Console.ReadLine();
            int cNumber;
            do
            {

                Console.WriteLine("The number c {0} is inputed", numberC);


            } while (!int.TryParse(numberC, out cNumber));

            //calculating the real roots of the eqation
            //Vieta's formulas give a simple relation between the roots x1+x2=-(b/a) x1*x2=c/a;
            //x2=(c*x1)/a
            //x1=-(c*x1)/a+b/a
            //x1+c*x1=b/a
            //x1(1+c)=b/a
            //x1=(b/a)/(1+c)
            //defining x1 and x2;
            //Calcuating the determinant

            try
            {
                double sqrNumberdeterm = bNumber * bNumber - (4 * aNumber * cNumber);
                double d = Math.Sqrt(sqrNumberdeterm);
                if (sqrNumberdeterm<=0)
                {
                    Console.WriteLine("No real numbers");
                }
                //Calculating the x1 and x2 roots
                else
                {
                    double x1 = -(bNumber - d) / (2 * aNumber);
                    double x2 = -(bNumber + d) / (2 * aNumber);

                     Console.WriteLine("The rotts of the eqation are x1 ={0} and x2={1} ", x1, x2);
                }
               
            }
            catch (ApplicationException e)
            {

                Console.WriteLine("Error");
            }
           

        

           

            Console.ReadLine();



        }
    }
