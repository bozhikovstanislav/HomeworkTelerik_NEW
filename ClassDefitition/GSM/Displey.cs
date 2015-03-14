namespace GSM
{
    using System;
    using System.Text;



    public class Displey
    {

        private uint numberOfColors;
        private uint size;
        public Displey(uint sizeDispley,uint numberOfColorsDispley)
        {
            this.Size = sizeDispley;
            this.NumberOfColors = numberOfColorsDispley;
        }

        public Displey()
        {

        }

        public uint NumberOfColors
        {
            get { return numberOfColors; }
            set
            {  
                
                numberOfColors = value;
                if(numberOfColors==0)
                {
                    throw new ArgumentException("The number of colors have to be biger then zero");
                }
               
            }
        }

        public uint Size
        {
            get { return size; }
            set
            {
                
                
                size = value; 
                if(this.size==0)
                {
                    throw new ArgumentException("The size number have to be positive an bigger then zero");
                }
               
                    
                
                
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Displey"); 
            sb.Append("\n");
            sb.Append("----------");
            sb.Append("\n");
            sb.Append(String.Format("size - {0:5}", this.size));
            sb.Append("\n");
            sb.Append(String.Format("Number of colors - {0:5}", this.numberOfColors));
           
            return sb.ToString();
        }
    }
}
