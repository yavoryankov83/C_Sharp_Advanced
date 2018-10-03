using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int sumOfDigits = SumDigits(i);

                bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine($"{i} => {isSpecial}");
            }
        }

        private static int SumDigits(int i)
        {
            int num = i;
            int sumOfDigits = 0;
            while (num > 0)
            {
                sumOfDigits += num % 10;
                num /= 10;
            }

            return sumOfDigits;
        }
    }
}
