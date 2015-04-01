

namespace OOPPrincipalsPart2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Loan : Bank, IInteresable
    {

        
        public Loan(Customers customers,long numberOfMonths,decimal interestRate,decimal balance)
            :base(customers,interestRate,numberOfMonths,balance)
        {
             numberOfMonths = this.NumberOfMonths;
            if (numberOfMonths == 2 && this.Custemors == Customers.Buisness)
            {
                base.BankInterestRate = 1;
            }

             if (numberOfMonths == 3 && this.Custemors == Customers.Person)
            {
                base.BankInterestRate = 1;
            }

            if (this.Custemors == Customers.Buisness && numberOfMonths>2)
            {
                this.NumberOfMonths = numberOfMonths - 2;
            }
            if (this.Custemors == Customers.Person && numberOfMonths>3)
            {
                this.NumberOfMonths = numberOfMonths - 3;
            }
        }

        public Loan()
        {

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

        public decimal Interest()
        {
            return this.BankInterestRate * this.NumberOfMonths; 
        }

        public override string ToString()
        {
            return "Account type :"+GetType().Name+" :" + base.ToString()+ " ";
        }
    }
}
