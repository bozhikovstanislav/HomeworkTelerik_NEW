namespace _04.ToString
{
   
    using System;

    enum BatteryTipe
    {
        LiIon, NiMH, NiCd
    }
    public class Displey
    {
        public uint? SizeDisplay { get; set; }
        public uint? NuberOfColors { get; set; }
        public Enum BatteryType { get; set; }


        public Displey(uint? sizeDispley,uint? numbrOfColors,Enum batteryType)
        {
            this.SizeDisplay = sizeDispley;
            this.NuberOfColors = numbrOfColors;
            this.BatteryType = batteryType;
        }
        public Displey()
        {

        }
    }
}
