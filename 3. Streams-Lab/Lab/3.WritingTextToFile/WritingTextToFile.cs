using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WritingTextToFile
{
    class WritingTextToFile
    {
        static void Main(string[] args)
        {
            string text = "кирилица";
            var stream = new FileStream(@"D:\C#\C# Advanced - January 2018\3. Streams-Lab\Lab\3.WritingTextToFile\log.txt", FileMode.Create);

            try
            {
                var bytes = Encoding.UTF8.GetBytes(text);
                stream.Write(bytes, 0, bytes.Length);
            }
            finally
            {
                stream.Close();
            }
        }
    }
}
