public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var has = dict.ContainsKey(nums[i]);    // If current number satisfy the difference somewhere?
            if (has) { 
                return new[] { i, dict[nums[i]] };  
            }
            dict[target - nums[i]] = i;     // Store the difference and index
        }
        return new[] { 0, 0 };
    }
}