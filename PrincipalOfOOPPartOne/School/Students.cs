namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Students : People
    {
        private string textComent;
        public Students(string name,string comentText):base(name)
        {
            this.TextComents = comentText;
        }


        public string TextComents
        {
            get
            {
                return textComent;
            }
            set
            {
                textComent = value;
            }
        }
    }
}
