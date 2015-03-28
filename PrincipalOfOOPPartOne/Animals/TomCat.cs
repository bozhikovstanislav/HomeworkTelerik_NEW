namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TomCat:Animal,Isound
    {
        public TomCat(int age, string name)
            : base(age, name)
        {
            this.Sex = Sex.male;
        }

        public void AnimalSound()
        {
            Console.WriteLine("TomCat sound=Miau Miau grrrrrrrrrrr");
        }
    }
}
