using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployData
{
    class EmployData
    {
        static void Main(string[] args)
        {
            //problem 10 Employee Data

            string firstName="Gosho";
            string lastName="Tosho";
            byte age=29;
            bool isFmale = false;
            char gender;
            char fmale='f';
            char male='m';
            char[] genderArry=new char[]{fmale,male};
            ulong personlaID=8306112507;
            uint employNumber = 27560003;

            //check the gender 
            if (isFmale)
            {
                gender = fmale;
            }
            else
            {
                gender = male;
            }
            Console.WriteLine("First Name : {0}", firstName);
            Console.WriteLine("Last Name : {0}", lastName);
            Console.WriteLine("Age : {0}", age);
            Console.WriteLine("Gender : {0}", gender);
            Console.WriteLine("Personal ID : {0}", personlaID);
            Console.WriteLine("Unique employee number : {0}", employNumber);
            Console.ReadLine();
        }
    }
}
