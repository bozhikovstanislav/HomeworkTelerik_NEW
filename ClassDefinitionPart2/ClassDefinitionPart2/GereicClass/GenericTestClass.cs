namespace GereicClass
{
    using System;


    public class GenericTestClass
    {
        static void Main()
        {
            GenericList<int> lista=new GenericList<int>();
            lista.CapacityArray = 10;
            lista.Arrailist = new int[lista.CapacityArray];
            lista.Add(5);
            lista.Add(10);
            for (int i = 0; i < lista.CapacityArray; i++)
            {
               Console.WriteLine(lista[i]);
            }

            
            

        }
    }
}
