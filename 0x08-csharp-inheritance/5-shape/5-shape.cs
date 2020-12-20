using System;

/// <summary>Shape base class</summary>
class Shape
{

    /// <summary>Not implemented class that should return the area of the shape</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}