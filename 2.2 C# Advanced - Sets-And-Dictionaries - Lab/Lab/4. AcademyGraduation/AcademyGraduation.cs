using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.AcademyGraduation
{
    class AcademyGraduation
    {
        static void Main(string[] args)
        {
            var result = new SortedDictionary<string, List<double>>();

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var name = Console.ReadLine();
                var score = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions
                    .RemoveEmptyEntries);

                for (int j = 0; j < score.Length; j++)
                {
                    if (!result.ContainsKey(name))
                    {
                        result.Add(name, new List<double>());
                    }

                    result[name].Add(double.Parse(score[j]));
                }
            }

            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key} is graduated with {pair.Value.Average()}");
            }
        }
    }
}
