namespace OOPPrincipalsPart2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Bank : CustemersAccaunts
    {
        private decimal balanceBank;
        private decimal bankInterestRate;
        private long numberOfMonths;
        private Customers custemors;

        public Bank(decimal balance,decimal interestRate,long numberofMonths)
            : base(balance, interestRate, numberofMonths)
        {

        }
        public Bank(Customers customersEnum, decimal interestrate, long numberOfMonths)
            :base(interestrate,numberOfMonths)
        {

        }

        public Bank(Customers customersEnum,decimal interestrate,long numberOfMonths,decimal balance)
            :this(balance,interestrate,numberOfMonths)
        {
            this.Custemors = customersEnum;
            this.Balance = balance;
        }
        public Bank(Customers customers)
        {
            this.Custemors = custemors;
        }

        public Bank()
        {

        }
        public override long NumberOfMonths
        {
            get
            {
                return numberOfMonths;
            }
            set
            {
                numberOfMonths = value;
            }
        }

        public override decimal Balance
        {
            get
            {
                return balanceBank;
            }
            set
            {
                this.balanceBank = value;
            }
        }

        public override decimal BankInterestRate
        {
            get
            {
                return bankInterestRate;
            }
            set
            {
                this.bankInterestRate = value;
            }
        }

        internal Customers Custemors
        {
            get { return custemors; }
            set { custemors = value; }
        }
      
        public virtual void WidorwMoney()
        {
            this.balanceBank--;
        }

        public virtual void DepositMoney()
        {
            this.balanceBank++;
        }

        public override string ToString()
        {
            return String.Format("Balance {0} , InterestRate {1} , Customers {2}",this.Balance,this.BankInterestRate,this.Custemors);
        }

       
    }
}
