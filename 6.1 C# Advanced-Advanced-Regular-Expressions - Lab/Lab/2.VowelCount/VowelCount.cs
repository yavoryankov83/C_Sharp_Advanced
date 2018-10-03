using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.VowelCount
{
    class VowelCount
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var pattern = @"[aeiouyAEIOUY]";

            var regex = new Regex(pattern);

            var maches = regex.Matches(text).Count;

            Console.WriteLine($"Vowels: {maches}");
        }
    }
}
