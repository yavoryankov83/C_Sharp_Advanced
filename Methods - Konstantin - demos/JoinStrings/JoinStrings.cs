using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinStrings
{
    class JoinStrings
    {
        static string Join(int[] numbers, string separator)
        {
            string result = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];

                if (numbers[i] != numbers[numbers.Length - 1])
                {
                    result += separator;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 6, 8, 23, 54, 87 };
            string separator = " => ";

            Console.WriteLine(Join(numbers, separator));
        }
    }
}
