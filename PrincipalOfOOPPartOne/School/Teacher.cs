using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Teacher : People
    {
        private List<Disiplince> disiplines;

        private string textComents;
        public Teacher(string name,string comentText):base(name)
        {
            this.TextComents = comentText;
        }
        public string TextComents
        {
            get
            {
                return textComents;
            }
            set
            {
                textComents = value;
            }
        }
    }
}
