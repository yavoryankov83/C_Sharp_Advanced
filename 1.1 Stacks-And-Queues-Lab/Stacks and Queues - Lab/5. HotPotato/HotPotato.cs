using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.HotPotato
{
    class HotPotato
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var n = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(names);

            while (queue.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    var current = queue.Dequeue();
                    queue.Enqueue(current);
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
