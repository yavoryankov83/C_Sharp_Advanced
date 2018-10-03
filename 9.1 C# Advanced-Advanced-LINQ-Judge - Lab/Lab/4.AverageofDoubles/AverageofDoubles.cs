using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.AverageofDoubles
{
    class AverageofDoubles
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .Average();

            Console.WriteLine($"{nums:f2}");
        }
    }
}
