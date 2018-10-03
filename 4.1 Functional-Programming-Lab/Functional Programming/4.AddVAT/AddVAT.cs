using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.AddVAT
{
    class AddVAT
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n + n * 0.2);

            foreach (var n in nums)
            {
                Console.WriteLine($"{n:f2}");
            }
        }
    }
}
