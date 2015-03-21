namespace GereicClass
{
    using System;


    public class GenericTestClass
    {
        static void Main()
        {
            GenericList<int> lista=new GenericList<int>();
            lista.CapacityArray = 3;
            lista.Arrailist = new int[lista.CapacityArray];
            lista.Add(5);
            lista.Add(1);
            lista.Add(3);
            lista.Add(2);
            lista.Add(10);
            lista.Add(4);
           //Console.WriteLine(lista.CapacityArray);
           Console.WriteLine(lista.Min());

           Matrix<double> myIntMatrix = new Matrix<double>();

           myIntMatrix.MatrixArray.SetValue(1, 0, 0);
           myIntMatrix.MatrixArray.SetValue(10, 0, 1);
           myIntMatrix.MatrixArray.SetValue(20, 1, 0);
           
           Console.WriteLine(myIntMatrix[0, 0]);
           Console.WriteLine(myIntMatrix[0, 1]); 
           Console.WriteLine(myIntMatrix[1, 0]);

       
           //lista.clearList();
           //Console.WriteLine(lista.getValue(1).ToString());

        }
    }
}
