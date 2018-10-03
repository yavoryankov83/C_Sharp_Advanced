using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GroupNumbers
{
    class GroupNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var zero = nums.Where(x => Math.Abs(x) % 3 == 0);
            var one = nums.Where(x => Math.Abs(x) % 3 == 1);
            var two = nums.Where(x => Math.Abs(x) % 3 == 2);

            Console.WriteLine(string.Join(" ", zero));
            Console.WriteLine(string.Join(" ", one));
            Console.WriteLine(string.Join(" ", two));
        }
    }
}
