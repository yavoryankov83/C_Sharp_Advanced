using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CopyingFile
{
    class CopyingFile
    {
        static void Main(string[] args)
        {
            using (var sourseFile = new FileStream(@"D:\C#\C# Advanced - January 2018\3. Streams-Lab\Lab\4.CopyingFile\stream.jpeg", FileMode.Open))
            {
                using (var destinationFile = new FileStream(@"D:\C#\C# Advanced - January 2018\3. Streams-Lab\Lab\4.CopyingFile\stream-copy.jpeg", FileMode.Create))
                {
                    var buffer = new byte[4096];
                    while (true)
                    {
                        var readBytes = sourseFile.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        else
                        {
                            destinationFile.Write(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
        }
    }
}
