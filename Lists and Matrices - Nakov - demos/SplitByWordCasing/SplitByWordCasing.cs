using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new char[] { ',', ';', ':', '.', '!', '(', ')',
                '"', '[', ']', ' ', '/', '\\', '\'' }).ToList();

            List<string> listLower = new List<string>();
            List<string> listUpper = new List<string>();
            List<string> listMixed = new List<string>();

            foreach (string word in words)
            {
                var lowerCounter = 0;
                var upperCounter = 0;

                foreach (char letter in word)
                {
                    if (char.IsLower(letter))
                    {
                        lowerCounter++;
                    }
                    else if (char.IsUpper(letter))
                    {
                        upperCounter++;
                    }
                }
                if (word.Length == lowerCounter)
                {
                    listLower.Add(word);
                }
                else if (word.Length == upperCounter)
                {
                    listUpper.Add(word);
                }
                else
                {
                    listMixed.Add(word);
                }
            }
            Console.WriteLine(string.Join(",", listLower));
            Console.WriteLine(string.Join(",", listUpper));
            Console.WriteLine(string.Join(",", listMixed));
        }
    }
}
