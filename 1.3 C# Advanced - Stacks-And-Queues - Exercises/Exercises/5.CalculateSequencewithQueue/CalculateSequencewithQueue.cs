using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CalculateSequencewithQueue
{
    class CalculateSequencewithQueue
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var queue = new Queue<long>();

            queue.Enqueue(n);
            var current = queue.Peek();

            var count = 1;

            while (queue.Count <= 50)
            {
                queue.Enqueue(current + 1);
                if (queue.Count == 50)
                {
                    break;
                }
                queue.Enqueue(2 * current + 1);
                if (queue.Count == 50)
                {
                    break;
                }
                queue.Enqueue(current + 2);
                if (queue.Count == 50)
                {
                    break;
                }

                var arr = queue.ToArray();
                current = arr[count];
                count++;
            }

            while (queue.Count > 0)
            {
                Console.Write(queue.Dequeue() + " ");
            }
        }
    }
}
