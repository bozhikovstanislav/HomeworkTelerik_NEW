namespace _02.Constructors
{
   using System;
   public class Displey
    {

        public uint? SizeDisplay { get; set; }
        public uint? NuberOfColors { get; set; }
        
        public Displey(uint? sizeDispley, uint? numbrOfColors)
        {
            this.SizeDisplay = sizeDispley;
            this.NuberOfColors = numbrOfColors;
         
        }
       public Displey()
        {

        }
    }
}
