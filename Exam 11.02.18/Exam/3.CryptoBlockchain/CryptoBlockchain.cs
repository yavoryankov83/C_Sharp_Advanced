using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.CryptoBlockchain
{
    class CryptoBlockchain
    {
        static void Main(string[] args)
        {
            var patternBlock = @"(\[(.|\n)+?])|({(.|\n)+?})";

            var numberPattern = @"(\d{3,})";

            var builder = new StringBuilder();

            var rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine();
                builder.Append(input);
            }

            var block = builder.ToString();

            var matches = Regex.Matches(block, patternBlock, RegexOptions.Multiline);

            builder.Clear();

            foreach (Match match in matches)
            {
                var blockMatch = match.Value;
                var IsNumMatches = Regex.IsMatch(blockMatch, numberPattern);

                var numMatch = Regex.Match(blockMatch, numberPattern);

                var numMatchAsString = numMatch.Value;

                var length = 0;

                if (IsNumMatches && ((numMatchAsString.Length) % 3 == 0))
                {
                    length = blockMatch.Length;

                    for (int i = 0; i < numMatchAsString.Length; i += 3)
                    {
                        var stringNum = numMatchAsString[i] + "" + numMatchAsString[i + 1] + numMatchAsString[i + 2];
                        var num = int.Parse(stringNum) - length;

                        var numAsChar = (char)num;

                        builder.Append(numAsChar);
                    }
                }
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
