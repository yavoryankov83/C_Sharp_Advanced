using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            var list = new SortedDictionary<char, int>();

            var text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (!list.ContainsKey(text[i]))
                {
                    list.Add(text[i], 0);
                }
                list[text[i]]++;
            }

            foreach (var symbol in list)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
