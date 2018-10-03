using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StudentsResults
{
    class StudentsResults
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var firstRow = $"{"Name",-10}|{"CAdv",7}|{"COOP",7}|{"AdvOOP",7}|{"Average",7}|";
            Console.WriteLine(firstRow);

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ', '-', ',', }, StringSplitOptions
                    .RemoveEmptyEntries);

                var name = input[0];
                var firstResult = double.Parse(input[1]);
                var secondResult = double.Parse(input[2]);
                var thirdResult = double.Parse(input[3]);
                var average = (firstResult + secondResult + thirdResult) / 3;

                var lastRow = $"{name,-10}|{firstResult,7:f2}|{secondResult,7:f2}|{thirdResult,7:f2}|{average,7:f4}|";
                Console.WriteLine(lastRow);
            }
        }
    }
}
