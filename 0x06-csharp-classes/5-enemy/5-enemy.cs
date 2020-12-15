namespace Enemies
{
    /// <summary>Provides a new Zombie enemy type.</summary>
    public class Zombie
    {
        /// <summary>Int that represents the value of the Zombie health.</summary>
        public int health;

        // Private field that represents the name of the Zombie instance.
        private string name = "(No name)";

        /// <summary>String that represents the name of the Zombie instance.</summary>
        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

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
        
        /// <summary>Returns the value of health of the Zombie object.</summary>
        public int GetHealth()
        {
            return (this.health);
        }

        /// <summary>Public method that returns the string representation of the Zombie instance</summary>
        public override string ToString()
        {
            return ($"Zombie name: {this.name} / Total Health: {this.health}");
        }
    }
}