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
            var input = Console.ReadLine();

            var stack = new Stack<string>(input.Split().Reverse());

            while (stack.Count > 1)
            {
                var first = int.Parse(stack.Pop());
                var opr = stack.Pop();
                var second = int.Parse(stack.Pop());

                if (opr == "+")
                {
                    var num = first + second;
                    stack.Push(num.ToString());
                }
                else
                {
                    var num = first - second;
                    stack.Push(num.ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
