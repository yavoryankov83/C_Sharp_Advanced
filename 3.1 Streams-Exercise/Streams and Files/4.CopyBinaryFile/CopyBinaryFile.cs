using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4.CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            using (var sourseReader = new FileStream(@"..\..\copyMe.png", FileMode.Open))
            {
                using (var destWriter = new FileStream(@"..\..\copied.png", FileMode.Create))
                {
                    var buffer = new byte[4096];

                    while (true)
                    {
                        var readBytes = sourseReader.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0)
                        {
                            break;
                        }
                        destWriter.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
