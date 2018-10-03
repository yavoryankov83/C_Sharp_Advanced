using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            Console.WriteLine(nums.Count());
            Console.WriteLine(nums.Sum());
        }
    }
}
