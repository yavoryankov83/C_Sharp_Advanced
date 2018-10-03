using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Aminertask
{
    class Aminertask
    {
        static void Main(string[] args)
        {
            var list = new Dictionary<string, long>();

            var input = Console.ReadLine();

            while (input != "stop")
            {
                var resourses = input;
                var quantity = long.Parse(Console.ReadLine());

                if (!list.ContainsKey(input))
                {
                    list.Add(input, 0);
                }

                list[input] += quantity;

                input = Console.ReadLine();
            }

            foreach (var pair in list)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
