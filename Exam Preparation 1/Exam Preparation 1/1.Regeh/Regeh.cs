using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.Regeh
{
    class Regeh
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();

            var input = Console.ReadLine();
            var len = input.Length;
            var currIndex = 0;

            var pattern = @"\[\w+<(\d+)REGEH(\d+)>\w+\]";

            var mathes = Regex.Matches(input, pattern);

            if (Regex.IsMatch(input, pattern))
            {
                foreach (Match match in mathes)
                {
                    currIndex += int.Parse(match.Groups[1].Value);
                    builder = AppendChar(input, currIndex, builder);

                    currIndex += int.Parse(match.Groups[2].Value);
                    builder = AppendChar(input, currIndex, builder);
                }

                Console.WriteLine(builder.ToString());
            }
        }

        private static StringBuilder AppendChar(string input, int currIndex, StringBuilder builder)
        {
            var len = input.Length;

            if (currIndex < len)
            {
                builder.Append(input[currIndex]);
            }
            else
            {
                builder.Append(input[currIndex % len + 1]);
            }

            return builder;
        }
    }
}
