int[] arr = new int[] { 1, 2, 2 };

int r = new Solution().RemoveDuplicates(arr);
Console.WriteLine(r);
Console.WriteLine();
foreach (int i in arr)
{
    Console.WriteLine(i);
}

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 1)
        {
            return nums.Length;
        }
        int fast = 1, slow = 0;
        while (fast < nums.Length)
        {

            if (nums[fast] == nums[slow])
            {
                fast++;
            }
            else
            {
                nums[++slow] = nums[fast++];
            }
        }
        return slow+1;
    }
}