namespace OOPPrincipalsPart2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Mortgage : Bank, IInteresable
    {

        public Mortgage(Customers customers, decimal interestrate, long numberOfMonths,decimal balance)
            :base(customers,interestrate,numberOfMonths,balance)
        {
            long curentNumberOfMonthBuisness = this.NumberOfMonths - 12;
            long curentNumberofMonthsPerson = this.NumberOfMonths - 6;
            if (this.Custemors == Customers.Buisness && curentNumberOfMonthBuisness > 0 && curentNumberOfMonthBuisness<=12)
            {
                this.NumberOfMonths = curentNumberOfMonthBuisness;
                BankInterestRate = this.BankInterestRate / 2;
            }

            else if (this.Custemors == Customers.Person && curentNumberOfMonthBuisness <= 6 && curentNumberOfMonthBuisness>0)
            {
                this.NumberOfMonths = curentNumberofMonthsPerson;
                this.BankInterestRate = 1;
            }
        }
        public Mortgage()
        {

        }

        public override decimal Balance
        {
            get
            {
                return base.Balance;
            }
            set
            {
                base.Balance = value;
            }
        }
        public override decimal BankInterestRate
        {
            get
            {
                return base.BankInterestRate;
            }
           set
            {
              
                base.BankInterestRate = value;
            }
        }

        public override long NumberOfMonths
        {
            get
            {
                return base.NumberOfMonths;
            }
            set
            {
                base.NumberOfMonths = value;
            }
        }
        public decimal Interest()
        {
            return this.NumberOfMonths*this.BankInterestRate;
        }

        public override string ToString()
        {
            return "Acount type "+GetType().Name+" " +base.ToString();
        }
    }
}
