public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        if (head is null) return null;
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                ListNode p1 = head;
                while (p1 != slow)
                {
                    p1= p1.next;
                    slow=slow.next;
                }
                return p1;
            }
        }
        return null;
    }
}
