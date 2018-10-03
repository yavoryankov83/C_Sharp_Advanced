using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PredicateParty
{
    class PredicateParty
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToList();

            string command;

            while ((command = Console.ReadLine()) != "Party!")
            {
                var com = command.Split();

                switch (com[1])
                {
                    case "StartsWith":
                        ForeachName(com[0], names, n => n.StartsWith(com[2]));
                        break;
                    case "EndsWith":
                        ForeachName(com[0], names, n => n.EndsWith(com[2]));
                        break;
                    case "Length":
                        ForeachName(com[0], names, n => n.Length == int.Parse(com[2]));
                        break;
                }
            }

            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine(string.Join(", ", names) + " " + "are going to the party!");
            }
        }

        private static void ForeachName(string command, List<string> names, Func<string, bool> condition)
        {
            for (int i = names.Count - 1; i >= 0; i--)
            {
                if (condition(names[i]))
                {
                    switch (command)
                    {
                        case "Remove":
                            names.RemoveAt(i);
                            break;
                        case "Double":
                            names.Add(names[i]);
                            break;
                    }
                }
            }
        }
    }
}
