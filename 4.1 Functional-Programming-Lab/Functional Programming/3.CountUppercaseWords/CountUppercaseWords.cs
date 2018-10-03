using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CountUppercaseWords
{
    class CountUppercaseWords
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Where(c => char.IsUpper(c[0]));

            foreach (var l in line)
            {
                Console.WriteLine(l);
            }
        }
    }
}
