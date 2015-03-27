namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Disiplince 
    {

        private string textComent;
        private string name;

        private int numberOfLectures;

        private int numberOfExercice;



        public Disiplince()
        {

        }

        public Disiplince(string name,int numberOfLectures,int numberOfExersice,string textComent)
        {
            this.Name = name;
            this.NumberOfExercice = numberOfExersice;
            this.NumberOfLectures = NumberOfLectures;
            this.TextComents = textComent;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int NumberOfExercice
        {
            get { return numberOfExercice; }
            set { numberOfExercice = value; }
        }

        public int NumberOfLectures
        {
            get { return numberOfLectures; }
            set { numberOfLectures = value; }
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
