using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int maxInt = 0;
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return (-1);
        }

        foreach (var item in myList)
        {
            if (item > maxInt)
                maxInt = item;
        }

        return (maxInt);
    }
}