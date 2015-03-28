namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Cat:Animal,Isound
    {
        public Cat(int age, string name, Sex sex)
            : base(age, name, sex)
        {

        }
        public Cat(int age, string name)
            : base(age, name)
        {

        }
        public void AnimalSound()
        {
            Console.WriteLine("Miau Miau");
        }
    }
}
