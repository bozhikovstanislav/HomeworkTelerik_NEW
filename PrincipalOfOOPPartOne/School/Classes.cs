namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Classes
    {
        private string textIdentiFire;
        private int teachers;


        public Classes(int teachersInClass,string idnetifire)
        {
            this.Teachers = teachersInClass;
            this.TextIdentiFire = idnetifire;
        }


        public string TextIdentiFire
        {
            get { return textIdentiFire; }
            set { textIdentiFire = value; }
        }
        public int Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }
    }
}
