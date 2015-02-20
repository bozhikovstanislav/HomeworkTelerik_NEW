using System;
class QuickSort
{
    public void quicksort(int[] array, int left, int right)
    {
        int p;
        if (right > left)
        {
            p = sort(array, left, right);
            quicksort(array, left, p - 1);
            quicksort(array, p + 1, right);
        }

    }
    public void swap(int[] ar, int a, int b)
    {
      int  temp = ar[a];
        ar[a] = ar[b];
        ar[b] = temp;
    }
    public int sort(int[] arrayTmp, int left, int right)
    {
        int P = arrayTmp[left];

        int i = left;
        int j = right + 1;

        for (;;)
        {
            while (arrayTmp[++i] < P)
            {
                if (i >= right)
                {
                    break;
                }
            }
            while (arrayTmp[--j] > P)
            {
                if (j <= left)
                {
                    break;
                }
            }
            if (i >= j)
            {
                break;
            }
            else
            {
                swap(arrayTmp, i, j);
            }
        }
        if (j == left)
        {
            return j;
        }
        else
        {
            swap(arrayTmp,left, j);
            return j;
        }
    }
    static void Main()
    {
        /*
         Problem 14. Quick sort
         
         Write a program that sorts an array of strings using the Quick sort algorithm.
         
         */
        int[] aNumbersA =
      {

          3,6,8,9,2,5,11,55,99,12
      };
        QuickSort sort = new QuickSort();
        sort.quicksort(aNumbersA, 0, aNumbersA.Length - 1);

        for (int i = 0; i < aNumbersA.Length; i++)
        {
            Console.WriteLine(aNumbersA[i]);
        }

    }
}

