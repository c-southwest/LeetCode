

var nums = new int[]{3,2,1,5,6,4};
var k = 2;
System.Console.WriteLine(new Solution().FindKthLargest(nums,k));

public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int, int> pq = new();
        foreach (var n in nums)
        {
            pq.Enqueue(n,n);
            if(pq.Count>k){
                pq.Dequeue();
            }
        }
        return pq.Dequeue();
    }
}