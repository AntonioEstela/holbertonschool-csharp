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
}