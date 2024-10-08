using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = TwoSum(nums, target);

        if (result != null)
        {
            Console.WriteLine($"Indeksi: {result[0]}, {result[1]}");
        }
        else
        {
            Console.WriteLine("Nema rijesenja.");
        }
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numDict.ContainsKey(complement))
            {
                return new int[] { numDict[complement], i };
            }

            numDict[nums[i]] = i;
        }

        return null;
    }
}
