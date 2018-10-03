using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemindersOfDevisionByThree
{
    class RemindersOfDevisionByThree
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 12 };

            List<List<int>> reminders = new List<List<int>>();

            for (int i = 0; i < 3; i++)
            {
                reminders.Add(new List<int>());
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                int reminder = currentNumber % 3;
                reminders[reminder].Add(currentNumber);
            }
        }
    }
}
