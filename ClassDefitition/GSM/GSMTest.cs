namespace GSM
{
    using System;
    using System.Collections.Generic;


    public class GSMTestList
    {
        private GSMPhone[] phones;
        private int capacityOfGSM;

       
     
        public GSMTestList(int capacity)
        {
            this.capacityOfGSM = capacity;
            this.phones = new GSMPhone[capacity];
        }
        public int CapacityOfGSM
        {
            get { return capacityOfGSM; }
            set
            { 
                capacityOfGSM = value;
                if(capacityOfGSM<=0)
                {
                    throw new ArgumentException("The capacity have to be biger the zero and a Positive Number");
                }
            }
        }

        //Indexaotr for geting info for every GSM in the Array
        public GSMPhone this[int indexer]
        {
            get 
            { 
               
                return phones[indexer]; 
            }
            set
            {
                if (indexer < 0)
                {
                    throw new IndexOutOfRangeException("The indexer have to be in the range of the array");
                }

                phones[indexer] = value;
               

            }
        }

    }
}
