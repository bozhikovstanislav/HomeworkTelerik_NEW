namespace ComonTypeSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Classes;
    using Enum;
  public  class ComonTypeSystem
    {
        public  static void Main()
        {
           Student student = new Student("Gergana", "Stanoeva", "Manusheva", 23231343, 0885743573, 1, "geri@abv.bg", Specialitycs.Health_c, Faculties.Biol_invest, Universties.NC_physics);
            Student student2 = new Student("Aiko", "SMarinov", "Presianov", 23599764, 088674334, 2, "Nikolay@abv.bg", Specialitycs.Oil_geo, Faculties.Physic_med, Universties.MED_Bruc);
            Student studentclone = student2.DeepCopy();
            studentclone.Email = "This is a clone student";
            Console.WriteLine(student2);
            Console.WriteLine(studentclone);
            Console.WriteLine(student.CompareTo(student2));
            if (student.CompareTo(student2) < 0)
            {
                Console.WriteLine(student2);
                Console.WriteLine(student);

            }
            if (student.CompareTo(student2) > 0)
            {
                Console.WriteLine(student);
                Console.WriteLine(student2);
            }

            Person person = new Person("Hristo", null);
            Console.WriteLine(person);

            BitArray64 arr = new BitArray64(new ulong[] { 23, 43, 34 });
            BitArray64 arr2 = new BitArray64(new ulong[] { 23, 43, 34 });

            foreach (var item in arr)
            {
                //Console.WriteLine(item);
            }
            for (int i = 0; i < arr.Numbers.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }

            Console.WriteLine(arr == arr2);
            Console.ReadLine();
        }
    }
}
