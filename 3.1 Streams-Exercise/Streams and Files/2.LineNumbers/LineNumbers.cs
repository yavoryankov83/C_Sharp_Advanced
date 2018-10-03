using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            using (var sourseFile = new StreamReader(@"..\..\text.txt"))
            {
                using (var destFile = new StreamWriter(@"..\..\output.txt"))
                {
                    var count = 1;
                    string line;
                    while ((line = sourseFile.ReadLine()) != null)
                    {
                        destFile.WriteLine($"Line {count}: " + line);
                        count++;
                    }
                }
            }
        }
    }
}
