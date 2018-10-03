using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PredicateforNames
{
    class PredicateforNames
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Func<string, bool> copmarer = n => n.Length <= length;

            names = names.Where(copmarer).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
