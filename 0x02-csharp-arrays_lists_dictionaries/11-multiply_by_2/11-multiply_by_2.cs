using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDictionary = new Dictionary<string, int>();

        if (myDict != null)
        {
            foreach (KeyValuePair<string, int> item in myDict)
            {
                newDictionary.Add(item.Key, item.Value * 2);
            }
        }
        return (newDictionary);
    }
}