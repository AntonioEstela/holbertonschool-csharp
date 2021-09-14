using System;

/// <summary>Abstract class called Base</summary>
public abstract class Base
{
    /// <summary>name is a public property</summary>
    public string name { get; set; }

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
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>property durability</summary>
   	public int durability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    
    ///<summary>Property isCollected</summary>
    	public bool isCollected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
   
   ///<summary>Property isCollected</summary>
    	public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    /// <summary>Method Interact</summary>
	public void Interact()
	{ throw new NotImplementedException(); }

    /// <summary>Method Break</summary>
	public void Break()
	{ throw new NotImplementedException(); }

    /// <summary>Method Collect</summary>
	public void Collect()
	{ throw new NotImplementedException(); }
}
