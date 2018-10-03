using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TriFunction
{
    class TriFunction
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split();

            Func<string, int, bool> isValid = (str, num) => 
            str.ToCharArray()
            .Select(ch => (int)ch)
            .Sum() >= num;

            Func<string[], int, Func<string, int, bool>, string> firstValidName = (arr, num, func) => 
            arr.FirstOrDefault(str => func(str, num));

            var result = firstValidName(names, n, isValid);
            Console.WriteLine(result);
        }
    }
}
