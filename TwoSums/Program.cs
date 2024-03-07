using System;

public class TwoSumProgram
{
    public static int[] TwoSums(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            }
        }
        return new int[] { -1, -1 };
    }

    public static void Main()
    {
        Console.Write("Enter the elements of the array, separated by commas: ");
        string[] input = Console.ReadLine().Split(',');

        int[] nums = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = int.Parse(input[i]);
        }

        Console.Write("Enter the target sum: ");
        int target = int.Parse(Console.ReadLine());

        int[] result = TwoSums(nums, target);

        if (result[0] != -1)
        {
            Console.WriteLine($"Indices: {result[0]} and {result[1]}");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
}