using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        KeyValuePair<string, int> bestScore;
        
        if (myList.Count == 0 || myList == null)
            return ("None");

        bestScore = myList.First();
        foreach (KeyValuePair<string, int> item in myList)
        {
            if (item.Value > bestScore.Value)
            {
                bestScore = item;
            }
        }

        return (bestScore.Key);
    }
}