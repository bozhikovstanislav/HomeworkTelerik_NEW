namespace GereicClass
{
    using System;
    
    public class Matrix<T>
        where T :  IComparable, IComparable<T>, IEquatable<T>,IFormattable,IFormatProvider
    {

        private const int rowlenght = 10;

        private const int callenght = 10;

        private T[,] matrixArray;

        private int rows;


        private int cols;



        public Matrix()
        {
            this.MatrixArray = new T[rowlenght, callenght];
        }

        public Matrix(int rows,int cols)
        {
            this.MatrixArray = new T[rows,cols];
            this.Rows = this.MatrixArray.GetLength(0);
            this.Cols = this.MatrixArray.GetLength(1);
        }
        public T[,] MatrixArray
        {
            get { return matrixArray; }
            set { matrixArray = value; }
        }
        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }
        public int Cols
        {
            get { return cols; }
            set { cols = value; }

        }

        //Indexator
        public T this[int indexerRow, int indexerCol]
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

        public Matrix<T> add(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.Rows == matrixTwo.rows && matrixOne.Cols == matrixTwo.Cols)
            {

                Matrix<T> matrixResult = new Matrix<T>(matrixOne.Rows, matrixOne.Cols);

                for (int i = 0; i < matrixResult.MatrixArray.GetLength(0); i++)
                {
                    for (int k = 0; k < matrixResult.MatrixArray.GetLength(1); k++)
                    {
                        matrixResult[i, k] =(T)Convert.ChangeType(Convert.ToDecimal(matrixOne[i, k]) +Convert.ToDecimal(matrixTwo[i, k]),typeof(T));
                    }
                }
                return matrixResult;
            }
            else
            {
                throw new ApplicationException("Matrixes don`t match operator+ requirements!");
            }
        }
        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {



        }
    }
}
