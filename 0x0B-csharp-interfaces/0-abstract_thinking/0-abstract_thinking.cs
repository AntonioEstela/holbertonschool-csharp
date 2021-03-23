using System;

/// <summary>Abstract class called Base</summary>
abstract class Base
{
    /// <summary>name is a public property</summary>
    public string name;

    /// <summary>Function that overrides the ToString method</summary>
    public override string ToString()
    {
        return $"{name} is {this.GetType()}";
    }
}