using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = myLList.First;

        while (node.Next != null)
        {
            if (node.Value < n && node.Next.Value > n)
                return(myLList.AddAfter(node, n));

            node = node.Next;
        }

        return (myLList.AddLast(n));
    }
}