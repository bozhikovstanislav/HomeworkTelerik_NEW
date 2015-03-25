namespace LinqHomeWork
{
    using System;
    using System.Text;
    using System.Linq;


    public static class StudentLinq
    {
        public static string getstudents(string[] students)
        {

            StringBuilder sb = new StringBuilder();
//Ex3
            // --------------------------------------------------
            //var student2 =
            //     from student in students
            //     let x=student.Split(' ')
            //     orderby x[0] ascending 
            //     select  x[0]+" "+x[1]+" "+x[2]+" "+x[3];

//Ex4
            //-------------------------------------------------
            //var student2 =
            //     from student in students
            //     let x = student.Split(' ')
            //     orderby x[0] ascending
            //     where x[3].CompareTo("18")>0
            //     where x[3].CompareTo("24")<0
            //     select x[0] + " " + x[1] + " " + x[2] + " " + x[3];

//Ex5_LAMBDA sort firstname
            //---------------------------------------------------------------
            //var student2 =
            // students.OrderByDescending(student => student).ThenBy(student => student);
            //---------------------------------------------------------------------------
            //Ex5_LAMBDA sort lastname
            //--------------------------------------------------------------------
            var student2 =
             students.OrderByDescending(student => student.Split(' ').ElementAt(1)).ThenBy(student => student);
            //------------------------------------------------------------------
//ext5Linq
            //--------------------------------------------------------------------
            //var student2 =
            //     from student in students
            //     let x = student.Split(' ')
            //     orderby x[0] descending
            //     where x[3].CompareTo("18") > 0
            //     where x[3].CompareTo("24") < 0
            //     select x[0] + " " + x[1] + " " + x[2] + " " + x[3];
            foreach (var item in student2)
            {
                sb.Append(item);
                sb.Append(" ");
                sb.Append("\n");
            }
            return sb.ToString();
        }

    }
}
