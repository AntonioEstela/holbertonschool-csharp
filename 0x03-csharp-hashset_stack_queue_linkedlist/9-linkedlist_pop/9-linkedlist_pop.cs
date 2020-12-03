using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        LinkedListNode<int> headNode;

        if (myLList.Count == 0)
            return (0);

        headNode = myLList.First;

        myLList.RemoveFirst();

        return (headNode.Value);
    }
}