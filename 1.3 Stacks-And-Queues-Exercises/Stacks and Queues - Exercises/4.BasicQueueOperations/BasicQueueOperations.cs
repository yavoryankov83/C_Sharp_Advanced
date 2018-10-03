using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>(numbers);

            for (int i = 0; i < nums[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (queue.Contains(nums[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                var smallest = queue.Min();
                Console.WriteLine(smallest);
            }
        }
    }
}
