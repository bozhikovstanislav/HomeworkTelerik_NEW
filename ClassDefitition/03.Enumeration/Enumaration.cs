﻿namespace _03.Enumeration
{
    using System;
 
    class Enumaration
    {
        static void Main()
        {
            GSM GSmGsho = new GSM();

            GSmGsho.DispleyGSM = new Displey();

            GSmGsho.BatteryGSM = new Battery();

            GSmGsho.DispleyGSM.BatteryType = BatteryTipe.LiIon;

        }
    }
}