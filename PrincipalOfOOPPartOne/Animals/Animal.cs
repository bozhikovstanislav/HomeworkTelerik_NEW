
namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
     
    public class Animal:IEnumerable<Animal>
    {
        private int age;
        private string name;
        List<Animal> list = new List<Animal>();


        public Animal(int age, string name, Sex sex)
        {
            this.age = age;
            this.name = name;
            this.Sex = sex;
        }
        public Animal(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Sex Sex
        {
            get
            {
                return Sex;
            }
            set
            {
            }
        }

      
        //public  double average(int age)
        //{
        //     double average=0;
        //    double sum=0;
        //    for (int i = 0; i < age.Count; i++)
        //    {
        //        sum += age[i];
        //    }
        //    average = Math.Round((sum / age.Count),2);
        //    return average;
        //}
        //public string getTypeName(string a)
        //{
        //    //List<string> newlist=new List<string>();
        //    //for (int i = 0; i < a.Count; i++)
        //    //{
        //    //    if (a[i] != a[i + 1])
        //    //    {
        //    //        newlist.Add(a[i + 1]);
        //    //    }

        //    //}
        //    //return newlist;
        //}




        public IEnumerator<Animal> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        
    }
}
