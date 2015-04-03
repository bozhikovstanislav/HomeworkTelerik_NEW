

namespace ComonTypeSystem.Classes
{
    using System;
    using Enum;
    public  class Student
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string MidleName { get; set; }
        public int SSN { get; set; }
        public decimal MobilePhone { get; set; }
        public int Course { get; set; }
        public string Email { get; set; }
        public Universties University { get; private set; }
        public Specialitycs Speciality { get; private set; }
        public Faculties Faculty { get; private set; }

        public Student(string firstname, string lastname, string midlename, int ssn,
            decimal mobilephone, int course, string email, Specialitycs spe, Faculties fac, Universties univ)
        {
            this.Firstname = firstname;
            this.LastName = lastname;
            this.MidleName = midlename;
            this.SSN = ssn;
            this.MobilePhone = mobilephone;
            this.Course = course;
            this.Email = email;
            this.University = univ;
            this.Faculty = fac;
            this.Speciality = spe;
        }
        public override bool Equals(object obj)
        {
            Student studet = obj as Student;

            if (studet == null)
            {
                return false;
            }
            if (!object.Equals(this.Firstname, studet.Firstname))
            {
                return false;
            }
            if (!object.Equals(this.LastName, studet.LastName))
            {
                return false;
            }
            if (!object.Equals(this.MidleName, studet.MidleName))
            {
                return false;
            }
            if (this.SSN != studet.SSN)
            {
                return false;
            }
            if (this.MobilePhone != studet.MobilePhone)
            {
                return false;
            }
            if (this.Course != studet.Course)
            {
                return false;
            }
            if (!object.Equals(this.Email, studet.Email))
            {
                return false;
            }
            if (!object.Equals(this.Faculty, studet.Faculty))
            {
                return false;
            }
            if (!object.Equals(this.University, studet.University))
            {
                return false;
            }
            if (!object.Equals(this.Speciality, studet.Speciality))
            {
                return false;
            }
            return true;
        }
        public override int GetHashCode()
        {

            return Firstname.GetHashCode() ^ LastName.GetHashCode() ^ MidleName.GetHashCode()
                ^ SSN.GetHashCode() ^ Email.GetHashCode() ^ Course.GetHashCode() ^ Faculty.GetHashCode() ^ Speciality.GetHashCode();
        }
        public override string ToString()
        {
            return "\nStudent First Name =" + " " + Firstname +
                    "\n" + "Student Last Name =" + " " + LastName +
                    "\n" + "Student Midle Name=" + " " + MidleName +
                    "\n" + "Student SSN= " + SSN.ToString() +
                    "\n" + "Student Email= " + Email +
                    "\n" + "Student Course =" + Course.ToString() +
                    "\n" + "Student Mobile Phone = " + MobilePhone +
                    "\n" + "Student University = " + University +
                    "\n" + "Student Faculty = " + Faculty +
                    "\n" + "Student Speciality = " + Speciality +
                    "\n---------------------------------------------";
        }
        public static bool operator ==(Student s1, Student s2)
        {
            return Student.Equals(s1, s2);
        }
        public static bool operator !=(Student s1, Student S2)
        {
            return !(Student.Equals(s1, S2));
        }

        public Student DeepCopy()
        {
            Student student = (Student)this.MemberwiseClone();
            student.University = (Universties)this.University;
            student.Faculty = (Faculties)this.Faculty;
            student.Speciality = (Specialitycs)this.Speciality;
            return student;
        }
        public object Clone()
        {
            var copy = (Student)MemberwiseClone();

            return copy;
        }

        public int CompareTo(Student other)
        {
            Student s1 = (Student)other;


            if (s1.Firstname.CompareTo(this.Firstname) < 0)
            {
                return -1;
            }

            if (s1.Firstname.CompareTo(this.Firstname) > 0)
            {
                return 1;
            }
            if (s1.SSN.CompareTo(this.SSN) < 0)
            {
                return -1;
            }
            if (s1.SSN.CompareTo(this.SSN) > 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
