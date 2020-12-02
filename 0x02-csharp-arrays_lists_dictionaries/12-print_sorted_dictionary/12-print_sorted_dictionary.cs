using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        foreach (KeyValuePair<string, string> item in myDict.OrderBy(key => key.Key))
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}