using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MapDistricts
{
    class MapDistricts
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, List<long>>();

            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions
                .RemoveEmptyEntries);

            var filter = long.Parse(Console.ReadLine());

            foreach (var item in input)
            {
                var tokens = item.Split(':');
                var city = tokens[0];
                var population = long.Parse(tokens[1]);

                if (!result.ContainsKey(city))
                {
                    result.Add(city, new List<long>());
                }
                result[city].Add(population);
            }

            var nextResult = result
                .Where(n => n.Value.Sum() > filter)
                .OrderByDescending(n => n.Value.Sum())
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var pair in nextResult)
            {
                Console.WriteLine($"{pair.Key}: {string.Join(" ", pair.Value.OrderByDescending(n => n).Take(5))}");
            }
        }
    }
}
