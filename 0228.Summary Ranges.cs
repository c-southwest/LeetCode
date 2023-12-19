public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        int a = -1, b = -1, flag = 0;
        List<string> res = new List<string>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (flag != 0)
            {
                if (nums[i] - 1 == nums[i - 1])
                {
                }
                else
                {
                    b = nums[i - 1];
                    if (a == b)
                    {
                        res.Add($"{a}");
                    }
                    else
                    {
                        res.Add($"{a}->{b}");
                    }

                    a = nums[i];
                }
            }
            else
            {
                a = nums[i];
                flag = 1;
            }

            if (i == nums.Length - 1)
            {
                if (a == nums[i])
                {
                    res.Add($"{a}");
                }
                else
                {
                    res.Add($"{a}->{nums[i]}");
                }
            }
        }

        return res;
    }

    public static void Main()
    {
        var s = new Solution();
        var r = s.SummaryRanges([0, 1, 2, 4, 5, 7]);
        foreach (var item in r)
        {
            Console.WriteLine(item);
        }
    }
}
