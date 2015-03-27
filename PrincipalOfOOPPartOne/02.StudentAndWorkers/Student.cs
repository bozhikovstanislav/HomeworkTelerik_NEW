using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentAndWorkers
{
    public class Student : Human
    {
        private int grade;


        public Student(string studentFirstName,string studentLastname,int grade)
            :base(studentFirstName,studentLastname)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }
    }
}
