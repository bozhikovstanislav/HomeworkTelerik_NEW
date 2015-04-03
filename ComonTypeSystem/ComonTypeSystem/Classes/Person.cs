namespace ComonTypeSystem.Classes
{
    public class Person
    {
        public string Name { get; set; }

        private int? age;

        public int? Age
        {
            get
            {
                return age;
            }
            set
            {
                if (Age != null)
                {
                    Age = value;
                }
                else
                {
                    Age = null;
                }
            }
        }

        public Person(string name, int? age)
        {
            this.age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            if (Age.Equals(null))
            {
                return "Name =" + Name + "\n" + "Age = there is no Age specify";
            }
            return "Name =" + Name + "\n" + "Age =" + Age;
        }
    }
}