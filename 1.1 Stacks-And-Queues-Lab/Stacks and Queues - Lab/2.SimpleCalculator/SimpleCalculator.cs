using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SimpleCalculator
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var stack = new Stack<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stack.Push(input[i].ToString());
            }

            while (stack.Count > 1)
            {
                var element1 = stack.Pop();
                var sign = stack.Pop();
                var element2 = stack.Pop();

                if (sign == "+")
                {
                    stack.Push((int.Parse(element1) + int.Parse(element2)).ToString());
                }
                else
                {
                    stack.Push((int.Parse(element1) - int.Parse(element2)).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
