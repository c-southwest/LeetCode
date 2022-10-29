public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int start = 0, end = 0, sum = 0, minimal = int.MaxValue;
        while (end < nums.Length)
        {
            sum += nums[end++];
            while (sum >= target)
            {
                minimal = Math.Min(end-start, minimal);
                sum -= nums[start++];
            }
        }
        return minimal == int.MaxValue ? 0 : minimal;
    }
}
