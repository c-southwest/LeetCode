public class Solution
{
    // Fast, Slow Pointer
    public int RemoveElement(int[] nums, int val)
    {
        int slow = 0;
        for (int fast = 0; fast < nums.Length; fast++)
        {
            if (nums[fast] != val)
            {
                nums[slow++] = nums[fast];
            }
        }
        return slow;
    }

    // Swap
    public int RemoveElement2(int[] nums, int val)
    {
        int end=nums.Length-1;
        int start = 0;
        int count = 0;
        while (start <= end)
        {
            if (nums[end] == val)
            {
                count++;
                end--;
                continue;
            }
            if (nums[start] == val)
            {
                int tmp = nums[start];
                nums[start] = nums[end];
                nums[end] = tmp;
                count++;
                end--;
            }
            start++;
        }
        return nums.Length - count;
    }
}
