using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.InfernoIII
{
    class InfernoIII
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            ReadCommands(nums);

        }

        private static void ReadCommands(List<int> nums)
        {
            var exslusion = new Queue<KeyValuePair<string, int>>();

            var input = Console.ReadLine().Split(';');

            while (input[0] != "Forge")
            {
                var command = input[0];
                var filter = input[1];
                var parameter = int.Parse(input[2]);

                switch (command)
                {
                    case "Exclude":
                        exslusion.Enqueue(new KeyValuePair<string, int>(filter, parameter));
                        break;
                    case "Reverse":
                        if (exslusion.Count > 0)
                        {
                            exslusion.Dequeue();
                        }
                        break;
                }

                input = Console.ReadLine().Split(';');
            }

            ExecuteCommands(nums, exslusion);
            Console.WriteLine(string.Join(" ", nums));
        }

        private static void ExecuteCommands(List<int> nums, Queue<KeyValuePair<string, int>> exslusion)
        {
            foreach (var exs in exslusion.Reverse())
            {
                switch (exs.Key)
                {
                    case "Sum Left":
                        FilterLeft(exs.Value, nums);
                        break;
                    case "Sum Right":
                        FilterRight(exs.Value, nums);
                        break;
                    case "Sum Left Right":
                        FilterLeftRight(exs.Value, nums);
                        break;
                }
            }
        }

        private static void FilterLeftRight(int value, List<int> nums)
        {
            for(int i = 0; i < nums.Count; i++)
            {
                var leftGemPower = (i == 0) ? 0 : nums[i - 1];
                var rightGemPower = (i == nums.Count - 1) ? 0 : nums[i + 1];

                if (leftGemPower + nums[i] + rightGemPower == value)
                {
                    nums.RemoveAt(i);
                    i--;
                }
            }
        }

        private static void FilterRight(int value, List<int> nums)
        {
            while (nums.Count > 0 && nums.Last() == value)
            {
                nums.RemoveAt(nums.Count - 1);
            }

            for(int i = 0; i < nums.Count; i++)
            {
                var rightNum = (i == nums.Count - 1) ? 0 : nums[i + 1];

                if (nums[i] + rightNum == value)
                {
                    nums.RemoveAt(i);
                    i--;
                }
            }
        }

        private static void FilterLeft(int value, List<int> nums)
        {
            while (nums.Count > 0 && nums.First() == value)
            {
                nums.RemoveAt(0);
            }

            for (int i = nums.Count - 1; i >= 0; i--)
            {
                var leftNum = (i > 0) ? nums[i - 1] : 0;

                if (nums[i] + leftNum == value)
                {
                    nums.RemoveAt(i);
                }
            }
        }
    }
}
