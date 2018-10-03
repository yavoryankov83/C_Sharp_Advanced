using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.BoundedNumbers
{
    class BoundedNumbers
    {
        static void Main(string[] args)
        {
            var bounds = Console.ReadLine().Split().Select(int.Parse);

            var bigger = bounds.Max();
            var minner = bounds.Min();

            var nums = Console.ReadLine().Split().Select(int.Parse);

            var result = nums.Where(n => minner <= n && n <= bigger);

            Console.WriteLine(string.Join(" ", result));
                
        }
    }
}
