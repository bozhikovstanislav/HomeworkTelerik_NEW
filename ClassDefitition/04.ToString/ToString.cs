namespace _04.ToString
{
    using System;


    class ToString
    {

        static void Main()
        {
            GSM gsmNokia = new GSM();
            gsmNokia.BatteryGSM = new Battery();
            gsmNokia.DispleyGSM = new Displey();
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
