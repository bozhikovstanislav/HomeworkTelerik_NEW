

namespace ComonTypeSystem.Classes
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class BitArray64:IEnumerable<int>
    {
        private ulong[] numbers;

        public ulong[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }

        public BitArray64(ulong[] arr)
        {
            this.numbers = arr;
        }
       

        public override bool Equals(object obj)
        {
            BitArray64 arr64 = obj as BitArray64;

            for (int i = 0; i < arr64.Numbers.Length; i++)
            {
                if (!this.Numbers.GetValue(i).Equals(arr64.Numbers.GetValue(i)))
                {
                    return false;
                }
            }
            return true;
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (int item in numbers)
            {
                yield return item;
            }

        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override int GetHashCode()
        {
            int hash = Numbers.GetValue(0).GetHashCode();
            for (int i = 0; i < Numbers.Length; i++)
            {
                hash = hash ^ Numbers.GetValue(i).GetHashCode();
            }
            return hash;
        }

        public ulong this[int index]
        {
            get
            {
                ulong? a = null;
                for (int i = 0; i < Numbers.Length; i++)
                {
                    if (index == i)
                    {
                        return numbers[i];
                    }
                }
                return (ulong)a;
            }

            set
            {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    if (index == i)
                    {
                        numbers[i] = value;
                    }
                }
            }
        }

        public static bool operator ==(BitArray64 bit1, BitArray64 bit2)
        {
            return bit1.Equals(bit2);
        }

        public static bool operator !=(BitArray64 bit1, BitArray64 bit2)
        {
            return !bit1.Equals(bit2);
        }




    }
}
