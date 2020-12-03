using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        int result = 0;

        foreach (var item in myList.Distinct())
        {
            result += item;
        }

        return (result);
    }
}