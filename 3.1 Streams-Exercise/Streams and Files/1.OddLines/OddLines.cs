using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            using (var readStream = new StreamReader(@"..\..\text.txt"))
            {
                string line;
                var count = 1;

                while ((line = readStream.ReadLine()) != null)
                {
                    if (count % 2 == 0)
                    {
                        Console.WriteLine(line);
                    }
                    count++;
                }
            }
        }
    }
}
