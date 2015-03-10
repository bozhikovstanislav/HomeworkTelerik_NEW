namespace _05.Properties
{
    using System;

    enum BatteryType
    {
        Li_Ion, NiMH, NiCd
    };
    public class Battery
    {
        private string modelBattery;
        private uint houerTalk;
        private uint houerIdel;

        public uint HouerIdel
        {
            get { return houerIdel; }
            set { houerIdel = value; }
        }
  
        public uint HouerTalk
        {
            get { return houerTalk; }
            set { houerTalk = value; }
        }
        public string ModelBattery
        {
            get { return modelBattery; }
            set { modelBattery = value; }
        }
        public Battery(string modelBattery,uint houerIdel,uint houerTalk)
        {

        }
    }
}
