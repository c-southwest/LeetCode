public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> index = new Dictionary<int, int>();
        for (int i=0; i<nums.Length; i++)
        {
            if (index.ContainsKey(nums[i]))
            {
                if (i - index[nums[i]] <= k)
                {
                    return true;
                }
                else
                {
                    index[nums[i]] = i;
                }
            }
            else
            {
                index.Add(nums[i],i);
            }
        }

        return false;
    }

    public static void Main()
    {
        var s = new Solution();
        var r = s.ContainsNearbyDuplicate([1,2,3,1], 3);
        Console.WriteLine(r);
    }
}
