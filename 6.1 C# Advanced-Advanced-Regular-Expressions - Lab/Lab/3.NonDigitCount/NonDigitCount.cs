using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.NonDigitCount
{
    class NonDigitCount
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var pattern = @"[^0-9]";

            var regex = new Regex(pattern);
            var maches = regex.Matches(text).Count;

            Console.WriteLine($"Non-digits: {maches}");
        }
    }
}
