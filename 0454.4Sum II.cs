public class Solution
{
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
    {
        Dictionary<int, int> dic1 = new Dictionary<int, int>();
        foreach (int i1 in nums1)
        {
            foreach (int i2 in nums2)
            {
                if (dic1.ContainsKey(i1 + i2))
                {
                    dic1[i1 + i2]++;
                }
                else
                {
                    dic1[i1 + i2]=1;
                }
            }
        }
        int count = 0;
        foreach (int i3 in nums3)
        {
            foreach (int i4 in nums4)
            {
                if (dic1.TryGetValue(-i3 - i4, out int value))
                {
                    count+= value;
                }
                
            }
        }
        return count;
    }
}