namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public  class People
    {
        private string name;

        private string textComent;

        public string TextComent
        {
            get { return textComent; }
            set { textComent = value; }
        }

        public People(string NameOfPeople)
        {
            this.Name = NameOfPeople;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual string TextComentOnPeople()
        {
            return this.textComent;
        }
    }
}
