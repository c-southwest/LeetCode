public class Solution
{
    public int Search(int[] nums, int target)
    {
        if (nums.Length == 0) return -1;
        int start = 0;
        int end = nums.Length - 1;
        while (start <= end)
        {
            int mid = (end + start) / 2;
            if (target == nums[mid]) return mid;
            if (target > nums[mid]) start = mid + 1;
            if (target < nums[mid]) end = mid - 1;
        }
        return -1;
    }
}
