namespace _02.Constructors
{

    using System;
  public class GSM
  {
      public string Model { get; set; }
      public string Manifacturer { get; set; }
      public decimal Price { get; set; }
      public string Owner { get; set; }
      public Battery BatteryGSM { get; set; }
      public Displey DispleyGSM { get; set; }

      public GSM()
      {

      }



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
}
