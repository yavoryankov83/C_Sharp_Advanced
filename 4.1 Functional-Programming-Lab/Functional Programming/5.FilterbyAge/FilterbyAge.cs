using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FilterbyAge
{
    class FilterbyAge
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, int>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var name = input[0];
                var age = int.Parse(input[1]);

                people.Add(name, age);
            }

            var condition = Console.ReadLine();
            var finalAge = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            if (condition == "younger")
            {
                people = people.Where(p => p.Value < finalAge).ToDictionary(k => k.Key, v => v.Value);
            }
            else
            {
                people = people.Where(p => p.Value >= finalAge).ToDictionary(k => k.Key, v => v.Value);
            }

            switch (format)
            {
                case "name":
                    foreach (var pair in people)
                    {
                        Console.WriteLine($"{pair.Key}");
                    }
                    break;
                case "age":
                    foreach (var pair in people)
                    {
                        Console.WriteLine($"{pair.Value}");
                    }
                    break;
                case "name age":
                    foreach (var pair in people)
                    {
                        Console.WriteLine($"{pair.Key} - {pair.Value}");
                    }
                    break;
            }
        }
    }
}
