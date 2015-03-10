namespace _02.Constructors
{
    using System;

    public  class Battery
    {
        public string ModelBatery { get; set; }
        public uint HouerIdle { get; set; }
        public uint HouerTalk { get; set; }

        public Battery(string modelBatery,uint houerIdle,uint houerTalk)
        {
            this.ModelBatery = modelBatery;
            this.HouerIdle = houerIdle;
            this.HouerTalk = houerTalk;
 
        }
        public Battery()
        {

        }

    }
}
