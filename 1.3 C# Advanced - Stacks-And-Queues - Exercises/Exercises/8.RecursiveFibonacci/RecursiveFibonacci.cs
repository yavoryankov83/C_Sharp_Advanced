using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        private static long[] fibNumbers;

        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            fibNumbers = new long[num];

            var result = GetFibonacci(num);
            Console.WriteLine(result);
        }

        private static long GetFibonacci(int num)
        {
            if (num <= 2)
            {
                return 1;
            }
            if (fibNumbers[num -1] != 0)
            {
                return fibNumbers[num - 1];
            }
            return fibNumbers[num - 1] = GetFibonacci(num - 1) + GetFibonacci(num - 2);
        }
    }
}
