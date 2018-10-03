using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var stack = new Stack<string>();

            var text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var command = input[0];

                switch (command)
                {
                    case "1":
                        stack.Push(text);

                        var addText = input[1];
                        text += addText;
                        break;

                    case "2":
                        stack.Push(text);

                        var count = int.Parse(input[1]);
                        text = text.Substring(0, text.Length - count);
                        break;

                    case "3":
                        var index = int.Parse(input[1]);
                        Console.WriteLine(text[index - 1]);
                        break;

                    case "4":
                        text = stack.Pop();
                        break;
                }
            }
        }
    }
}
