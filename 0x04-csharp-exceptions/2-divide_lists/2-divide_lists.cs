using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        int length = list1.Count > list2.Count ? list1.Count : list2.Count;
        List<int> newList = new List<int>();

        for (int i = 0; i < length; i++)
        {
            try
            {
                newList.Add(list1[i] / list2[i]);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            catch (DivideByZeroException)
            {
                newList.Add(0);
                Console.WriteLine("Cannot divide by zero");
            }
        }

        return (newList);
    }
}