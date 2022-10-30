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
    public ListNode SwapPairs(ListNode head)
    {
        ListNode vHead = new ListNode(next:head);
        ListNode p = vHead;
        while (p.next != null && p.next.next != null)
        {
            ListNode tmp_3 = p.next.next.next;
            ListNode tmp_1 = p.next;
            p.next = p.next.next;   // -> 2nd
            p.next.next = tmp_1;    // 2nd -> 1st
            tmp_1.next = tmp_3;     // 1st -> 3rd
            p = p.next.next;
        }
        return vHead.next;
    }

    // My original
    public ListNode SwapPairs2(ListNode head)
    {
        ListNode vHead = new ListNode(next: head);
        ListNode p1 = head, p2 = head?.next, p2_backup = vHead;
        while (p1 != null && p2 != null)
        {
            p1.next = p2.next;
            p2.next = p1;
            p2_backup.next = p2;
            p2_backup = p1;
            p1 = p1?.next;
            p2 = p1?.next;
        }
        return vHead.next;
    }
}
