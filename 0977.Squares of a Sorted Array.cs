public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int start = 0, end = nums.Length - 1;
        int[] result = new int[nums.Length];
        int result_index = end;
        while (start <= end)
        {
            if (Math.Abs(nums[start]) >= Math.Abs(nums[end]))
            {
                result[result_index--] = nums[start] * nums[start];
                start++;
            }
            else
            {
                result[result_index--] = nums[end] * nums[end];
                end--;
            }
        }
        return result;
    }

    // Play with LINQ
    public int[] SortedSquares2(int[] nums) => nums.Select(n => n * n).OrderBy(x => x).ToArray();
}
