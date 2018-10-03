using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MatchingBrackets
{
    class MatchingBrackets
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                var element = input[i];

                if (element == '(')
                {
                    stack.Push(i);
                }
                else if (element == ')')
                {
                    var firstIndex = stack.Peek();
                    
                    Console.WriteLine(input.Substring(firstIndex, i - firstIndex + 1));

                    stack.Pop();
                }
            }
        }
    }
}
