using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.KeyRevolver
{
    class KeyRevolver
    {
        static void Main(string[] args)
        {
            var priseOfBullet = int.Parse(Console.ReadLine());

            var sizeOfGunBarrel = int.Parse(Console.ReadLine());

            var bullets = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var locks = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var budget = int.Parse(Console.ReadLine());

            var queue = new Queue<int>(locks);
            var stack = new Stack<int>(bullets);

            var stackCount = stack.Count;

            var bulletCount = 0;
            var turns = 0;

            while (queue.Count != 0 && stack.Count != 0)
            {
                var currLock = queue.Peek();
                var currBull = stack.Peek();
               

                if (currBull <= currLock)
                {
                    Console.WriteLine("Bang!");
                    queue.Dequeue();
                    stack.Pop();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    stack.Pop();
                }

                bulletCount++;
                turns++;

                if (turns == sizeOfGunBarrel)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                        turns = 0;
                    }
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine($"{stackCount - bulletCount} bullets left. Earned ${budget - (bulletCount * priseOfBullet)}");
                return;
            }

            if (stack.Count == 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queue.Count}");
                return;
            }
        }
    }
}
