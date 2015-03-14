namespace GSM
{
    using System;
    using System.Text;


    public class Battery
    {
        private string model;
        private uint? houersIdel;
        private uint? houerTalk;
        private BatteryEnum batteryType;

        public Battery this[int index]
        {
            get { return this; }
       
        }
        public Battery(string modelBatery,uint h_Idel,uint h_talk,BatteryEnum batteryType)
        {
            this.model = modelBatery;
            this.houersIdel = h_Idel;
            this.houerTalk = h_talk;
            this.batteryType = batteryType;
        }

        public Battery(string modelBattery, BatteryEnum batteryType)
        {
            this.model = modelBattery;
            this.HouerTalk = null;
            this.HouersIdel = null;
            this.BatteryType = batteryType;
        }
        public Battery()
        {

        }
        public uint? HouerTalk
        {
            get { return houerTalk; }
            set { houerTalk = value; }
        }
        public uint? HouersIdel
        {
            get { return houersIdel; }
            set 
            { 
                if(houersIdel==0)
                {
                    throw new ArgumentException("The Idel houers have to be biger then ZERO");
                }
                else
                {
                    houersIdel = value;
                }
               
            }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        internal BatteryEnum BatteryType
        {
            get { return batteryType; }
            set { batteryType = value; }
        }
        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();

            sb.Append("Battery");
            sb.Append("\n");
            sb.Append("---------------------------");
            sb.Append("\n");
            sb.Append(string.Format("Battery Model - {0}", this.model));
            sb.Append("\n");
            sb.Append(string.Format("Battery houer Idle - {0} mm", this.houersIdel));
            sb.Append("\n");
            sb.Append(string.Format("Battery houer talk - {0} h", this.houerTalk));
        
            
            return sb.ToString();
        }
    }
}
