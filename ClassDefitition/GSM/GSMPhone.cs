namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class GSMPhone
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Displey displey;
        private Battery battery;
        private static GSMPhone iphone4S;
        private List<Calls> callHistory;
   
        public GSMPhone(string modelGSM, string manufacturerGSM, decimal priceGSM, string ownerGSM, Displey displeyGSM, Battery batteryGSM)
        {
            this.model = modelGSM;
            this.manufacturer = manufacturerGSM;
            this.price = priceGSM;
            this.price = priceGSM;
            this.owner = ownerGSM;
            this.displey = new Displey();
            this.battery = new Battery();
            this.callHistory = new List<Calls>();
        }
        public GSMPhone(string modelGSM, string manufacturerGSM)
        {
            this.model = modelGSM;
            this.manufacturer = manufacturerGSM;
            this.price = null;
            this.owner = string.Empty;
            this.callHistory = new List<Calls>();
        }
        public GSMPhone()
        {
            this.callHistory = new List<Calls>();
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                manufacturer = value;
                if (manufacturer == string.Empty)
                {
                    throw new NullReferenceException("You have to enter a Manufacturer");
                }




            }
        }
        public decimal? Price
        {
            get { return price; }
            set
            {

                price = value;
                if (price.Value <= 0)
                {
                    throw new ArgumentException("The price have to be positive and bigger then zero");
                }




            }
        }

        public string Owner
        {
            get { return owner; }
            set
            {

                owner = value;
            }
        }

        public Displey Displey
        {
            get { return displey; }
            set
            {

                displey = value;
            }
        }

        public Battery Battery
        {
            get { return battery; }
            set
            {

                battery = value;


            }
        }
        public static GSMPhone Iphone4S
        {
            get
            {



                return GSMPhone.iphone4S;
            }
            set
            {
                GSMPhone.iphone4S = value;
            }
        }


        public List<Calls> CallHistory
        {
            get { return callHistory; }

            set { callHistory = value; }
        }

      
        public void addCall(Calls call)
        {
            this.CallHistory.Add(call);
        }
        public void deleteCalls(Calls call)
        {
            this.CallHistory.Remove(call);
        }
        public void ClearHistoryCalls()
        {
            this.CallHistory.Clear();
        }

        public double CalculateTotalPrice()
        {
    
          
                double totalPrice = 0;
                var allCalse = this.CallHistory;
                double totalsecondsDuration = 0;
                double pricePerMinute = 0;
                foreach (var item in allCalse)
                {
                    totalsecondsDuration += item.Seconds;
                    pricePerMinute = item.PriceperMinute;
                }
                double totalMinute = totalsecondsDuration / 60;



                return totalPrice = totalMinute * pricePerMinute;

        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.Append(String.Format("The information for the GSM is "));
            sb.Append("\n");
            sb.Append(string.Format("Model - {0}", this.model));
            sb.Append("\n");
            sb.Append(string.Format("Manufacter - {0}", this.manufacturer));
            sb.Append("\n");
            sb.Append(string.Format("Price - {0}", this.price));
            sb.Append("\n");
            sb.Append(string.Format("Owner - {0}", this.owner));
            sb.Append("\n");
            sb.Append("------------------------------");
            sb.Append("\n");
            sb.Append(string.Format("{0}", this.battery));
            sb.Append("\n");
            sb.Append("------------------------------");
            sb.Append("\n");
            sb.Append(string.Format("{0}", this.displey));
            sb.Append("\n");
            sb.Append("-------------------------------");
            sb.Append("\n");
            sb.Append(string.Format("Total price {0}", CalculateTotalPrice()));
            sb.Append("\n");
            sb.Append("-------------------------------");
            return sb.ToString();
        }
    }
}
