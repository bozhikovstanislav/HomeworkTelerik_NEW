using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackAccount
{
    class BankAcaount
    {
        static void Main(string[] args)
        {
            //Problem 11. Bamk Accaount Data

            string firstName="Дядо";
            string middleName="Вади";
            string lastName="Ряпа";
            ulong balance=2000000;
            string bankName="Банка за Селско Развитие";
            string iban="GBN567388IGBT567398456";
            ulong[] cardNumbers=new ulong[]{453635343512,675647564646,454647484940};
         

            Console.WriteLine("{0}", bankName);
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("Bank Account:");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("First Name " + "\t" + "Middle Name" + "\t" + "Last Name" + "\t" + "balance" + "\t" + "IBAN" + "\t\t\t" + "card Number");
            Console.WriteLine(firstName + "\t\t" + middleName + "\t\t" + lastName + "\t\t" + balance + "\t" + iban + "\t" + cardNumbers[0]);
            Console.ReadLine();
        }
    }
}
