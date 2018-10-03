using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int num = 0; num < numbers.Count - 1; num++)
            {
                if (numbers[num] == numbers[num + 1])
                {
                    numbers[num] += numbers[num + 1];
                    numbers.RemoveAt(num + 1);
                    num = -1;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
