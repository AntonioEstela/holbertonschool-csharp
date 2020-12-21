using System;
using System.Collections.Generic;

/// <summary>Provides some methods to work with Obj</summary>
class Obj
{
    /// <summary>Method that checks if the object is an instance ofa class that inherited from Array.</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}