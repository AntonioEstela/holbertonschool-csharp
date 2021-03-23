using System;

abstract class Base
{
    public string name = null;

    /// <summary>
    /// abstract class called Base
    /// </summary>
    public override string ToString()
    {
        return name + " is a " + this.GetType();
    }
}