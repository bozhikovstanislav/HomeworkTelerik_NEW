namespace LinqHomeWork
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int Groupnumber { get; set; }
        public GroupClass Group_studen { get; set; }
        public Student()
        { }
        public int Bigest_Mark(List<int> list)
        {
            int max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (max < list[i])
                {
                    max = list[i];
                }
            }
            return max;
        }
        public int Lesser_Mark(List<int> list)
        {
            int min = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (min > list[i])
                {
                    min = list[i];
                }
            }
            return min;
        }
        public bool get_2006(decimal fn)
        {
            string fn_1 = fn.ToString();
            char[] fn_2 = fn_1.ToCharArray();
            bool found = false;
            for (int i = 0; i < fn_2.Length; i++)
            {
                if (fn_2[5] == '0' && fn_2[6] == '6')
                {
                    found = true;
                }
            }
            return found;
        }

    }
}
