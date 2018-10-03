using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MathPotato
{
    class MathPotato
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var number = int.Parse(Console.ReadLine());

            var queqe = new Queue<string>(input);

            var cycle = 1;

            while (queqe.Count > 1)
            {
                for (int i = 1; i < number; i++)
                {
                    var current = queqe.Dequeue();
                    queqe.Enqueue(current);
                }

                if (isPrime(cycle))
                {
                    Console.WriteLine($"Prime {queqe.Peek()}");
                }
                else
                {
                    Console.WriteLine($"Removed {queqe.Dequeue()}");
                }

                cycle++;
            }
            Console.WriteLine($"Last is {queqe.Dequeue()}");
        }
        public static bool isPrime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return num == 1 ? false : true;
        }
    }
}
