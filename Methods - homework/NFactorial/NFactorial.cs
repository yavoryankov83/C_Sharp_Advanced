using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace NFactorial
{
    class NFactorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Factorial(number);
        }

        private static void Factorial(int num)
        {
            var bi = new BigInteger(1);
            for (var i = 1; i <= num; i++)
            {
                bi *= i;
            }
            Console.WriteLine(bi);
        }
    }
}
