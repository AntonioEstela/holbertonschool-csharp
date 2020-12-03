using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newLinkList = new LinkedList<int>();
        if (size < 0)
            return (newLinkList);

        for (int value = 0; value < size; value++)
            newLinkList.AddLast(value);

        foreach (var item in newLinkList)
            Console.WriteLine(item);

        return (newLinkList);
    }
}