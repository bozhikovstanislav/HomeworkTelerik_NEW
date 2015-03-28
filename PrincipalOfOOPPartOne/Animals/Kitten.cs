

namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Kitten:Animal,Isound
    {
        public Kitten(int age, string name)
            : base(age, name)
        {
            this.Sex = Sex.fmale;
        }

        public void AnimalSound()
        {
            Console.WriteLine("Kitten sound=Miau,Miau");
        }
    }
}
