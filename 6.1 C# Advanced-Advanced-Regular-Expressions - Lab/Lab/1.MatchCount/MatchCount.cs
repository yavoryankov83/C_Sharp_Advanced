using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.MatchCount
{
    class MatchCount
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            var regex = new Regex(word);

            var text = Console.ReadLine();

            var maches = regex.Matches(text);

            var count = maches.Count;

            Console.WriteLine(count);
        }
    }
}
