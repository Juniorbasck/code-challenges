// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

public class Solution()
{
    public static void Main()
    {

        int[] nums = new[] { 1, 2, 3, 1 };
        var result = ContainsDuplicate(nums);
        Console.WriteLine($"Expected true and actual = {result}");
        
        int[] numsCase2 = new[] { 1, 2, 3, 4 };
        var resultCase2 = ContainsDuplicate(numsCase2);
        Console.WriteLine($"Expected false and actual = {resultCase2}");
    }

    public static bool ContainsDuplicate(int[] nums)
    {
        var seens = new HashSet<int>();
        
        int size = nums.Length;

        for (int counter = 0; counter < size; counter++)
        {
            if (seens.Contains(nums[counter]))
            {
                return true;
            }

            seens.Add(nums[counter]);
        }
        
        return false;
    }
}