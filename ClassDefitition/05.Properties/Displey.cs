namespace _05.Properties
{
    using System;

    public class Displey
    {
        private uint sizeDispley;
        private uint numberOfColors;


        public uint SizeDispley
        {
            get { return sizeDispley; }
            set { sizeDispley = value; }
        }
  
        public uint NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }
     

        public Displey(uint sizeDispley,uint numberOfColors)
        {

        }
    }
}
