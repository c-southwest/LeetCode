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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode vHead=new ListNode { next=head};
        ListNode slow=vHead, fast=vHead; 
        for (int i = 0; i < n; i++)
        {
            fast = fast.next;
        }
        while (fast.next != null)
        {
            fast = fast.next;
            slow = slow.next;
        }
        slow.next = slow.next.next;
        return vHead.next;
    }
}
