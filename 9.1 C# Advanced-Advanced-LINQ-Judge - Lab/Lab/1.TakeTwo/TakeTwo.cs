using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TakeTwo
{
    class TakeTwo
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .Where(n => 10 <= n && n <= 20)
                .Take(2)
                .ToList()
                .ForEach(n => Console.Write(n + " "));
        }
    }
}
