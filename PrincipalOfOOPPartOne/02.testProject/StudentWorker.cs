
namespace _02.testProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using StudentAndWorkers;

   public  class StudentWorker
    {
        static void Main(string[] args)
        {

            List<Student> studentsList = new List<Student>();

            studentsList.Add(new Student("Georgi", "Pashov", 4));
            studentsList.Add(new Student("Petar", "Pashov", 2));
            studentsList.Add(new Student("Maria", "Paunova", 6));
            studentsList.Add(new Student("Tihomir", "Stoqnov", 3));
            studentsList.Add(new Student("Ivan", "Draganov", 1));
            studentsList.Add(new Student("Miroslav", "Marinov", 8));
            studentsList.Add(new Student("Stamat", "Zahov", 9));
            studentsList.Add(new Student("Stojka", "Putinova", 12));
            studentsList.Add(new Student("Marin", "Fergusyn", 66));
            studentsList.Add(new Student("Carica", "Joanna", 12));


            var listOfStudents = (from itme in studentsList
                                  select itme).OrderBy(s => s.Grade);


            foreach (var item in listOfStudents)
            {
                Console.WriteLine(string.Format("{0} , {1}",item.FirstName,item.Grade));
            }


            List<Worker> workerList = new List<Worker>();

            workerList.Add(new Worker("Marin", "Goshev", 100, 4));
            workerList.Add(new Worker("Dragan", "Ivanchov", 90, 2));
            workerList.Add(new Worker("Stamat", "Balev", 20, 2.6M));
            workerList.Add(new Worker("Samuel", "Petrov", 43, 2.99M));
            workerList.Add(new Worker("Gazar", "Marinchov", 78, 2.33M));
            workerList.Add(new Worker("Dunlan", "Maklaud", 12, 0.66M));
            workerList.Add(new Worker("Pamela", "Anderson", 45, 9.99M));
            workerList.Add(new Worker("Goran", "Bregovich", 1000, 4.645M));
            workerList.Add(new Worker("Maia", "Novoselska", 55.87M, 6.99M));
            workerList.Add(new Worker("Sara", "Brown", 1004, 4.9M));

            var listofWorkers = workerList.OrderBy(w => w.MoneyPerHour());

            foreach(Worker Worker in listofWorkers)
            {
                Console.WriteLine("\n------------------------------------" + "\nFirst Name= {0}  Money per Hour ={1}", Worker.FirstName, Worker.MoneyPerHour());
            }
            List<Human> humanlist = new List<Human>
            {
                   new Student("Georgi", "Dimitrov", 2),
                 new Student("Gergana", "Stoimenova", 5),
                 new Student("Maria", "Petrova", 5),
                 new Student("Stanismir", "Lazarov", 6),
                new Student("Nikolai", "Motkurov", 6),
                new Student("Katia", "Velikova", 3),
                new Student("Valentina", "Dimitrova", 4),
                 new Student("Zdravko", "Zdravkov", 3),
                 new Student("Zahari", "Panajotov", 2),
                 new Student("Ivancho", "Mariikov", 4),
                   new Worker("Stanimir","Georgiev",145.4M,23),
                 new Worker("Galia","Petrova",250.4M,23),
                  new Worker("Atanas","Pyrvanov",300.4M,13),
                   new Worker("Georgi","Ivanov",145.4M,6),
                    new Worker("Stoil","Novobranski",134.4M,3),
                     new Worker("Hristo","Iwanov",188.4M,2),
                      new Worker("Maria","Hubawata",256.4M,3),
                       new Worker("Kalin","GreenTeam",167.4M,8),
                        new Worker("Petrana","Nikolova",254.5M,2),
                         new Worker("STanislav","Hadjikostov",265.3M,9)
            };
            var human = humanlist.OrderByDescending(h => h.FirstName).ThenBy(h => h.LastName);

            foreach (var item in human)
            {

                Console.WriteLine("\n------------------------------------" + "\n First Name= {0}  Possition={1}", item.FirstName, item.GetType().Name);

            }

        }
    }
}
