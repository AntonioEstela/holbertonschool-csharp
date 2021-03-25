using System;

/// <summary>Class player</summary>
public class Player
{
    string name;
    float maxHp;
    float hp;

    /// <summary>Public constructor for Player class</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
    
        if (maxHp > 0)
        {
            this.hp = maxHp;
            this.maxHp = maxHp;
        }
        else
        {
            this.maxHp = 100f;
            this.hp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
    }

     /// <summary>Method that prints the health of the player</summary>
     public void PrintHealth()
     {
         Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
     }


    /// <summary>Method that prints who and how many damage a player took</summary>
    public void TakeDamage(float damage)
    {
        if (damage > 0)
        {
            ValidateHP(this.hp -= damage);
            Console.WriteLine($"{this.name} takes {damage} damage!");
        }

        else
        {
            Console.WriteLine($"{this.name} takes 0 damage!");
        }
    }

    /// <summary>Method that prints who and how many heal a player took</summary>
    public void HealDamage(float heal)
    {
        if (heal > 0)
        {
            ValidateHP(this.hp += heal);
            Console.WriteLine($"{this.name} heals {heal} HP!");
        }

        else
        {
            Console.WriteLine($"{this.name} heals 0 HP!");
        }
    }

    /// <summary>Mehtod that validates the player HP</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;

        else if (newHp > this.maxHp)
            this.hp = this.maxHp;

        else
            this.hp = newHp;
    }


    /// <summary>Mehtod that Applies some modifiers</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        float returnValue = baseValue;
        if (modifier == Modifier.Weak)
            returnValue /= 2;

        else if (modifier ==  Modifier.Strong)
            returnValue *= 1.5f;

        return returnValue;
    }
}

/// <summary>Enumerator that contains modifier values</summary>
public enum Modifier
{
    /// <summary>Modifier value</summary>
    Weak,
    /// <summary>Modifier value</summary>
    Base,
    /// <summary>Modifier value</summary>
    Strong
}

/// <summary>Delegate CalculateModifier</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);


/// <summary>Delegate that takes a float value</summary>
public delegate void CalculateHealth(float value);