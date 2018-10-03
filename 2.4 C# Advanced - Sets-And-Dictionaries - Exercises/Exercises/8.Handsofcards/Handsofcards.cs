using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Handsofcards
{
    class Handsofcards
    {
        static void Main(string[] args)
        {
            var cardsSet = new Dictionary<string, HashSet<string>>();
            var result = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while (input != "JOKER")
            {
                var tokens = input
                    .Split(new[] { ": " }, StringSplitOptions
                    .RemoveEmptyEntries);

                var name = tokens[0];
                var cards = tokens[1]
                    .Split(new[] { ", " }, StringSplitOptions
                    .RemoveEmptyEntries);

                if (!cardsSet.ContainsKey(name))
                {
                    cardsSet.Add(name, new HashSet<string>());
                }
                for (int i = 0; i < cards.Length; i++)
                {
                    cardsSet[name].Add(cards[i]);
                }

                input = Console.ReadLine();
            }

            foreach (var pair in cardsSet)
            {
                var name = pair.Key;
                var cards = pair.Value;
                var sum = 0;

                foreach (string card in cards)
                {
                    var type = card[card.Length - 1];
                    var power = card.Substring(0, card.Length - 1);

                    int a = 0;
                    int b = 0;

                    switch (type)
                    {
                        case 'S':
                            b = 4;
                            break;
                        case 'H':
                            b = 3;
                            break;
                        case 'D':
                            b = 2;
                            break;
                        case 'C':
                            b = 1;
                            break;
                    }

                    switch (power)
                    {
                        case "2":
                            a = 2;
                            break;
                        case "3":
                            a = 3;
                            break;
                        case "4":
                            a = 4;
                            break;
                        case "5":
                            a = 5;
                            break;
                        case "6":
                            a = 6;
                            break;
                        case "7":
                            a = 7;
                            break;
                        case "8":
                            a = 8;
                            break;
                        case "9":
                            a = 9;
                            break;
                        case "10":
                            a = 10;
                            break;
                        case "J":
                            a = 11;
                            break;
                        case "Q":
                            a = 12;
                            break;
                        case "K":
                            a = 13;
                            break;
                        case "A":
                            a = 14;
                            break;
                    }

                    sum += a * b;
                }

                result.Add(name, sum);
            }

            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
