using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int nKeys = 0;
        
        if (myDict != null)
        {
            foreach (KeyValuePair<string, string> pair in myDict)
            {
                nKeys++;
            }
        }

        return (nKeys);
    }
}