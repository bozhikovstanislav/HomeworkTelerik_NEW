
namespace AnimalTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Animals;
    class AnimalTest
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Cat(23,"Polina",Sex.fmale),
                new Cat(12,"Gosho",Sex.male),
                new Cat(9,"MAria",Sex.fmale),
                new Cat(8,"Atanas",Sex.male),
                new Kitten(32,"Petrana"),
                new Kitten(2,"Elena"),
                new Kitten(4,"Galia"),
                new Kitten(1,"Maria"),
                new Frog(1,"Marin",Sex.male),
               new Frog(23,"Marin",Sex.fmale),
               new Frog(2,"Marin",Sex.male),
               new TomCat(11,"Kalin"),
               new TomCat(5,"Marin"),
               new TomCat(8,"Grozdan"),
               new Dog(22,"Cezar",Sex.male),
               new Dog(23,"Jony",Sex.male),
               new Dog(9,"Varvara",Sex.fmale),
            };
            var anymals_list = animals.GroupBy(p => p.GetType(), p => p.Age).ToList();
            foreach (var animal in anymals_list)
            {
                Console.WriteLine("Animal  -  {0}", animal.Key.Name);
                List<int> list_Age = GetList_Animal_Age(anymals_list, animal);
                Console.WriteLine("Average  age= {0}", list_Age.Average());
            }
            Console.ReadLine();
        }

        private static List<int> GetList_Animal_Age(List<IGrouping<Type, int>> anymals_list, IGrouping<Type, int> item)
        {
            List<int> list_Age = new List<int>();
            for (int i = 0; i < anymals_list.Count; i++)
            {
                foreach (var list in item)
                {
                    list_Age.Add(list);
                }
            }
            return list_Age;
        }


    }
}

