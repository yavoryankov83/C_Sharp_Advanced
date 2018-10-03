using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CountSameValuesinArray
{
    class CountSameValuesinArray
    {
        static void Main(string[] args)
        {
            var values = new SortedDictionary<string, int>();

            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions
                .RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                if (!values.ContainsKey(input[i]))
                {
                    values.Add(input[i], 0);
                }
                values[input[i]]++;
            }

            foreach (var pair in values)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
        }
    }
}
