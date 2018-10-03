using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.WriteToFile
{
    class WriteToFile
    {
        static void Main(string[] args)
        {
            using (var readStrem = new StreamReader(@"D:\C#\C# Advanced - January 2018\3. Streams-Lab\Lab\1.ReadFile\ReadFile.cs"))
            {
                using (var writeStream = new StreamWriter(@"D:\C#\C# Advanced - January 2018\3. Streams-Lab\Lab\1.ReadFile\reversed.txt"))
                {
                    string line;
                    while ((line = readStrem.ReadLine()) != null)
                    {
                        for (int i = line.Length - 1; i >= 0; i--)
                        {
                            writeStream.Write(line[i]);
                        }
                        writeStream.WriteLine();
                    }
                }
            }
        }
    }
}
