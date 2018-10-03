using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    class SayHello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, {0}!", PrintName());
        }
        private static string PrintName()
        {
            return Console.ReadLine();
        }
    }
}
