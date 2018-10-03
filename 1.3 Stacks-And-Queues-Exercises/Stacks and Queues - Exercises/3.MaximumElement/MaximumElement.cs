using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            var maxStack = new Stack<int>();

            var max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var command = input[0];

                if (command == 1)
                {
                    var num = input[1];
                    if (num > max)
                    {
                        max = num;
                        maxStack.Push(max);
                    }

                    stack.Push(num);
                }
                else if (command == 2)
                {
                    if (stack.Peek() == maxStack.Peek() && maxStack.Count > 0)
                    {
                        maxStack.Pop();

                        if (maxStack.Count > 0)
                        {
                            max = maxStack.Peek();
                        }
                        else
                        {
                            max = int.MinValue;
                        }
                    }
                    stack.Pop();
                }
                else
                {
                    Console.WriteLine(max);
                }
            }
        }
    }
}
