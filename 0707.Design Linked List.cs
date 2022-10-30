public class Node
{
    public Node next;
    public int val = 0;
}

public class MyLinkedList
{
    int count = 0;
    Node vHead = new();
    public int Get(int index)
    {
        if (index >= count)
        {
            return -1;
        }
        Node p = vHead;
        for (int i = 0; i <= index; i++)
        {
            p = p.next;
        }
        return p.val;
    }

    public void AddAtHead(int val) => AddAtIndex(0, val);
    public void AddAtTail(int val) => AddAtIndex(count, val);

    public void AddAtIndex(int index, int val)
    {
        if (index > count) return;
        if (index < 0) index = 0;
        Node p = vHead;
        for (int i = 0; i < index; i++)
        {
            p = p.next;
        }
        Node tmp = new Node();
        tmp.next = p.next;
        tmp.val = val;
        p.next = tmp;
        count++;
    }

    public void DeleteAtIndex(int index)
    {
        if (index >= count) return;
        Node p = vHead;
        for (int i = 0; i < index; i++)
        {
            p = p.next;
        }
        p.next = p.next.next;
        count--;
    }
}
