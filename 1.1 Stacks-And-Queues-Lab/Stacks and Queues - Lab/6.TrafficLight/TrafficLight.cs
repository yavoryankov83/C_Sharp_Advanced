using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.TrafficLight
{
    class TrafficLight
    {
        static void Main(string[] args)
        {
            var numberForPassing = int.Parse(Console.ReadLine());

            var queue = new Queue<string>();

            string input;
            var count = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                var command = input;

                if (command != "green")
                {
                    queue.Enqueue(command);
                }

                else
                {
                    var times = numberForPassing;

                    if (numberForPassing > queue.Count)
                    {
                        times = queue.Count;
                    }

                    for (int i = 0; i < times; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        count++;
                    }
                }
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
