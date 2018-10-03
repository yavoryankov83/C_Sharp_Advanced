using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            var dictionary = new SortedDictionary<string, int>();
            var sourceFile = File.ReadAllText(@"..\..\words.txt");
            var words = sourceFile.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            var pattern = @"[a-zA-Z]+";
            var regex = new Regex(pattern);

            using (var reader = new StreamReader(@"..\..\text.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var matches = regex.Matches(line);

                    foreach (Match match in matches)
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            if (match.Value.ToLower() == words[i] && !(dictionary.ContainsKey(words[i])))
                            {
                                dictionary.Add(words[i], 1);
                            }
                            else if (match.Value.ToLower() == words[i])
                            {
                                dictionary[words[i]]++;
                            }
                        }
                    }
                }
            }
            using (var writer = new StreamWriter(@"..\..\result.txt"))
            {
                foreach (var item in dictionary.OrderByDescending(k => k.Value))
                {
                    writer.WriteLine($"{item.Key}-{item.Value}");
                }
            }
        }
    }
}
