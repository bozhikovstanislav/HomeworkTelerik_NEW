namespace LinqHomeWork
{
    using System;
    using System.Collections.Generic;


    public static class IEnumerableExtention
    {
        public static T sum<T>(this IEnumerable<T> list)
        {
            dynamic sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            return sum;
        }
        public static double sum2<T>(this IEnumerable<T> list)
        {
            List<T> list2 = new List<T>();
            foreach (var item in list)
            {
                list2.Add(item);
            }
            double sum = 0;
            for (int i = 0; i < list2.Count; i++)
            {
                sum += double.Parse(list2[i].ToString());
            }

            return sum;
        }
        public static T product<T>(this IEnumerable<T> list)
        {

            dynamic product1 = 1;
            foreach (dynamic item in list)
            {
                product1 *= item;
            }
            return (T)product1;
        }
        public static T min<T>(this IEnumerable<T> list)
          where T : IComparable, new()
        {

            List<T> list2 = new List<T>();
            foreach (var item in list)
            {
                list2.Add(item);
            }
            T min = list2[0];
            for (int i = 0; i < list2.Count; i++)
            {

                if (min.CompareTo(list2[i]) > 0)
                {
                    list2[i] = min;
                }
            }

            return min;
        }
        public static T max<T>(this IEnumerable<T> list)
         where T : IComparable, new()
        {

            List<T> list2 = new List<T>();
            foreach (var item in list)
            {
                list2.Add(item);
            }
            T max = list2[0];
            for (int i = 0; i < list2.Count; i++)
            {

                if (max.CompareTo(list2[i]) < 0)
                {
                    max = list2[i];
                }
            }
            return max;
        }
        public static double average<T>(this IEnumerable<T> list)
        where T : IComparable, new()
        {

            List<T> list2 = new List<T>();
            foreach (var item in list)
            {
                list2.Add(item);
            }
            T max = list2[0];

            double average = 0;
            for (int i = 0; i < list2.Count; i++)
            {
                average += double.Parse(list2[i].ToString()) / list2.Count;
            }
            return average;
        }


    }
}
