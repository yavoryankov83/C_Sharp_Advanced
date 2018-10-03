using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FindandSumIntegers
{
    class FindandSumIntegers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var nums = input
                .Select(n =>
                {
                    long value;
                    bool parsed = long.TryParse(n, out value);

                    //returns new anonimys object with two values
                    return new { value, parsed };
                })
                .Where(n => n.parsed)
                .Select(n => n.value)
                .ToList();

            if (nums.Count() != 0)
            {
                Console.WriteLine(nums.Sum());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
