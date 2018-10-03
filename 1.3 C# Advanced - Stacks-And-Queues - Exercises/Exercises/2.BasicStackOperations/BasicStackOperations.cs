using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var nums = Console.ReadLine().Split();

            var stack = new Stack<string>(nums);

            for (int i = 0; i < int.Parse(input[1]); i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (stack.Contains(input[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    var smallest = stack.Min();
                    Console.WriteLine(smallest);
                }
            }
        }
    }
}
