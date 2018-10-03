using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReverseNumberswithaStack
{
    class ReverseNumberswithaStack
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split();
            var stack = new Stack<string>(nums);

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
}
