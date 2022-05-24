var height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
var s = new Solution();
var r = s.MaxArea(height);
Console.WriteLine(r);

public class Solution
{
    public int MaxArea(int[] height)
    {
        int start = 0;
        int end = height.Length-1;
        int maxArea = -1;
        while (start < end)
        {
            int area = (end- start) * (height[start] < height[end] ? height[start++] : height[end--]);
            maxArea = area > maxArea ? area : maxArea;
        }
        return maxArea;
    }
}
