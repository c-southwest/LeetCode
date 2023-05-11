public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort<int>(nums);
        List<int[]> result = new List<int[]>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) 
                continue;
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                if (nums[i] + nums[left] + nums[right] == 0)
                {
                    result.Add(new int[] { nums[i], nums[left], nums[right] });
                    left++;
                    while (left < right && nums[left] == nums[left - 1])
                    {
                        left++;
                    }
                }
                else if (nums[i] + nums[left] + nums[right] > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }
        return result.ToArray();
    }
}
