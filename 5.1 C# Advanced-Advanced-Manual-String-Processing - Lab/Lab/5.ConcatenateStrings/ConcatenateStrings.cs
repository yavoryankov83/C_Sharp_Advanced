using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ConcatenateStrings
{
    class ConcatenateStrings
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var result = new StringBuilder();
            var separator = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result.Append(Console.ReadLine()).Append(" ");
            }
            Console.WriteLine(result);
        }
    }
}
