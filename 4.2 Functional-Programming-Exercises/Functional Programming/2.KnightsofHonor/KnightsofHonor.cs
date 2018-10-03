using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.KnightsofHonor
{
    class KnightsofHonor
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => n = "Sir" + " " + n);

            Action<IEnumerable<string>> name = Print;
            name(names);
        }
        public static void Print(IEnumerable<string> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
