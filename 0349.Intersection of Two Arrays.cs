public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var set1 = nums1.ToHashSet();
        set1.IntersectWith(nums2);
        return set1.ToArray();
    }
}