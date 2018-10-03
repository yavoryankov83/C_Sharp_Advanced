using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.UpperStrings
{
    class UpperStrings
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split()
                .Select(s => s.ToUpper())
                .ToList()
                .ForEach(s => Console.Write(s + " "));
        }
    }
}
