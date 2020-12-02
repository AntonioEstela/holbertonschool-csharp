using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> divisibleList = new List<bool>(myList.Count);

        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 == 0)
                divisibleList.Add(true);

            else
                divisibleList.Add(false);
        }

        return (divisibleList);
    }
}