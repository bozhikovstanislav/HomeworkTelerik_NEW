using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrincipalsPart2
{
    public abstract class CustemersAccaunts 
    {
        public abstract decimal Balance { get; set; }
        public abstract decimal BankInterestRate { get; set; }
        public abstract long NumberOfMonths { get; set; }
        public string CustemerName { get; set; }

        public CustemersAccaunts(decimal balanceAccount,decimal interestRate,long numberofMonths)
        {
            this.Balance = balanceAccount;
            this.BankInterestRate = interestRate;
            this.NumberOfMonths = numberofMonths;
        }

       public CustemersAccaunts(string customerName)
        {
            this.CustemerName = customerName;
        }

        public CustemersAccaunts()
        {

        }

        public CustemersAccaunts(decimal intersestRate,long numberOfMinths)
        {
            this.BankInterestRate = intersestRate;
            this.NumberOfMonths = numberOfMinths;
        }
    }
}
