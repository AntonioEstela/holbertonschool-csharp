namespace Enemies
{
    /// <summary>Provides a new Zombie enemy type.</summary>
    public class Zombie
    {
        /// <summary>Int that represents the value of the Zombie health</summary>
        public int health;

        /// <summary>Initializes a new instance of the <see cref="Zombie"/>class.</summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>Initializes a new instance of the <see cref="Zombie"/>class with the given value greater than 0.</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new System.ArgumentException("Health must be greater than or equal to 0");

            else
                this.health = value;
        }
    }
}