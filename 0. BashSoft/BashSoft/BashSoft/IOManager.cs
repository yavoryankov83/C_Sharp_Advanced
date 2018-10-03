using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public static class IOManager
    {
        public static void TraverseDirectory(string path)
        {
            OutputWriter.WriteEmptyLine();
            var initialIdentation = path.Split('\\').Length;
            var subFolder = new Queue<string>();
            subFolder.Enqueue(path);

            while (subFolder.Count != 0)
            {
                var currentPath = subFolder.Dequeue();
                var identation = currentPath.Split('\\').Length - initialIdentation;
                OutputWriter.WriteMessageOnNewLine(string.Format($"{new string('-', identation)}{currentPath}"));

                foreach (var directoryPath in Directory.GetDirectories(currentPath))
                {
                    subFolder.Enqueue(directoryPath);
                }
            }
        }
    }
}
