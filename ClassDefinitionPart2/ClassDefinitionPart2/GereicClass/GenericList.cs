namespace GereicClass
{
    using System;

    public class GenericList<T>
    {
        private T[] arrailist;
        private int capacityArray;

        public GenericList()
        {
          
        }
        public GenericList(int capacityArray, T[] arrayGeneric)
        {
            this.CapacityArray = capacityArray;
            this.Arrailist = arrayGeneric;
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

        public void Add(T itme)
        {
            for (int i = 0; i < this.CapacityArray; i++)
			{
                if(Arrailist.GetValue(i)!=0 && Arrailist.Length<=this.CapacityArray)
                {
                    this.Arrailist.SetValue(itme, i);
                    break;
                }
                
			}
            
        }
    }
}
