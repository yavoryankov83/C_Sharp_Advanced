using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.StackFibonacci
{
    class StackFibonacci
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var stack = new Stack<long>();

            stack.Push(0);
            stack.Push(1);

            for (int i = 0; i < num - 1; i++)
            {
                var first = stack.Pop();

                var next = first + stack.Pop();

                stack.Push(first);
                stack.Push(next);
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
