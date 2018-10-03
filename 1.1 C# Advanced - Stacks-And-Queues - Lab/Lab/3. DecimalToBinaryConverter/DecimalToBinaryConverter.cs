using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecimalToBinaryConverter
{
    class DecimalToBinaryConverter
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var stack = new Stack<string>();

            if (input == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (input > 0)
                {
                    var reminder = input % 2;
                    stack.Push(reminder.ToString());
                    input /= 2;
                }
                while (stack.Count > 0)
                {
                    Console.Write(stack.Pop());
                }
                Console.WriteLine();
            }
        }
    }
}
