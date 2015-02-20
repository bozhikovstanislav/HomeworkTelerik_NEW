using System;

class MAximumSum
{
    static void Main()
    {
        /* Problem 8          Maximal sum
         
         Write a program that finds the sequence of maximal sum in given array.
        http://www.introprogramming.info/tag/work-with-sequences-of-elements/"
        // */
        int[] numbArray = 
        { 
        
            2, 3, -6, -1, 2, -1, 6, 4, -8,8
        
        };
        //int sum = 0;
        //int maxSum = 0;
        //int tempSum = 0;
        //bool foundIndxStart = false;
        //int indexEnd = 0;
        //for (int i = 0; i <= numbArray.Length-1; i++)
        //{
        //    sum += numbArray[i];
        //    if(sum>tempSum)
        //    {

        //        maxSum = sum;
        //        indexEnd = i;
        //    }
        //    else if (sum < 0) //if the sum is negative 
        //    {
        //        sum = 0;        //restarting the sum.
        //        continue;
        //    }
        //     tempSum=sum ;

        //}
        //Console.WriteLine(maxSum);

        int sum = 0;
        int start = 0;
        int startIndextemp = 0;
        int maxSum = 0;
        int count = 0;
        for (int i = 0; i < numbArray.Length; i++)
        {
            start = i;
            sum = numbArray[start];

            for (int k = i + 2; k < numbArray.Length; k++)
            {

                sum += numbArray[k - 1];
                //Console.WriteLine("{0,2} {1,3}", numbArray[start], numbArray[k - 2]);
                if (sum > maxSum)
                {
                    maxSum = sum;
                    startIndextemp = i;
                    count++;
                }
            }
        }
        for (int t = startIndextemp; t < startIndextemp+count; t++)
        {
            Console.Write("{0,2}",numbArray[t]);
        }
         Console.WriteLine(" The sum is = {0,2}", maxSum);
      

    }
}

