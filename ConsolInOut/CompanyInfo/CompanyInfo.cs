using System;

namespace CompanyInfo
{
    internal class CompanyInfo
    {
        private static void Main()
        {
            /*
             Problem 2 Print Company Information
             * A company has name, address, phone number, fax number, web site and manager.
             * The manager has first name, last name, age and a phone number.
             * Write a program that reads the information about a
             * company and its manager and prints it back on the console.
             */

            Console.WriteLine("Wecom to the program that prints Company information");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("\n");
            Console.WriteLine("Pleace enter the Company name ");
            string companyName = Console.ReadLine();
            double numberC;
            bool isNumberC = double.TryParse(companyName, out numberC);
            //Validationg the string
            if (isNumberC)
            {
                Console.WriteLine("You put wrong niumber . Pleas put  an string  ");
            }
            Console.WriteLine("Pleace enter the Company adress ");
            string companyAdress = Console.ReadLine();
            double numberAdress;
            bool isNumberAdress = double.TryParse(companyName, out numberAdress);
            //Validationg the string
            if (isNumberAdress)
            {
                Console.WriteLine("You put wrong niumber . Pleas put  an string  ");
            }
            Console.WriteLine("Pleace enter the Company Phone  Number ");
            string companyPhoneNumber = Console.ReadLine();
            double numberPNumber;
            bool isNumberPhoneNumber = double.TryParse(companyPhoneNumber, out numberPNumber);
            //Validationg the string the numbers of the code.
            char[] phpneArray=companyPhoneNumber.ToCharArray();//Validating the input of the code of the Phone
            for (int i = 0; i < phpneArray.Length; i++)
            {
                if(i==4||i==8||i==11||i==14)
                {
                    //Validating the empty char in th phone
                    if(phpneArray[i]!=' ')
                    {
                        Console.WriteLine("The phone number have to be in the fallowing format +### ### ## ## ###");
                        Console.WriteLine("The Program will now exit Bye Bye :)");
                        Console.ReadLine();
                        return;
                    }
                }
                //Validating the the start char "+"
                else if (phpneArray[0] != '+')
                {
                    Console.WriteLine("There is a wrong input for the code - MUST start with '+' ");
                    Console.WriteLine("The Program will now exit Bye Bye :)");
                    Console.ReadLine();
                    return;
                }
                    //validating the numbers in the phone
                else
                {
                    int numberPArrayNumber;
                    bool ispPhoneArrayNumber = int.TryParse(phpneArray[i].ToString(), out numberPArrayNumber);

                    if (ispPhoneArrayNumber)
                    {
                        Console.WriteLine("There is a wrong input number in the phone  ");
                        Console.WriteLine("The Program will now exit Bye Bye :)");
                        Console.ReadLine();
                        return;
                    }
                }
                Console.WriteLine("The company phone number {0} was enter succsesfuly ", companyPhoneNumber);
            }

            //Entering phax number number of the compnay");
            Console.WriteLine("Please enter the phax number of the company");
                string phaxNumber = Console.ReadLine();
            double numberPhax;
            bool isNumberPhax = double.TryParse(phaxNumber, out numberPhax);
            //validating Null Value
            if(phaxNumber==null)
            {
                phaxNumber="(no fax)";
            }

            //Validationg the numbers
           else if (isNumberPhax && phaxNumber!=null)
            {
                Console.WriteLine("the Fax number {0} is succesfuly enter ", numberPhax);
           }
            else
            {
                Console.WriteLine("You input  a wrong number or not a number or I do not know what you are doing with the console ;)");
           }

            //Entering the webSite of the company
            Console.WriteLine("Please enter the company web site ");
            string companyWebSite = Console.ReadLine();
            double numberwebSite;
            bool isNumberWebSite = double.TryParse(companyWebSite, out numberwebSite);

            //Validationg the numbers
            if (isNumberWebSite)
            {
                //calculating the sum of the numbers
                Console.WriteLine("You are inputing numbers not a website ");
                Console.WriteLine("The program will now exit You have to start Everything AGAIN :D");
                return;
            }
            else
            {
               bool isStartHttp= companyWebSite.StartsWith("http://");
                if(!isStartHttp)
                {
                    Console.WriteLine("The starting string of the web site is not a valid have to start with 'http://'");
                    Console.WriteLine("The program will now exit You have to start Everything AGAIN :D");
                    return;
                }
                Console.WriteLine("You seccsefuly enter a web site {0} of the company ", companyWebSite);
            }

            Console.WriteLine("Please enter the first name of the manager ");
            //Entering maneger first name
            string manegerFirstName = Console.ReadLine();
            double numberManeger;
            bool isNumberManeger = double.TryParse(manegerFirstName, out numberManeger);

            //Validationg the numbers
            if (isNumberManeger)
            {
                Console.WriteLine("You are inputing nunsens man Com on do it how you have to Put A STRING ...");
                Console.WriteLine("The program will now exit You have to start Everything AGAIN :D");
                return;
            }
            else
            {
                Console.WriteLine("You sucsessfuly enter the firstname of the manager {0} of the ", manegerFirstName);
            }

            Console.WriteLine("Pleas enter maneger last name");
            //Entering maneger first name
            string manegerlastName = Console.ReadLine();
            double numberManegerLast;
            bool isNumberManegerLast = double.TryParse(manegerlastName, out numberManegerLast);

            //Validationg the numbers
            if (isNumberManeger)
            {
                Console.WriteLine("You are inputing nunsens man Com on do it how you have to Put A STRING ...");
                Console.WriteLine("The program will now exit You have to start Everything AGAIN :D");
                return;
            }
            else
            {
                Console.WriteLine("You sucsessfuly enter the firstname of the manager {0} of the ", manegerFirstName);
            }
            Console.WriteLine("Enter the maneger age ");
            string manegerAge = Console.ReadLine();
            uint numberManegerAge;
            bool isNumberManegerAge = uint.TryParse(manegerAge, out numberManegerAge);

            //Validationg the numbers
            if (isNumberManegerAge)
            {
                Console.WriteLine("You sucsessfuly enter the Age of the manager {0} of the ", numberManegerAge);
            }
            else
            {
                Console.WriteLine("You are inputing nunsens man Com on do it how you have to Put A STRING ...");
                Console.WriteLine("The program will now exit You have to start Everything AGAIN :D");
                return;
            }

             Console.WriteLine("Pleace enter the Phone  Number of the Maneger");
            string companyPhoneNumberManeger = Console.ReadLine();
            //double numberPNumberManeger;
            //bool isNumberPhoneNumberManager= double.TryParse(companyPhoneNumberManeger, out numberPNumberManeger);
            //Validationg the string the numbers of the code.
            char[] phpneArrayManager=companyPhoneNumber.ToCharArray();//Validating the input of the code of the Phone
            for (int i = 0; i < phpneArray.Length; i++)
            {
                if (i == 4 || i == 6 || i == 10)
                {
                    //Validating the empty char in th phone
                    if (phpneArray[i] != ' ')
                    {
                        Console.WriteLine("The phone number have to be in the fallowing format +### # ### ###");
                        Console.WriteLine("The Program will now exit Bye Bye :)");
                        Console.ReadLine();
                        return;
                    }
                }
                //Validating the the start char "+"
                else if (phpneArray[0] != '+')
                {
                    Console.WriteLine("There is a wrong input for the code - MUST start with '+' ");
                    Console.WriteLine("The Program will now exit Bye Bye :)");
                    Console.ReadLine();
                    return;
                }
                //validating the numbers in the phone
                else
                {
                    int numberPArrayNumber;
                    bool ispPhoneArrayNumberManager = int.TryParse(phpneArrayManager[i].ToString(), out numberPArrayNumber);

                    if (ispPhoneArrayNumberManager)
                    {
                        Console.WriteLine("There is a wrong input number in the phone  ");
                        Console.WriteLine("The Program will now exit Bye Bye :)");
                        Console.ReadLine();
                        return;
                    }
                }

                Console.WriteLine("The company phone number {0} was enter succsesfuly ", companyPhoneNumber);
                //Output to the console
                Console.WriteLine("You have Enetred follawing data for the company");
                Console.Write("/n");
                Console.WriteLine("{0} ", companyName);
                Console.Write("/n");
                Console.Write("Address: /t{0} ", companyAdress);
                Console.Write("/n");
                Console.Write("Tel. /t{0} t", companyPhoneNumber);
                Console.Write("/n");
                Console.Write("Fax: /t{0} ", phaxNumber);
                Console.Write("/n");
                Console.Write("Web site: /t{0}", companyWebSite);
                Console.Write("/n");
                Console.Write("Manager: {0} {1} (age: {3}, tel. {4}", manegerFirstName, manegerlastName, manegerAge, companyPhoneNumberManeger);
            }
            Console.ReadLine();
        }
    }
}