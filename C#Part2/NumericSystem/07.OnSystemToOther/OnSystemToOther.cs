using System;
using System.Text;

    class OnSystemToOther
    {
        static string Convert(string numberToConvert, uint from, uint to)
        {
            uint number = NToDecimal(numberToConvert, from);

            if (number == 0)
                return number.ToString();

            return DecimalToN(to, number);
        }

        static string DecimalToN(uint to, uint number)
        {
            StringBuilder result = new StringBuilder();
            uint remainder;
            char currentLetter;
            while (number > 0)
            {
                remainder = number % to;

                if (remainder < 10)
                    currentLetter = (char)(remainder + '0');
                else
                    currentLetter = (char)(remainder + 55);

                result.Insert(0, currentLetter);

                number /= to;
            }
            return result.ToString();
        }
        static uint NToDecimal(string numberToConvert, uint from)
        {
            uint number = 0;
            byte currentValue;
            numberToConvert = numberToConvert.ToUpper();

            for (int current = 0; current < numberToConvert.Length; current++)
            {
                number *= from;
                if (Char.IsLetter(numberToConvert[current]))
                    currentValue = (byte)(numberToConvert[current] - 55);
                else
                    currentValue = (byte)(numberToConvert[current] - '0');

                number += currentValue;
            }
            return number;
        }



        static void Main(string[] args)
        {
            //Zabelezka поради липса на време този код съм го взел от колеги ........ 

           Console.WriteLine(Convert("345", 3, 4));

        }
    }

