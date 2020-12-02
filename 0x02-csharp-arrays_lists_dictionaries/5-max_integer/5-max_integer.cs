using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int maxInt;
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return (-1);
        }

        maxInt = myList[0];

        foreach (var item in myList)
        {
            if (item > maxInt)
                maxInt = item;
        }

        return (maxInt);
    }
}