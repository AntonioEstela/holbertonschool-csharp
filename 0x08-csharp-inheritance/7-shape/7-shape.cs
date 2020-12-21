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

    // Represents the width of the Rectangle.
    private int width;
    // Represents the heigth of the Rectangle.
    private int height;

    /// <summary>Represents the width of the Rectangle.</summary>

    public int Width
    {
        get
        {
            return width;
        }

        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");

            else
                width = value;
        }
    }

    /// <summary>Represents the height of the Rectangle.</summary>

    public int Height
    {
        get
        {
            return height;
        }

        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");

            else
                height = value;
        }
    }

    /// <summary>Method Area that returns the area of the class</summary>
    public new int Area()
    {
        return height * width;
    }

    /// <summary>Returns the string representation of the class.</summary>
    public override string ToString()
    {
        return $"[Rectangle]: {width} / {height}";
    }

}