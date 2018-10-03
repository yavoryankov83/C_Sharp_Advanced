using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ReverseandExclude
{
    class ReverseandExclude
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse);

            var devidor = int.Parse(Console.ReadLine());

            Func<int, bool> filter = n => n % devidor != 0;

            nums = nums
                .Where(filter)
                .Reverse();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
