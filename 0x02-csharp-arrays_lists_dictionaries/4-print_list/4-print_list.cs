using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> newList;

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }

        newList = new List<int>(size);

        for (int i = 0; i < size; i++)
        {
            newList.Add(i);
            Console.Write(newList[i]);

            if (i < size - 1)
                Console.Write(" ");
        }

        Console.WriteLine("");

        return (newList);
    }
}