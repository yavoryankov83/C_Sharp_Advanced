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
            var input = Console.ReadLine().Split();
            var nums = Console.ReadLine().Split();

            var queue = new Queue<string>(nums);

            for (int i = 0; i < int.Parse(input[1]); i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (queue.Contains(input[2]))
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
}
