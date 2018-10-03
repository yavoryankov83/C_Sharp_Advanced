using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.AppliedArithmetics
{
    class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse);
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                switch (input)
                {
                    case "add":
                        nums = Result(nums,  n => n + 1);
                        break;
                    case "multiply":
                        nums = Result(nums, n => n * 2);
                        break;
                    case "subtract":
                        nums = Result(nums, n => n - 1);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                }
            }
        }
        public static IEnumerable<int> Result(IEnumerable<int> nums, Func<int, int> func)
        {
            return nums.Select(n => func(n));
        }
    }
}
