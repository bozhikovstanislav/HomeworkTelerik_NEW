using System;

class MargeSort
{

    /*Problem 13.*
     Merge sort
     Write a program that sorts an array of integers using the Merge sort algorithm. Top-Down Implementation 
     */



    // public void TopDownMergeSort(int[]A,int[]B,int n)
    //    {
    //              TopSplidMarge(A, 0, n, B);
    //    }


    //public void TopSplidMarge(int[]A,int iStart,int iEnd,int[]B)
    //{
    //    if(iEnd-iStart<2)       //The matrix are sorted
    //    {

    //        return;
    //    }
    //    int iMidle = (iEnd - iStart) / 2;
    //    TopSplidMarge(A, iStart, iMidle, B);
    //    TopSplidMarge(A, iMidle, iEnd, B);
    //    TopDownMerge(A, iStart, iMidle, iEnd, B);
    //    CopyArray(B, iStart, iEnd, A);
    //}
    //public void CopyArray(int[]B,int iStart,int iEnd,int[]A)
    //{
    //    for (int i = iStart; i < iEnd; i++)
    //    {
    //        A[i] = B[i];
    //        Console.WriteLine(A[i]);
    //    }
    //}
    //public void TopDownMerge(int[]A,int iStart,int iMidle,int iEnd,int[]B)
    //{
    //    int iO = iStart;
    //    int i1 = iMidle;

    //    for (int i = iStart; i < iEnd; i++)
    //    {
    //        if(iO<iMidle && (i1>=iEnd || A[iO]<=A[i1]))
    //        {
    //            B[i] = A[iO];
    //            iO++;
    //        }
    //        else
    //        {
    //            B[i] = A[i1];
    //            i1++;
    //        }
    //    }
    //}
    //public static int[] mergeSort(int[] array)
    //{
    //    if (array.Length <= 1)
    //    {
    //        return array;
    //    }
    //    int middle = array.Length / 2;
    //    int[] left = new int[middle];
    //    int[] right = new int[array.Length - middle];
    //    for (int i = 0; i < left.Length; i++)
    //    {
    //        left[i] = array[i];
    //    }
    //    for (int i = 0; i < right.Length; i++)
    //    {
    //        right[i] = array[i + left.Length];
    //    }
    //    left = mergeSort(left);
    //    right = mergeSort(right);
    //    return merge(left, right);
    //}
    //public static int[] merge(int[] left, int[] right)
    //{
    //    int[] result = new int[left.Length + right.Length];
    //    int iLeft = 0;
    //    int iRight = 0;
    //    int iResult = 0;

    //    while (iResult < result.Length)
    //    {
    //        if (iLeft < left.Length && iRight < right.Length)
    //        {
    //            if (left[iLeft] <= right[iRight])
    //            {

    //                result[iResult] = right[iResult++];
    //                iResult++;
    //            }
    //            else
    //            {

    //                result[iResult] = left[iResult];
    //                iResult++;
    //            }
    //        }
    //        else if (iLeft < left.Length)
    //        {

    //            result[iResult] = left[iLeft++];
    //            iResult++;
    //        }
    //        else if (iRight < right.Length)
    //        {

    //            result[iResult] = right[iRight++];

    //        }

    //    }
    //    return result;
    //}

    //static public void DoMerge(int[] numbers, int left, int mid, int right)
    //{

    //    int[] temp = new int[25];

    //    int i, left_end, num_elements, tmp_pos;

    //    left_end = (mid - 1);

    //    tmp_pos = left;

    //    num_elements = (right - left + 1);

    //    while ((left <= left_end) && (mid <= right))
    //    {

    //        if (numbers[left] <= numbers[mid])
    //        {
    //            temp[tmp_pos++] = numbers[left++];
    //        }
    //        else
    //        {
    //            temp[tmp_pos++] = numbers[mid++];
    //        }
    //    }

    //    while (left <= left_end)
    //    {
    //        temp[tmp_pos++] = numbers[left++];
    //    }

    //    while (mid <= right)
    //    {
    //        temp[tmp_pos++] = numbers[mid++];
    //    }

    //    for (i = 0; i < num_elements; i++)
    //    {

    //        numbers[right] = temp[right];
    //        right--;

    //    }

    //}
    //static public void MergeSort_Recursive(int[] numbers, int left, int right)
    //{

    //    int mid;

    //    if (right > left)
    //    {

    //        mid = (right + left) / 2; //Divide step

    //        MergeSort_Recursive(numbers, left, mid);//Conquer step

    //        MergeSort_Recursive(numbers, (mid + 1), right);//Conquer step

    //        DoMerge(numbers, left, (mid + 1), right);//Conquer step

    //    }

    //}

    public static void Sort(int[] data, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            Sort(data, left, middle);
            Sort(data, middle + 1, right);
            Merge(data, left, middle, middle + 1, right);
        }
    }
    public static void Merge(int[] data, int left, int middle, int middle1, int right)
    {
        int oldPosition = left;
        int size = right - left + 1;
        int[] temp = new int[size];
        int i = 0;

        while (left <= middle && middle1 <= right)
        {
            if (data[left] <= data[middle1])
            {
                temp[i++] = data[left++];
            }

            else
                temp[i++] = data[middle1++];
        }
        if (left > middle)
        {
            for (int j = middle1; j <= right; j++)
            {
                temp[i++] = data[middle1++];
            }

        }

        else
        {
            for (int j = left; j <= middle; j++)
            {
                temp[i++] = data[left++];
            }

        }

        Array.Copy(temp, 0, data, oldPosition, size);
    }


    static void Main()
    {
        int[] aNumbersA =
      {

          3,6,8,9,2,5,11,55,99,12
      };


        MargeSort.Sort(aNumbersA, 0, aNumbersA.Length - 1);

        for (int i = 0; i < aNumbersA.Length; i++)
        {
            Console.WriteLine(aNumbersA[i]);
        }
    }
}

