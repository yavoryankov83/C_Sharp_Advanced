using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ActionPoint
{
    class ActionPoint
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();

            Action<string[]> printNames = name => Console.WriteLine(string.Join(Environment.NewLine, name));
            printNames(names);
        }
    }
}
