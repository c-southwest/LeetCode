using System.Text;




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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode ans = new ListNode();
        var pointer = ans;
        int carry = 0;
        while (true)
        {
            pointer.val = ((l1 is null ? 0 : l1.val) + (l2 is null ? 0 : l2.val) + carry);
            carry = pointer.val < 10 ? 0 : 1;
            pointer.val %= 10;
            l1 = l1?.next;
            l2 = l2?.next;
            if(l1 is null && l2 is null) break;
            pointer.next = new ListNode();
            pointer = pointer.next;
        }
        if(carry==1)    pointer.next=new ListNode(carry );
        return ans;
    }
}