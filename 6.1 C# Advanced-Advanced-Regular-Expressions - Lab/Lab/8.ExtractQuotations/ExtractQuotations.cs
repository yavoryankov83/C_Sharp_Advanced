using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8.ExtractQuotations
{
    class ExtractQuotations
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var pattern = @"('|"")(?<find>.+?)\1";
            var regex = new Regex(pattern);
                
            var maches = regex.Matches(line);

            foreach (Match item in maches)
            {
                Console.WriteLine(item.Groups["find"].Value);
            }
        }
    }
}
