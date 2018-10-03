using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PartyReservationFilterModule
{
    public class PartyReservationFilterModule
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var filters = GetFilters();
            names = FilterNames(filters, names);
            Console.WriteLine(string.Join(" ", names));
            //var names = Console.ReadLine()
            //    .Split()
            //    .ToList();

            //ReadCommands(names);
        }
        private static string[] FilterNames(HashSet<Filter> filters, string[] names)
        {
            foreach (Filter filter in filters)
            {
                if (filter.Command.Contains("starts"))
                {
                    names = Filter.FilterCollection(names, n => n.StartsWith(filter.Arg, StringComparison.InvariantCultureIgnoreCase));
                }
                else if (filter.Command.Contains("ends"))
                {
                    names = Filter.FilterCollection(names, n => n.EndsWith(filter.Arg, StringComparison.InvariantCultureIgnoreCase));
                }
                else if (filter.Command.Contains("length"))
                {
                    names = Filter.FilterCollection(names, n => n.Length == int.Parse(filter.Arg));
                }
                else if (filter.Command.Contains("contains"))
                {
                    names = Filter.FilterCollection(names, n => n.ToLower().Contains(filter.Arg.ToLower()));
                }
            }

            return names;
        }

        private static HashSet<Filter> GetFilters()
        {
            // The possible TPRF filter types are: "Starts with", "Ends with", "Length" and "Contains
            var filters = new HashSet<Filter>();
            var input = Console.ReadLine()
                .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            while (input[0] != "Print")
            {

                var currentFilter = new Filter() { Command = input[1].ToLower(), Arg = input[2] };

                if (input[0].StartsWith("Add"))
                {
                    filters.Add(currentFilter);
                }
                else if (input[0].StartsWith("Remove"))
                {
                    filters.RemoveWhere(f =>
                            f.Arg == currentFilter.Arg &&
                            f.Command == currentFilter.Command);
                }

                input = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            }

            return filters;
        }

        //private static void ReadCommands(List<string> names)
        //{
        //    string input;

        //    while ((input = Console.ReadLine()) != "Print")
        //    {
        //        var command = input.Split(';').ToList();
        //        var com = command[0];
        //        var filter = command[1];
        //        var parameter = command[2];

        //        switch (filter)
        //        {
        //            case "Starts with":
        //                ForeachName(com, names, s => s.StartsWith(parameter));
        //                break;
        //            case "End with":
        //                ForeachName(com, names, s => s.EndsWith(parameter));
        //                break;
        //            case "Length":
        //                ForeachName(com, names, s => s.Length == int.Parse(parameter));
        //                break;
        //            case "Contains":
        //                ForeachName(com, names, s => s.Contains(parameter));
        //                break;
        //        }
        //    }
        //    Console.WriteLine(string.Join(" ", names));
        //}

        //private static List<string> ForeachName(string com, List<string> names, Func<string, bool> condition)
        //{
        //    for (int i = names.Count - 1; i >= 0; i--)
        //    {
        //        var name = names[i];

        //        if (condition(names[i]))
        //        {
        //            switch (com)
        //            {
        //                case "Add filter":
        //                    names.RemoveAt(i);
        //                    break;
        //                case "Remove filter":
        //                    names.Add(name);
        //                    break;
        //            }
        //        }
        //    }
        //    return names;
        //}
    }
    public class Filter
    {
        public string Command { get; set; }

        public string Arg { get; set; }

        public static string[] FilterCollection(string[] collection, Func<string, bool> filter)
        {
            return collection.Where(n => !filter(n)).ToArray();
        }
    }
}
