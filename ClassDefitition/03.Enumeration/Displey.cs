namespace _03.Enumeration
{
   
    using System;

    enum BatteryTipe
    {
        LiIon, NiMH, NiCd
    }
    public class Displey
    {
        public uint SizeDisplay { get; set; }
        public uint NuberOfColors { get; set; }
        public Enum BatteryType { get; set; }
    }
}
