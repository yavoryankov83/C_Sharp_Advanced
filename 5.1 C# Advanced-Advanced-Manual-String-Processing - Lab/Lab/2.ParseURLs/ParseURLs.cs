using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ParseURLs
{
    class ParseURLs
    {
        static void Main(string[] args)
        {
            var url = Console.ReadLine();

            var protocolSeparator = "://";
            var resourseSeparator = "/";

            if (url.IndexOf(protocolSeparator) == -1 || url.IndexOf(resourseSeparator) == -1)
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            var secondTime = url.Substring(url.IndexOf(protocolSeparator) + protocolSeparator.Length);

            if (secondTime.IndexOf(protocolSeparator) != -1)
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            var protocol = url.Substring(0, url.IndexOf(protocolSeparator));

            url = url.Substring(url.IndexOf(protocolSeparator) + protocolSeparator.Length);
            var resourseIndex = url.IndexOf(resourseSeparator);

            var server = url.Substring(0, resourseIndex);

            var resourse = url.Substring(resourseIndex + 1);

            Console.WriteLine($"Protocol = {protocol}");
            Console.WriteLine($"Server = {server}");
            Console.WriteLine($"Resources = {resourse}");
        }
    }
}
