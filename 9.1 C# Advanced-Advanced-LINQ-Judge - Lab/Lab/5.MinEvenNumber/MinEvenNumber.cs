using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MinEvenNumber
{
    class MinEvenNumber
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(double.Parse).ToList();

            nums = nums.Where(n => n % 2 == 0).ToList();

            if (nums.Count != 0 )
            {
                Console.WriteLine($"{nums.Min():f2}");
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
