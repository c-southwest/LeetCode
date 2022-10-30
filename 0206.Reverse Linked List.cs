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
    // Create new objects
    public ListNode ReverseList(ListNode head)
    {
        ListNode vHead = new ListNode();
        while (head != null)
        {
            vHead.next = new ListNode(head.val, vHead.next);
            head = head.next;
        }
        return vHead.next;
    }

    // Two pointers
    public ListNode ReverseList2(ListNode head)
    {
        ListNode prev = null, tmp=null;
        while (head != null)
        {
            tmp = head.next;
            head.next = prev;
            prev = head;
            head = tmp;
        }
        return prev;
    }
}
