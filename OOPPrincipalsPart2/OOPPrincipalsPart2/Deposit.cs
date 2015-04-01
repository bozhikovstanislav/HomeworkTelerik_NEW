namespace OOPPrincipalsPart2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Deposit : Bank, IInteresable
    {


        public Deposit(Customers customers)
            :base(customers)
        {

        }
        public Deposit(Customers customers, decimal interestrate, long numberOfMonths, decimal balance)
            : base(customers, interestrate, numberOfMonths)
        {
            this.Balance = balance;
            if(this.Balance>0&& this.Balance<=1000)
            {
                if (this.Balance > 0 && this.Balance < 1000)
                {

                    base.BankInterestRate= 1;
                }
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
        public override void WidorwMoney()
        {
            base.WidorwMoney();
        }
        public override void DepositMoney()
        {
            base.DepositMoney();
        }
        public decimal Interest()
        {
            return this.NumberOfMonths * this.BankInterestRate;
        }

        public override string ToString()
        {
            return "Account type "+GetType().Name+" "+base.ToString();
        }
    }
}
