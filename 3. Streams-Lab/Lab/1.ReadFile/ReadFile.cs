using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReadFile
{
    class ReadFile
    {
        static void Main(string[] args)
        {
            using (var stream = new StreamReader(@"D:\C#\C# Advanced - January 2018\3. Streams-Lab\Lab\1.ReadFile\ReadFile.cs"))
            {
                var lineNumber = 1;
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    Console.WriteLine($"Line {lineNumber}: " + line);
                    lineNumber++;
                }
            }
        }
    }
}
