using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.ExtractIntegerNumbers
{
    class ExtractIntegerNumbers
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var pattern = @"[0-9]+";

            var regex = new Regex(pattern);

            var maches = regex.Matches(text);

            if (maches.Count == 0)
            {
                return;
            }
            else
            {
                foreach (var item in maches)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
