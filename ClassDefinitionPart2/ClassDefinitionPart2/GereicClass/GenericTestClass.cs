﻿namespace GereicClass
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
            lista.Add(10);
            lista.Add(34);
            lista.Add(5);
            lista.Add(10);
            lista.Add(34);
           Console.WriteLine(lista.CapacityArray);
           //lista.clearList();
           //Console.WriteLine(lista.getValue(1).ToString());

        }
    }
}
