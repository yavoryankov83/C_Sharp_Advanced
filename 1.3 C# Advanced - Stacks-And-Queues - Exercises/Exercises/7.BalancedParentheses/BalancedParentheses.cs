using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            var signs = new char[] { '(', '[', '{' };

            for (int i = 0; i < input.Length; i++)
            {
                if (signs.Contains(input[i]))
                {
                    stack.Push(input[i]);
                }
                else
                {
                    if (stack.Count() == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    if (input[i] == ')')
                    {
                        if (stack.Pop() != '(')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else if (input[i] == ']')
                    {
                        if (stack.Pop() != '[')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else if (input[i] == '}')
                    {
                        if (stack.Pop() != '{')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
