namespace GereicClass
{
    using System;
    public class Matrix<T>
    {

        private const int rowlenght = 10;

        private const int callenght = 10;

        private T[,] matrixArray;


        public Matrix()
        {
            this.MatrixArray = new T[rowlenght, callenght];
        }

        public T[,] MatrixArray
        {
            get { return matrixArray; }
            set { matrixArray = value; }
        }

        //Indexator
        public T this[int indexerRow,int indexerCol]
        {
            get 
            {
                return matrixArray[indexerRow, indexerCol]; 
            }
            set
            {
                if (indexerRow >= this.matrixArray.GetLongLength(0) && indexerCol >= this.matrixArray.GetLongLength(0))
                {
                    throw new IndexOutOfRangeException("The input index is out of the boudery of the list");
                }
                matrixArray[indexerRow, indexerCol] = value;
            }
        }
    }
}
