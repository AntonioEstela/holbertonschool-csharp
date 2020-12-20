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

/// <summary>Rectangle class that inherits from shape base class.</summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    public int Width
    {
        get
        {
            return this.width;
        }

        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");

            else
                this.width = value;
        }
    }
    public int Height
    {
        get
        {
            return this.height;
        }

        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");

            else
                this.height = value;
        }
    }

    /// <summary>Method Area that returns the area of the class</summary>
    public new int Area()
    {
        return this.height * this.width;
    }

    /// <summary>Returns the string representation of the class.</summary>
    public override string ToString()
    {
        return $"[{this.GetType().Name}]: {this.width} / {this.height}";
    }

}