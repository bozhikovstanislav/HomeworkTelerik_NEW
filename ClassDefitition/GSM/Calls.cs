namespace GSM
{
    using System;
    using System.Text;

    public class Calls
    {
        private DateTime dateOfCall;
        private DateTime timeOfCall;
        private string phoneNuber;
        private ulong seconds;
        private double priceperMinute;

       
        public Calls(DateTime dateOfCallOfGSM,DateTime timeOfCallOfGSM,string phoneNumberCalled,ulong secondsCallDuretion,double pricePerMinuteCall )
        {
            this.DateOfCall = dateOfCallOfGSM;
            this.TimeOfCall = timeOfCallOfGSM;
            this.PhoneNuber = phoneNumberCalled;
            this.Seconds = secondsCallDuretion;
            this.PriceperMinute = pricePerMinuteCall;
        }
        public Calls()
        {

        }


        public DateTime DateOfCall
        {
            get { return dateOfCall; }
            set 
            {
               
                dateOfCall = DateTime.Parse(value.ToShortDateString());
                
            }
        }
        public DateTime TimeOfCall
        {
            get { return timeOfCall; }
            set 
            { 
                timeOfCall = DateTime.Parse(value.ToShortTimeString()); 
            }
        }
        public string PhoneNuber
        {
            get { return phoneNuber; }
            set
            {
                phoneNuber = value;

                char[] letterNumber=phoneNuber.ToCharArray();
                  
                for (int i = 0; i < letterNumber.Length; i++)
                {
                    if(!char.IsDigit(letterNumber[i]))
                    {
                        throw new ArgumentException("The number have to be in a format only with digits");
                    }
                }
              

            }
        }
        public ulong Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
        public double PriceperMinute
        {
            get { return priceperMinute; }
            set { priceperMinute = value; }
        }
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("Call history info"));
            sb.Append("\n");
            sb.Append(string.Format("date of Call {0}", this.DateOfCall));
            sb.Append("\n");
            sb.Append(string.Format("time of call {0}", this.TimeOfCall));
            sb.Append("\n");
            sb.Append(string.Format("PhoneNumber {0}", this.PhoneNuber));
            sb.Append("\n");
            sb.Append(string.Format("duration {0}", this.Seconds));
            sb.Append("\n");
            return sb.ToString();
        }


    }
}
