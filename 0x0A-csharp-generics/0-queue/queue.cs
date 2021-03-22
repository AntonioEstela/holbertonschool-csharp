using System;

/// <summary>Generic class Queue</summary>
public class Queue<T>
{
    /// <summary>Function that returns the type of the instance</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
