namespace LinqHomeWork
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    using System.Timers;
   class LinqMain_TEST
    {
        public static bool isDivided_7_3(int integer)
        {
            bool a = false;
            if (integer % 7 == 0 || integer % 3 == 0)
            {
                a = true;
            }
            return a;
        }

        static void Main()
        {
            //StringBuilder sb = new StringBuilder();

            //sb.Append("Христо Сокеров и Катя Иванова работят в болница царица Йоанна");

            //Console.WriteLine(sb.ToString());

            //sb.Substring(1, 2);

            //Console.WriteLine(sb.Substring(2,5).ToString());

            //string[] students = new string[] {"Nikolaj Gospodinov Age 23","Anton Strashimirov Age 19","Tanq Stanoeva Age 29","Filip Shmatkov Age 16" };



            //Console.WriteLine(Student_Linq.getstudents(students));

  //eX6 EXTENTION METHODS
            //---------------------------------------------
            //int[] integer = new int[]
            //{
            //    6,12,34,56,67,78,21,43,65,89,54
            //};

            //List<int> mylist=new List<int>();
            //for (int i = 0; i < integer.Length; i++)
            //{
            //    mylist.Add(integer[i]);
            //}

            //List<int> nelist = mylist.FindAll(isDivided_7_3);
            //foreach (var item in nelist)
            //{
            // Console.WriteLine("{0}", item.ToString());
            //}
            //---------------------------------------------

//Ex6 - LINQ
            //-----------------------------------------------------------------------------------
            //int[] integer = new int[]
            //{
            //    6,12,34,56,67,78,21,43,65,89,54
            //};
            //var number =
            //    from num in integer
            //    let x=num%7
            //    let y=num%3
            //    where x==0 || y==0
            //    select num;
            //StringBuilder sb = new StringBuilder();
            //foreach (var item in number)
            //{
            //    sb.Append(item);
            //    sb.Append(" ");
            //    sb.Append("\n");
            //}
            //Console.WriteLine("{0}", sb.ToString());
            //-------------------------------------------------------------------------------------------
            //List<double> a = new List<double>();
            //a.Add(1.34);
            //a.Add(2.232);
            //a.Add(2);
            //a.Add(2);
            //a.Add(2);
            //a.Add(12);
            //a.Add(2);
            //Console.WriteLine(a.average<double>());
//Ex7
            //-----------------------------------------------------------------------------------------
            Timer  atimer = new System.Timers.Timer(1000);

            atimer.Elapsed += (s, e) =>
            {
                TimerClass.ReturnString();
            };
            atimer.Start();
            while (Console.Read() != 'q')
            {
                ;    // do nothing...
            }
            //Console.WriteLine("Press the Enter key to exit the program.");
            //Console.ReadLine();

//Ex9 LinQ
            //------------------------------------------------------------------------------------



            //List<Student> student_List = new List<Student>
            //{

            //     new Student { FirstName = "Nikolay", LastName = "Grigorov", Email = "slavi@gmail.com", FN = 90453, Groupnumber = 1,Marks=new List<int> { 3, 2, 4, 2, 2, 6 }, Tel = "+35988832433" },

            //     new Student { FirstName = "Darina", LastName = "Manolova", Email = "darina@gmail.com", FN = 84352, Groupnumber = 2, Marks = new List<int>{ 6, 6, 4, 6, 2, 6 }, Tel = "+35988732420" },

            //      new Student { FirstName = "Angel", LastName = "Panaiotov", Email = "panaiot@hotmail.com", FN = 34522, Groupnumber = 2, Marks =new List<int> { 4, 4, 4, 2, 5, 6 }, Tel = "+35978632433" },

            //     new Student { FirstName = "Maria", LastName = "Petrova", Email = "maria@gmail.com", FN = 34223, Groupnumber = 1, Marks =new List<int> { 5, 2, 4, 5, 5, 6 }, Tel = "+35987832403" },

            //      new Student { FirstName = "Stefan", LastName="Krumov", Email = "stefan@yahoo.co.uk", FN = 93423, Groupnumber = 2, Marks = new List<int>{ 3, 6, 4, 6, 6, 6 }, Tel = "+35988830000" }

            //};
            //var students =
            //    from student in student_List
            //    where student.Groupnumber == 2
            //    orderby student.FirstName
            //    select student;


            //StringBuilder sb = new StringBuilder();
            //foreach (var item in students)
            //{
            //    sb.Append("\nFirst Name =" + item.FirstName + "\n" + "Last Name =" + " " + item.LastName + "\n " + "FN =" + item.FN + "\n" + "Group number" + " " + item.Groupnumber + "\n");
            //    for (int i = 0; i < item.Marks.Count; i++)
            //    {
            //        sb.Append("  Marks = ");
            //        sb.Append(item.Marks[i]);
            //    }
            //    sb.Append("\n");
            //    sb.Append("--------------------------------------------------");
            //}


            //Console.WriteLine(sb);

            //Console.ReadLine();
 //Ex10
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //    List<Student> student_List = new List<Student>
            //    {

            //         new Student { FirstName = "Nikolay", LastName = "Grigorov", Email = "slavi@gmail.com", FN = 90453, Groupnumber = 1,Marks=new List<int> { 3, 2, 4, 2, 2, 6 }, Tel = "+35988832433" },

            //         new Student { FirstName = "Darina", LastName = "Manolova", Email = "darina@gmail.com", FN = 84352, Groupnumber = 2, Marks = new List<int>{ 6, 6, 4, 6, 2, 6 }, Tel = "+35988732420" },

            //          new Student { FirstName = "Angel", LastName = "Panaiotov", Email = "panaiot@hotmail.com", FN = 34522, Groupnumber = 2, Marks =new List<int> { 4, 4, 4, 2, 5, 6 }, Tel = "+35978632433" },

            //         new Student { FirstName = "Maria", LastName = "Petrova", Email = "maria@gmail.com", FN = 34223, Groupnumber = 1, Marks =new List<int> { 5, 2, 4, 5, 5, 6 }, Tel = "+35987832403" },

            //          new Student { FirstName = "Stefan", LastName="Krumov", Email = "stefan@yahoo.co.uk", FN = 93423, Groupnumber = 2, Marks = new List<int>{ 3, 6, 4, 6, 6, 6 }, Tel = "+35988830000" }

            //    };

            //List<Student> student3=student_List.OrderBy(student => student.FirstName).Where(student => student.Groupnumber == 2).Select(student => student).ToList();
            //    StringBuilder sb = new StringBuilder();
            //    foreach (var item in student3)
            //    {
            //        sb.Append("\nFirst Name =" + item.FirstName + "\n" + "Last Name =" + " " + item.LastName + "\n " + "FN =" + item.FN + "\n" + "Group number" + " " + item.Groupnumber + "\n");
            //        for (int i = 0; i < item.Marks.Count; i++)
            //        {
            //            sb.Append("  Marks = ");
            //            sb.Append(item.Marks[i]);
            //        }
            //        sb.Append("\n");
            //        sb.Append("--------------------------------------------------");
            //    }


            //    Console.WriteLine(sb);
            //    Console.ReadLine();
//Ext11
            //-----------------------------------------------------------------------------------------------------------------------------
            //List<Student> student_List = new List<Student>
            //    {

            //         new Student { FirstName = "Nikolay", LastName = "Grigorov", Email = "slavi@gmail.com", FN = 90453, Groupnumber = 1,Marks=new List<int> { 3, 2, 4, 2, 2, 6 }, Tel = "+35988832433" },

            //         new Student { FirstName = "Darina", LastName = "Manolova", Email = "darina@abv.bg", FN = 84352, Groupnumber = 2, Marks = new List<int>{ 6, 6, 4, 6, 2, 6 }, Tel = "+35988732420" },

            //          new Student { FirstName = "Angel", LastName = "Panaiotov", Email = "panaiot@hotmail.com", FN = 34522, Groupnumber = 2, Marks =new List<int> { 4, 4, 4, 2, 5, 6 }, Tel = "+35978632433" },

            //         new Student { FirstName = "Maria", LastName = "Petrova", Email = "maria@abv.bg", FN = 34223, Groupnumber = 1, Marks =new List<int> { 5, 2, 4, 5, 5, 6 }, Tel = "+35987832403" },

            //          new Student { FirstName = "Stefan", LastName="Krumov", Email = "stefan@yahoo.co.uk", FN = 93423, Groupnumber = 2, Marks = new List<int>{ 3, 6, 4, 6, 6, 6 }, Tel = "+35988830000" }

            //    };


            //var studentabv =
            //    from student in student_List
            //    let y = student.Email
            //    where y.IndexOf("@abv.bg") > 0
            //    select student;

            //StringBuilder sb = new StringBuilder();
            //foreach (var item in studentabv)
            //{
            //    sb.Append("\nFirst Name =" + item.FirstName + "\n" + "Last Name =" + " " + item.LastName + "\n " + "FN =" + item.FN + "\n" + "Group number" + " " + item.Groupnumber + "\n" + "Email =" + item.Email + "\n");
            //    for (int i = 0; i < item.Marks.Count; i++)
            //    {
            //        sb.Append("  Marks = ");
            //        sb.Append(item.Marks[i]);
            //    }
            //    sb.Append("\n");
            //    sb.Append("--------------------------------------------------");
            //}


            //Console.WriteLine(sb);
            //Console.ReadLine();
//Ext12
            //-----------------------------------------------------------------------------------------------------------------------------
            //List<Student> student_List = new List<Student>
            //    {

            //         new Student { FirstName = "Nikolay", LastName = "Grigorov", Email = "slavi@gmail.com", FN = 90453, Groupnumber = 1,Marks=new List<int> { 3, 2, 4, 2, 2, 6 }, Tel = "0294332433"},

            //         new Student { FirstName = "Darina", LastName = "Manolova", Email = "darina@abv.bg", FN = 84352, Groupnumber = 2, Marks = new List<int>{ 6, 6, 4, 6, 2, 6 }, Tel = "0288732420"},

            //          new Student { FirstName = "Angel", LastName = "Panaiotov", Email = "panaiot@hotmail.com", FN = 34522, Groupnumber = 2, Marks =new List<int> { 4, 4, 4, 2, 5, 6 }, Tel = "0778632433"},

            //         new Student { FirstName = "Maria", LastName = "Petrova", Email = "maria@abv.bg", FN = 34223, Groupnumber = 1, Marks =new List<int> { 5, 2, 4, 5, 5, 6 }, Tel = "024332403" },

            //          new Student { FirstName = "Stefan", LastName="Krumov", Email = "stefan@yahoo.co.uk", FN = 93423, Groupnumber = 2, Marks = new List<int>{ 3, 6, 4, 6, 6, 6 }, Tel = "08883000045" }

            //    };


            //var studentabv =
            //    from student in student_List
            //    let y = student.Tel
            //    where y.StartsWith("02")
            //    select student;

            //StringBuilder sb = new StringBuilder();
            //foreach (var item in studentabv)
            //{
            //    sb.Append("\nFirst Name =" + item.FirstName + "\n" + "Last Name =" + " " + item.LastName + "\n " + "FN =" + item.FN + "\n" + "Group number" + " " + item.Groupnumber + "\n" + "Email =" + item.Email + "\n"+"Tel ="+item.Tel+"\n");
            //    for (int i = 0; i < item.Marks.Count; i++)
            //    {
            //        sb.Append("  Marks = ");
            //        sb.Append(item.Marks[i]);
            //    }
            //    sb.Append("\n");
            //    sb.Append("--------------------------------------------------");
            //}
            //Console.WriteLine(sb);
            //Console.ReadLine();   

//Ex13-----------------------------------------------------------------------------------------------


            //List<Student> student_List = new List<Student>
            //    {

            //         new Student { FirstName = "Nikolay", LastName = "Grigorov", Email = "slavi@gmail.com", FN = 90453, Groupnumber = 1,Marks=new List<int> { 3, 2, 4, 2, 2, 2 }, Tel = "0294332433"},

            //         new Student { FirstName = "Darina", LastName = "Manolova", Email = "darina@abv.bg", FN = 84352, Groupnumber = 2, Marks = new List<int>{ 6, 6, 4, 6, 2, 6 }, Tel = "0288732420"},

            //          new Student { FirstName = "Angel", LastName = "Panaiotov", Email = "panaiot@hotmail.com", FN = 34522, Groupnumber = 2, Marks =new List<int> { 4, 4, 4, 2, 5, 6 }, Tel = "0778632433"},

            //         new Student { FirstName = "Maria", LastName = "Petrova", Email = "maria@abv.bg", FN = 34223, Groupnumber = 1, Marks =new List<int> { 5, 2, 4, 5, 5, 6 }, Tel = "024332403" },

            //          new Student { FirstName = "Stefan", LastName="Krumov", Email = "stefan@yahoo.co.uk", FN = 93423, Groupnumber = 2, Marks = new List<int>{ 3, 6, 4, 6, 6, 6 }, Tel = "08883000045" }

            //    };


            //var studentabv =
            //    from student in student_List
            //    let y = student.Bigest_Mark(student.Marks)
            //    where y == 6
            //    select new 
            //    {
            //        Fulname=student.FirstName+" "+student.LastName,
            //        Marks=student.Marks
            //    };
            //StringBuilder sb = new StringBuilder();
            //foreach (var item in studentabv)
            //{
            //    sb.Append("\nFull Name =" + item.Fulname + "\n");
            //    for (int i = 0; i < item.Marks.Count; i++)
            //    {
            //        sb.Append("  Marks = ");
            //        sb.Append(item.Marks[i]);
            //    }
            //    sb.Append("\n");
            //    sb.Append("--------------------------------------------------");
            //}


            //Console.WriteLine(sb);
            //Console.ReadLine();              
//Ext14---------------------------------------------------------------------------------------------
            //   List<Student> student_List = new List<Student>
            //       {

            //            new Student { FirstName = "Nikolay", LastName = "Grigorov", Email = "slavi@gmail.com", FN = 90453, Groupnumber = 1,Marks=new List<int> { 3, 2, 4, 2, 2, 2 }, Tel = "0294332433"},

            //            new Student { FirstName = "Darina", LastName = "Manolova", Email = "darina@abv.bg", FN = 84352, Groupnumber = 2, Marks = new List<int>{ 6, 6, 4, 6, 2, 6 }, Tel = "0288732420"},

            //             new Student { FirstName = "Angel", LastName = "Panaiotov", Email = "panaiot@hotmail.com", FN = 34522, Groupnumber = 2, Marks =new List<int> { 4, 4, 4, 2, 5, 6 }, Tel = "0778632433"},

            //            new Student { FirstName = "Maria", LastName = "Petrova", Email = "maria@abv.bg", FN = 34223, Groupnumber = 1, Marks =new List<int> { 5, 2, 4, 5, 5, 6 }, Tel = "024332403" },

            //             new Student { FirstName = "Stefan", LastName="Krumov", Email = "stefan@yahoo.co.uk", FN = 93423, Groupnumber = 2, Marks = new List<int>{ 3, 6, 4, 6, 6, 6 }, Tel = "08883000045" }

            //       };

            //var student3=student_List.OrderBy(student=>student.FirstName +" "+student.LastName)
                    //.Where(student=>student.Lesser_Mark(student.Marks)==2)
                    //.Select(student=>student);

            //   StringBuilder sb = new StringBuilder();
            //   foreach (var item in student3)
            //   {
            //       sb.Append("\nFull Name =" + item.FirstName + "\n"+item.LastName);
            //       for (int i = 0; i < item.Marks.Count; i++)
            //       {
            //           sb.Append("  Marks = ");
            //           sb.Append(item.Marks[i]);
            //       }
            //       sb.Append("\n");
            //       sb.Append("--------------------------------------------------");
            //   }


            //   Console.WriteLine(sb);
            //   Console.ReadLine();              
//ext15-----------------------------------------------------------------------------------------------

            //List<Student> student_List = new List<Student>
            //       {

            //            new Student { FirstName = "Nikolay", LastName = "Grigorov", Email = "slavi@gmail.com", FN = 1290406, Groupnumber = 1,Marks=new List<int> { 3, 2, 4, 2, 2, 2 }, Tel = "0294332433"},

            //            new Student { FirstName = "Darina", LastName = "Manolova", Email = "darina@abv.bg", FN = 1284352, Groupnumber = 2, Marks = new List<int>{ 6, 6, 4, 6, 2, 6 }, Tel = "0288732420"},

            //             new Student { FirstName = "Angel", LastName = "Panaiotov", Email = "panaiot@hotmail.com", FN = 1234506, Groupnumber = 2, Marks =new List<int> { 4, 4, 4, 2, 5, 6 }, Tel = "0778632433"},

            //            new Student { FirstName = "Maria", LastName = "Petrova", Email = "maria@abv.bg", FN = 3234223, Groupnumber = 1, Marks =new List<int> { 5, 2, 4, 5, 5, 6 }, Tel = "024332403" },

            //             new Student { FirstName = "Stefan", LastName="Krumov", Email = "stefan@yahoo.co.uk", FN = 4393406, Groupnumber = 2, Marks = new List<int>{ 3, 6, 4, 6, 6, 6 }, Tel = "08883000045" }

            //       };

            //List<Student> student3 = student_List.OrderBy(student => student.FirstName).Where(student => student.get_2006(student.FN)).Select(student => student).ToList();


            //StringBuilder sb = new StringBuilder();
            //foreach (var item in student3)
            //{
            //    sb.Append("\nFull Name =" + item.FirstName + "\n" + item.LastName);
            //    for (int i = 0; i < item.Marks.Count; i++)
            //    {
            //        sb.Append("  Marks = ");
            //        sb.Append(item.Marks[i]);
            //    }
            //    sb.Append("\n");
            //    sb.Append("--------------------------------------------------");
            //}


            //Console.WriteLine(sb);
            //Console.ReadLine();              

//16----------------------------------------------------------------------------------------------------------------------------
            //var group = new List<Group>
            //{
            //    new Group{GroupNumber=1,Departament="Mathematics"},
            //    new Group{GroupNumber=2,Departament="Physicist"},
            //    new Group{GroupNumber=3,Departament="Biologiks"}
            //};
            //var student_List = new List<Student>
            //       {

            //            new Student { FirstName = "Nikolay", LastName = "Grigorov", Email = "slavi@gmail.com", FN = 1290406, Groupnumber = 1,Marks=new List<int> { 3, 2, 4, 2, 2, 2 }, Tel = "0294332433", Group_studen=group[0]},

            //            new Student { FirstName = "Darina", LastName = "Manolova", Email = "darina@abv.bg", FN = 1284352, Groupnumber = 2, Marks = new List<int>{ 6, 6, 4, 6, 2, 6 }, Tel = "0288732420", Group_studen=group[2]},

            //             new Student { FirstName = "Angel", LastName = "Panaiotov", Email = "panaiot@hotmail.com", FN = 1234506, Groupnumber = 2, Marks =new List<int> { 4, 4, 4, 2, 5, 6 }, Tel = "0778632433",Group_studen=group[2]},

            //            new Student { FirstName = "Maria", LastName = "Petrova", Email = "maria@abv.bg", FN = 3234223, Groupnumber = 1, Marks =new List<int> { 5, 2, 4, 5, 5, 6 }, Tel = "024332403", Group_studen=group[1]},

            //             new Student { FirstName = "Stefan", LastName="Krumov", Email = "stefan@yahoo.co.uk", FN = 4393406, Groupnumber = 2, Marks = new List<int>{ 3, 6, 4, 6, 6, 6 }, Tel = "08883000045", Group_studen=group[0]}

            //       };

            //var list_departament = student_List.Join(
            //    group,
            //    (st => st.Group_studen.Departament),
            //    (gr => gr.Departament),
            //      (st, gr) =>
            //           new
            //           {
            //               St = st.FirstName,
            //               gp = gr.Departament
            //           }).Select(a => new
            //           {
            //               Departament = a.gp,
            //               student = a.St

            //           }).Where(gr=>gr.Departament=="Mathematics");




            //StringBuilder sb = new StringBuilder();
            //foreach (var item in list_departament)
            //{
            //    sb.Append("\nFull Name =" + item.student + "\n" + item.Departament);

            //    sb.Append("\n");
            //    sb.Append("--------------------------------------------------");


            //}


            //Console.WriteLine(sb);
            //Console.ReadLine();
//17---------------------------------------------------------------------------------------------
            //string[] arry_string = new string[]
            //{
            //    "Nikolaj","Georgi is .Net programer","Sofia is the capital of Bulgaria"
            //};

            //var bigeststring =
            //    (from arr in arry_string
            //     select arr).Max();
            //Console.WriteLine(bigeststring.ToString());
            //Console.ReadLine();
            //19----------------------------------------------------------
            //string[] arry_string = new string[]
            //{
            //    "Nikolaj","Georgi is .Net programer","Sofia is the capital of Bulgaria"
            //};

            //var bigeststring = arry_string.Max();

            //Console.WriteLine(bigeststring.ToString());
            //Console.ReadLine();
//18--------------------------------------------------------------------------------------------------------
            //var group = new List<Group>
            //{
            //    new Group{GroupNumber=1,Departament="Mathematics"},
            //    new Group{GroupNumber=2,Departament="Physicist"},
            //    new Group{GroupNumber=3,Departament="Biologiks"}
            //};
            //var student_List = new List<Student>
            //       {

            //            new Student { FirstName = "Nikolay", LastName = "Grigorov", Email = "slavi@gmail.com", FN = 1290406, Groupnumber = 1,Marks=new List<int> { 3, 2, 4, 2, 2, 2 }, Tel = "0294332433", Group_studen=group[0]},

            //            new Student { FirstName = "Darina", LastName = "Manolova", Email = "darina@abv.bg", FN = 1284352, Groupnumber = 2, Marks = new List<int>{ 6, 6, 4, 6, 2, 6 }, Tel = "0288732420", Group_studen=group[2]},

            //             new Student { FirstName = "Angel", LastName = "Panaiotov", Email = "panaiot@hotmail.com", FN = 1234506, Groupnumber = 2, Marks =new List<int> { 4, 4, 4, 2, 5, 6 }, Tel = "0778632433",Group_studen=group[2]},

            //            new Student { FirstName = "Maria", LastName = "Petrova", Email = "maria@abv.bg", FN = 3234223, Groupnumber = 1, Marks =new List<int> { 5, 2, 4, 5, 5, 6 }, Tel = "024332403", Group_studen=group[1]},

            //             new Student { FirstName = "Stefan", LastName="Krumov", Email = "stefan@yahoo.co.uk", FN = 4393406, Groupnumber = 2, Marks = new List<int>{ 3, 6, 4, 6, 6, 6 }, Tel = "08883000045", Group_studen=group[0]}

            //       };

            //var list_departament = student_List.Join(
            //    group,
            //    (st => st.Group_studen.Departament),
            //    (gr => gr.Departament),
            //      (st, gr) =>
            //           new
            //           {
            //               St = st.FirstName,
            //               gp = gr.Departament
            //           }).Select(a => new
            //           {
            //               Departament = a.gp,
            //               student = a.St

            //           }).Where(gr => gr.Departament == "Mathematics");
//19---------------------------------------------------------------------------------------------
            //var list_departament =
            //    from student in student_List
            //    group student by student.Group_studen.Departament into newGroup
            //    orderby newGroup.Key
            //    select newGroup;



            //StringBuilder sb = new StringBuilder();
            //foreach (var item in list_departament)
            //{  
            //    sb.Append("\nFull Name =" + item.Key);

            //    foreach (var student in item)
            //    {
            //        sb.Append(string.Format("\nFirst name ={0}  Last Name = {1}", student.FirstName, student.LastName));
            //    }

            //    sb.Append("\n");
            //    sb.Append("--------------------------------------------------");


            //}


            //Console.WriteLine(sb);
            //Console.ReadLine();
//19----------------------------------------------------------------------------------------------------
            //var group = new List<Group>
            //{
            //    new Group{GroupNumber=1,Departament="Mathematics"},
            //    new Group{GroupNumber=2,Departament="Physicist"},
            //    new Group{GroupNumber=3,Departament="Biologiks"}
            //};
            //var student_List = new List<Student>
            //       {

            //            new Student { FirstName = "Nikolay", LastName = "Grigorov", Email = "slavi@gmail.com", FN = 1290406, Groupnumber = 1,Marks=new List<int> { 3, 2, 4, 2, 2, 2 }, Tel = "0294332433", Group_studen=group[0]},

            //            new Student { FirstName = "Darina", LastName = "Manolova", Email = "darina@abv.bg", FN = 1284352, Groupnumber = 2, Marks = new List<int>{ 6, 6, 4, 6, 2, 6 }, Tel = "0288732420", Group_studen=group[2]},

            //             new Student { FirstName = "Angel", LastName = "Panaiotov", Email = "panaiot@hotmail.com", FN = 1234506, Groupnumber = 2, Marks =new List<int> { 4, 4, 4, 2, 5, 6 }, Tel = "0778632433",Group_studen=group[2]},

            //            new Student { FirstName = "Maria", LastName = "Petrova", Email = "maria@abv.bg", FN = 3234223, Groupnumber = 1, Marks =new List<int> { 5, 2, 4, 5, 5, 6 }, Tel = "024332403", Group_studen=group[1]},

            //             new Student { FirstName = "Stefan", LastName="Krumov", Email = "stefan@yahoo.co.uk", FN = 4393406, Groupnumber = 2, Marks = new List<int>{ 3, 6, 4, 6, 6, 6 }, Tel = "08883000045", Group_studen=group[0]}

            //       };


            //var list_departament = student_List.GroupBy(p => p.Group_studen.Departament, p => p.FirstName);


            //StringBuilder sb = new StringBuilder();
            //foreach (var item in list_departament)
            //{
            //    sb.Append("\nGroupName =" + item.Key);
            //    foreach (var name in item)
            //    {
            //        sb.Append("\nUser =" +" "+ name+" ");
            //    }

            //    sb.Append("\n");
            //    sb.Append("--------------------------------------------------");


            //}


            //Console.WriteLine(sb);
            //Console.ReadLine();





        }
    }
}
