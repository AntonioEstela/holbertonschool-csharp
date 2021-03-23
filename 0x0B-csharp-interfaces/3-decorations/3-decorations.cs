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

/// <summary>Class Decoration</summary>
public class Decoration : Base, IInteractive, IBreakable
{
    ///<summary>isQuestItem property</summary>
    public bool isQuestItem;

    ///<summary>durability property</summary>
    public int durability { get; set; }

    ///<summary>Consrtuctor for class Decoration</summary>
    public Decoration(String name = "Decoration",  int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }

        this.name = name;
        this.durability = durability;
        this.isQuestItem =  isQuestItem;
    }

    ///<summary>Interact method</summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {this.name} has been broken.");
        }
        else if (isQuestItem == true)
        {
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        }
        else if (isQuestItem == false)
        {
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }
    
    ///<summary>Break method</summary>
    public void Break()
    {
        durability -= 1;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        }
        else if(durability == 0)
        {
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {this.name} is already broken.");
        }
    }
}
