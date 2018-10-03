using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var openTag = "<upcase>";
            var closeTag = "</upcase>";

            var openTagIndex = text.IndexOf(openTag);

            while (openTagIndex != - 1)
            {
                var closetagIndex = text.IndexOf(closeTag);

                if (closetagIndex == -1)
                {
                    break;
                }
                var forReplace = text.Substring(openTagIndex, closetagIndex - openTagIndex + closeTag.Length);
                var replaced = forReplace.Substring(openTag.Length, forReplace.Length - openTag.Length - closeTag.Length).ToUpper();

                text = text.Replace(forReplace, replaced);

                openTagIndex = text.IndexOf(openTag);

            }
            Console.WriteLine(text);
        }
    }
}
