using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            //var words = Console.ReadLine().Split(' ').ToList();
            //Random rnd = new Random();

            //var result = new List<string>();

            //while (words.Count > 0)
            //{
            //    var randomPos = rnd.Next(0, words.Count);
            //    result.Add(words[randomPos]);
            //    words.RemoveAt(randomPos);
            //}
            //Console.WriteLine(string.Join(" ", result));

            //second way
            var words = Console.ReadLine().Split(' ').ToArray();
            Random rnd = new Random();

            for (int pos = 0; pos < words.Length; pos++)
            {
                var randomPos = rnd.Next(0, words.Length);
                var oldWord = words[pos];
                words[pos] = words[randomPos];
                words[randomPos] = oldWord;
            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
