using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CustomMinFunction
{
    class CustomMinFunction
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse);

            Func<IEnumerable<int>, int> smallest = n => n.Min();

            Console.WriteLine(smallest(nums));
        }
    }
}
