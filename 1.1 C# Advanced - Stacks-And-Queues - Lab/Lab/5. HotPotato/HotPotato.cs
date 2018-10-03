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
            var input = Console.ReadLine().Split();
            var number = int.Parse(Console.ReadLine());

            var queqe = new Queue<string>(input);

            while (queqe.Count > 1)
            {
                for (int i = 1; i < number; i++)
                {
                    var current = queqe.Dequeue();
                    queqe.Enqueue(current); 
                }
                Console.WriteLine($"Removed {queqe.Dequeue()}");
                }
            Console.WriteLine($"Last is {queqe.Dequeue()}");
        }
    }
}
