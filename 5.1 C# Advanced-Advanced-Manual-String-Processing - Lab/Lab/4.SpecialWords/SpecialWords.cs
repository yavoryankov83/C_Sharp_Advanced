using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SpecialWords
{
    class SpecialWords
    {
        static void Main(string[] args)
        {
            var specials = Console.ReadLine().Split(new[] { '(', ')', '[', ']', '<', '>', ',', '-', '!', '?', '‘', '’', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var text = Console.ReadLine();
            var count = 0;

            for (int i = 0; i < specials.Length; i++)
            {
                var index = text.IndexOf(specials[i]);

                while (index != -1)
                {
                    count++;
                    text = text.Remove(index, specials[i].Length);
                    index = text.IndexOf(specials[i]);
                }
                Console.WriteLine($"{specials[i]} - {count}");
                count = 0;
            }
        }
    }
}
