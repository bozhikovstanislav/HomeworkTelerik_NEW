using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidRangeExeption
{
    [Serializable()]
    public class InvalidRangeExeption<T> : Exception
    {
        private T start;
        private T end;
        public InvalidRangeExeption()
        {
        }
        public InvalidRangeExeption(string msg, T start, T end)
            : base(msg)
        {
            this.Start = start;
            this.End = end;

        }
        public InvalidRangeExeption(string msg, Exception innerEx)
            : base(msg, innerEx)
        {

        }
        protected InvalidRangeExeption(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) { }


        public T Start
        {
            get { return start; }
            set { start = value; }
        }
        public T End
        {
            get { return end; }
            set { end = value; }
        }
        public override string ToString()
        {
            return "Out of range fpr the type " + this.GetType().Name + "for the range Start =" + Start + "End =" + End;
        }
    }
}
