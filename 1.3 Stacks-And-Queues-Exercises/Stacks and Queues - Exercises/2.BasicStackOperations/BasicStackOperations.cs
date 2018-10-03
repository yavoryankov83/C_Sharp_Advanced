using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>(numbers);

            for (int i = 0; i < nums[1]; i++)
            {
                stack.Pop();
            }

            if ( stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (stack.Contains(nums[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                var smallest = stack.Min();
                Console.WriteLine(smallest);
            }
        }
    }
}
