using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecimaltoBinaryConverter
{
    class DecimaltoBinaryConverter
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var stack = new Stack<int>();

            while (num > 0)
            {
                var reminder = num % 2;
                num = num / 2;

                stack.Push(reminder);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
