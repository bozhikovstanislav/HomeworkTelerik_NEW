namespace GSM
{
    using System;
    using System.Collections.Generic;

    class GsmProgram
    {
        static void Main()
        {
            GSM.GSMPhone.Iphone4S = new GSMPhone("Iphone 4", "USA");


            List<GSMPhone> phones = new List<GSMPhone>();

            Battery batery = new Battery();
            batery.BatteryType = BatteryEnum.LiIon;
            batery.HouersIdel = 100;
            batery.HouerTalk = 6;
            batery.Model = "Nokia";


            string[] manifacturerGSM = new string[11];
            manifacturerGSM[0] = "iOS";
            manifacturerGSM[1] = "Samsung";
            manifacturerGSM[2] = "China Factory";
            manifacturerGSM[3] = "Bulgarian Factory";
            manifacturerGSM[4] = "Motorola";
            manifacturerGSM[5] = "Lenovo";
            manifacturerGSM[6] = "Sofia engeniaring";
            manifacturerGSM[7] = "My preasuce ";
            manifacturerGSM[8] = "The big mome";
            manifacturerGSM[9] = "WHat a grate phone";
            manifacturerGSM[10] = "I do not know ";
            string[] models = new string[11];
            models[0] = "Nokia";
            models[1] = "Samsung";
            models[2] = "HTC";
            models[3] = "Motorola";
            models[4] = "Huway";
            models[5] = "Asus";
            models[6] = "Sony";
            models[7] = "Hitachi";
            models[8] = "VEF";
            models[9] = "Blate Q";
            int[] prices = new int[11];
            Random priceRand=new Random();
            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] = priceRand.Next(300, 500);
            }
            uint[] sizeDispley = new uint[11];
            sizeDispley[0] = 2;
            sizeDispley[1] = 12;
            sizeDispley[2] = 11;
            sizeDispley[3] = 55;
            sizeDispley[4] = 100;
            sizeDispley[5] = 15;
            sizeDispley[6] = 11;
            sizeDispley[7] = 17;
            sizeDispley[8] = 222;
            sizeDispley[9] = 145;
            sizeDispley[10] = 99;

            Displey[] display = new Displey[11];
            for (int i = 0; i < display.Length; i++)
            {
                display[i] = new Displey(sizeDispley[i],(uint)sizeDispley[i] + 220);
             
            }
            Battery[] bateri = new Battery[11];

            for (int i = 0; i < bateri.Length; i++)
            {
                bateri[i] = new Battery();
                bateri[i].HouersIdel = (uint)i + 19;
                bateri[i].HouerTalk = (uint)i + 3;
                bateri[i].BatteryType = BatteryEnum.NiCd;
                bateri[i].Model = models[i];
            }

            GSMTestList test = new GSMTestList(11);
         
            for (int i = 0; i < 11; i++)
            {   Calls call2 = new Calls(DateTime.Now.Date.AddDays(2), DateTime.Now.AddHours(2), "8566722344", 156);
                Calls call3 = new Calls(DateTime.Now.Date.AddDays(-4), DateTime.Now.AddHours(5), "8568905335", 500);
                Calls call1test = new Calls(DateTime.Now.Date, DateTime.Now, "8562231112", 466);
                test[i] = new GSMPhone();
                test[i].Displey = display[i];
                test[i].Battery = bateri[i];
                test[i].Price = prices[i];
                test[i].addCall(call1test);
                test[i].addCall(call2);
                test[i].addCall(call3);
                test[i].Manufacturer = manifacturerGSM[i];

                Console.WriteLine(test[i].ToString());
                foreach (var item in test[i].CallHistory)
                {
                    Console.WriteLine(item.ToString());
                }
               
                Console.WriteLine();
            }

            

            Console.WriteLine();
            Console.WriteLine(GSM.GSMPhone.Iphone4S.ToString());

        }
    }
}
