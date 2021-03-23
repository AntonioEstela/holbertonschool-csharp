using System;

/// <summary>Abstract class called Base</summary>
public abstract class Base
{
    /// <summary>name is a public property</summary>
    public string name;

    /// <summary>Function that overrides the ToString meth</summary>
    public override string ToString()
    {
        return $"{this.name} is a {this.GetType().Name}";
    }
}

/// <summary>Interface IInteractive</summary>
public interface IInteractive
{
    /// <summary>Method Interact</summary>
    void Interact();
}

/// <summary>Interface IBreakable</summary>
public interface IBreakable
{
    /// <summary>property durability</summary>
    int durability { get; set; }

    /// <summary>Method Break</summary>
    void Break();
}

/// <summary>Interface ICollectable</summary>
public interface ICollectable
{
    /// <summary>property isCollected</summary>
    bool isCollected { get; set; }

    /// <summary>Method Collect</summary>
    void Collect();
}

/// <summary>Class TestObject</summary>
public class Door : Base, IInteractive
{
    /// <summary>Constructor for Door class</summary>
    public Door(string name= "Door")
    {
        this.name = name;
    }

    /// <summary>Method Interact</summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}