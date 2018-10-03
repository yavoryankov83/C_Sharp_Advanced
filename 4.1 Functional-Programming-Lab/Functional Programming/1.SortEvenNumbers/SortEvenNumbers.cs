using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SortEvenNumbers
{
    class SortEvenNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n);

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
