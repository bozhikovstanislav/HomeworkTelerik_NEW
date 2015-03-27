

namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    
    public class School
    {
        private List<Classes> classes;

        public School(List<Classes> clasesList)
        {
            this.Classes = clasesList;
        }
       
        public List<Classes> Classes
        {
            get { return classes; }
            set { classes = value; }
        }
    }
}
