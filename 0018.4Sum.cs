public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        Array.Sort<int>(nums);
        List<int[]> result = new List<int[]>();
        for (int a = 0; a < nums.Length - 3; a++)
        {
            // Prevent duplicate a
            if (a > 0 && nums[a] == nums[a - 1])
                continue;

            for (int b = a + 1; b < nums.Length - 2; b++)
            {
                // Prevent duplicate b
                if (b > a + 1 && nums[b] == nums[b - 1])
                    continue;

                int left = b + 1, right = nums.Length - 1;
                while (left < right)
                {
                    long sum = (long)nums[a] + (long)nums[b] + (long)nums[left] + (long)nums[right];
                    if (sum > target)
                    {
                        right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        result.Add(new int[] { nums[a], nums[b], nums[left], nums[right] });
                        left++;
                        while (nums[left] == nums[left - 1] && left<right)
                        {
                            left++;
                        }
                    }
                }
            }
        }
        return result.ToArray();
    }
}
