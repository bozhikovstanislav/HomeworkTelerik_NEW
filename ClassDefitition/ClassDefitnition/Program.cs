namespace ClassDefitnition
{
    using System;

    public class Battery
    {
        public string ModelBatery { get;  set; }
        public uint HouerIdle { get; set; }
        public uint HouerTalk { get; set; }
    }
    public class Display
    {
        public uint SizeDisplay { get; set; }
        public uint NuberOfColors { get; set; }
    }
    public class GSM
    {
        public string Model { get; set; }
        public string Manifacturer { get; set; }
        public decimal Price { get; set; }
        public string Owner { get; set; }
        public Battery BatteryGSM { get; set; }
        public Display DispleyGSM { get; set; }
        public override string ToString()
        {
            Console.WriteLine("Model - {0}", this.Model);
            Console.WriteLine("Manifacturer - {0}", this.Manifacturer);
            Console.WriteLine("Pricce - {0:C}", this.Price);
            Console.WriteLine("Owner - {0}", this.Owner);
            Console.WriteLine("Battery Model - {0}", this.BatteryGSM.ModelBatery);
            Console.WriteLine("Battery - Houer Idel -  {0} mm", this.BatteryGSM.HouerIdle);
            Console.WriteLine("Battery - Houer Talk - {0} h", this.BatteryGSM.HouerTalk);
            Console.WriteLine("Displey - Number of Colors - {0}", this.DispleyGSM.NuberOfColors);
            Console.WriteLine("Displey - SizeDispley-  {0}", this.DispleyGSM.SizeDisplay);
            return base.ToString();
        }
    }
   
    class Program
    {
        static void Main()
        {
            GSM gsmNokia = new GSM();
            gsmNokia.BatteryGSM = new Battery();
            gsmNokia.DispleyGSM = new Display();
            gsmNokia.BatteryGSM.HouerIdle = 123;
            gsmNokia.BatteryGSM.HouerTalk = 4;
            gsmNokia.Manifacturer = "Sout Korea";
            gsmNokia.Model = "Samsung";
            gsmNokia.Owner = "Gosho";
            gsmNokia.Price = 124;
            gsmNokia.BatteryGSM.ModelBatery = "Highe Cuality Battery";
            gsmNokia.DispleyGSM.NuberOfColors = 245;
            gsmNokia.DispleyGSM.SizeDisplay = 10;
            gsmNokia.ToString();
        }
    }
}
