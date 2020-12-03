using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = myLList.First;
        LinkedListNode<int> newNode = new LinkedListNode<int>(0);

        while (node.Next != null)
        {
            if (node.Value < n && node.Next.Value > n)
            {
                newNode = myLList.AddAfter(node, n);
                break;
            }
            node = node.Next;
        }

        return (newNode);
    }
}