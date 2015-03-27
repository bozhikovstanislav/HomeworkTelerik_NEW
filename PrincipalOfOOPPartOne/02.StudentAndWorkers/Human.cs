namespace _02.StudentAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Human
    {
        private string firstName;

        private string lastName;

        public Human(string firstname, string lastName)
        {
            this.FirstName = firstname;
            this.LastName = LastName;
        }
        public Human()
        {

        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


    }
}
