using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativeAndReverse
{
    class RemoveNegativeAndReverse
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            list.RemoveAll(a => (a < 0));
            list.Reverse();

            Console.WriteLine(string.Join(" ", list));
            if (list.Count < 1)
            {
                Console.WriteLine("empty");
            }
        }
    }
}
