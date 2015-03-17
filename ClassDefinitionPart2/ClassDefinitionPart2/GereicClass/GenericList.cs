namespace GereicClass
{
    using System;
    using System.Collections.Generic;

    public class GenericList<T>
    {
        private T[] arrailist;
        private int capacityArray;
        private int lastIndexValue;

     
        public GenericList()
        {

        }
        public GenericList(int capacityArray, T[] arrayGeneric)
        {
            this.CapacityArray = capacityArray;
            this.Arrailist = arrayGeneric;
            this.LastIndexValue = 0;
        }

        public T[] Arrailist
        {
            get { return arrailist; }
            set
            {
                arrailist = value;
            }
        }

        public int CapacityArray
        {
            get { return capacityArray; }
            set { capacityArray = value; }
        }
        //Defining Indexator
        public T this[int indexer]
        {
            get { return arrailist[indexer]; }
            set
            {
                arrailist[indexer] = value;
            }
        }

        public int LastIndexValue
        {
            get 
            {
                
                return lastIndexValue;
            }
            set 
            {   
  
                lastIndexValue = value; 
            }
        }

      
        public T getValue(int index)
        {
            var value = Arrailist.GetValue(index);
            int indexArray = Array.IndexOf(this.Arrailist, value);

            T vresult = this.Arrailist[indexArray];
            return vresult;

        }
        public void removeElement(int index)
        {

        }
        public void insertElemet(int index)
        {

        }
        public void clearList()
        {

        }
        //public int findeElement(T element)
        //{

        //}
        public void Add(T itme)
        {
      
            this.Arrailist.SetValue(itme, LastIndexValue);
            this.LastIndexValue++;

        }
    }
}
