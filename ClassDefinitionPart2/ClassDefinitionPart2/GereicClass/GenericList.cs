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
                if(indexer>=this.CapacityArray+1)
                {
                    throw new IndexOutOfRangeException("The input index is out of the boudery of the list");
                }
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

                if(lastIndexValue>=this.capacityArray+1)
                {
                    throw new ArgumentOutOfRangeException("There is no more space in the List You can not Add more Value into ");
                }

            }
        }

        //accesing elements by it Index
        public T getValue(int index)
        {
            
            try
            {
                T value =(T)Arrailist.GetValue(index);
                if (index >= this.CapacityArray)
                {
                    throw new ArgumentOutOfRangeException("There is no such index in the List");
                }
                else
                {
                    return value;
                }
               
            }
            catch (ApplicationException)
            {
                throw new ApplicationException("There is some problem in th eaplicstion code {0}");
                
            }

        }
        //removing element by Index
        public void removeElement(int index)
        {
            this.Arrailist.GetValue(index);

        }
        //insert element at given position
        public void insertElemet(T item, int index)
        {
            this.Arrailist.SetValue(item, index);
        }
        //clear the list
        public void clearList()
        {
            Array.Clear(this.Arrailist, 0, CapacityArray);
        }

        //find element by it's value
        public int findeElement(T element)
        {
            return Array.IndexOf(this.Arrailist, element);
        }

        //add elements
        public void Add(T itme)
        {

            this.Arrailist.SetValue(itme, LastIndexValue);
            this.LastIndexValue++;

        }

        public override string ToString()
        {
            var result = this.Arrailist;
            return string.Join(",", result);
        }
    }
}
