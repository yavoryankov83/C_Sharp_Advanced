using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNnumber
{
    class GetLargestNnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax());
        }

        private static int GetMax()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            return nums.Max();
        }
    }
}
