using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HitList
{
    class HitList
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, Dictionary<string, string>>();

            var targetIndex = int.Parse(Console.ReadLine());

            var infoIndex = 0;

            string input;

            while ((input = Console.ReadLine()) != "end transmissions")
            {
                var tokens1 = input
                    .Split('=');

                var name = tokens1[0];

                var tokens2 = tokens1[1]
                    .Split(new char[] { ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < tokens2.Length; i+=2)
                {
                    var type = tokens2[i];
                    var value = tokens2[i + 1];

                    if (!result.ContainsKey(name))
                    {
                        result.Add(name, new Dictionary<string, string>());
                    }

                    if (!result[name].ContainsKey(type))
                    {
                        result[name].Add(type, value);
                    }

                    result[name][type] = value;
                }
            }

            var input2 = Console.ReadLine().Split();

            var command = input2[1];

            if (result.ContainsKey(command))
            {
                Console.WriteLine($"Info on {command}:");

                foreach (var kvp in result[command].OrderBy(k => k.Key))
                {
                    var type = kvp.Key;
                    infoIndex += type.Length;

                    var value = kvp.Value;
                    infoIndex += value.Length;

                    Console.WriteLine($"---{type}: {value}");
                }
            }

            if (infoIndex >= targetIndex)
            {
                Console.WriteLine($"Info index: {infoIndex}");
                Console.WriteLine("Proceed");
            }
            else
            {
                var diff = Math.Abs(infoIndex - targetIndex);
                Console.WriteLine($"Info index: {infoIndex}");
                Console.WriteLine($"Need {diff} more info.");
            }
        }
    }
}
