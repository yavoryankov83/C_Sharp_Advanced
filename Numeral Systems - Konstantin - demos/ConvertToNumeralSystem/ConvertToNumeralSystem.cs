using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToNumeralSystem
{
    class ConvertToNumeralSystem
    {
        static string ConvDecToHex(int number)
        {
            string result = "";

            string hexDigits = "0123456789ABCDEF";

            do
            {
                int digitValue = number % 16;
                char digit = hexDigits[digitValue];
                number /= 16;

                result = digit + result;
            }
            while (number > 0);

            return result;
        }

        static string ConvertFromDecimal(int number, int numeralBase)
        {
            string result = "";

            do
            {
                int digit = number % numeralBase;
                number /= numeralBase;

                result = digit + result;
            }
            while (number > 0);

            return result;
        }

        static int ConvertFromHexToDec(string number)
        {
            var result = 0;

            foreach (char digit in number)
            {
                int digitValue;

                if (char.IsDigit(digit))
                {
                    digitValue = digit - '0';
                }
                else
                {
                    digitValue = digit - 'A' + 10;
                }

                result = result * 16 + digitValue;  
            }
            return result;
        }

        static int ConvertToDecimal(string number, int nummeralBase)
        {
            var result = 0;

            foreach (char digit in number)
            {
                result = result * nummeralBase + (digit - '0');
            }
            return result;
        }

        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            var number1 = int.Parse(Console.ReadLine());

            int num = ConvertToDecimal(number, 2);
            Console.WriteLine(num);

            int num1 = ConvertFromHexToDec(number);
            Console.WriteLine(num1);

            string num3 = ConvertFromDecimal(number1, 2);
            Console.WriteLine(num3);
        }
    }
}
