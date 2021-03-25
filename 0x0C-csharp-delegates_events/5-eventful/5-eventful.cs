using System;

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

/// <summary>Class player</summary>
public class Player
{
    string name;
    float maxHp;
    float hp;
    private string status;
    EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>Public constructor for Player class</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
    
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
        this.name = name;
		this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
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
            Console.WriteLine($"{this.name} takes {damage} damage!");
            ValidateHP(this.hp -= damage);
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
            Console.WriteLine($"{this.name} heals {heal} HP!");
            ValidateHP(this.hp += heal);
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

        OnCheckStatus(new CurrentHPArgs(this.hp));
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

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            this.status = $"{this.name} is in perfect health!";

        else if (e.currentHp >= (this.maxHp * 0.5f) && e.currentHp < this.maxHp)
            this.status = $"{this.name} is doing well!";

        else if (e.currentHp >= (this.maxHp * 0.25f) && e.currentHp < (this.maxHp * 0.5f))
            this.status = $"{this.name} isn't doing too great...";

        else if (e.currentHp > 0f && e.currentHp < (this.maxHp * 0.5f))
			this.status = $"{this.name} needs help!";
		
        else
			this.status = $"{this.name} is knocked out!";
		
        Console.WriteLine(this.status);
    }

    /// <summary>Mehtod HPValueWarning </summary>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
            Console.WriteLine("Health has reached zero!");

        else
            Console.WriteLine("Health is low!");
    }

    /// <summary>Mehtod OnCheckStatus</summary>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < (this.maxHp * 0.25f))
            HPCheck += HPValueWarning;
        
        HPCheck(this, e);
    }

}

/// <summary>CurrentHPArgs Class</summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>public float that cannot be modified</summary>
    public readonly float currentHp;

    /// <summary>Constructor for CurrentHPArgs</summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}