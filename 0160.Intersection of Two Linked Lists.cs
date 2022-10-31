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
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        ListNode a = headA, b = headB;
        while (a != b)
        {
            a = (a == null) ? headB : a.next;
            b = (b == null) ? headA : b.next;
        }
        return a;
    }

    // Get length first 
    public ListNode GetIntersectionNode2(ListNode headA, ListNode headB)
    {
        ListNode a = headA, b = headB;
        int len_a = 0, len_b = 0;
        while (a != null)
        {
            len_a++;
            a = a.next;
        }
        while (b != null)
        {
            len_b++;
            b = b.next;
        }
        a = headA;
        b = headB;
        if (len_a >= len_b)
        {
            for (int i = 0; i < len_a - len_b; i++)
            {
                a = a.next;
            }
            while (a != b)
            {
                a = a.next;
                b = b.next;
            }
            return a;
        }
        else
        {
            for (int i = 0; i < len_b - len_a; i++)
            {
                b = b.next;
            }
            while (a != b)
            {
                a = a.next;
                b = b.next;
            }
            return a;
        }
    }
}
