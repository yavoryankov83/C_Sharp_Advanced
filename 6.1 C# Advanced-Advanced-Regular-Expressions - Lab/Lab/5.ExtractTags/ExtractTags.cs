using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5.ExtractTags
{
    class ExtractTags
    {
        static void Main(string[] args)
        {
            var pattern = @"<.+?>";
            var regex = new Regex(pattern);

            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input;

                var maches = regex.Matches(input);
                foreach (var item in maches)
                {
                    Console.WriteLine(item);
                }

                input = Console.ReadLine();
            }
        }
    }
}
