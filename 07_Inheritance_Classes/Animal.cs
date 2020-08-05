using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritance_Classes
{
    public enum DietType { Herbivore, Omnivore, Carnivore }
    public class Animal
    {
        //Constructor
        public Animal()
        {
            Console.WriteLine("This is the Animal Constructor.");
        }

        // Properties
        public int LegCount { get; set; }
        public bool IsMammal { get; set; }
        public bool HasTail { get; set; }
        public DietType TypeOfDiet { get; set; }

        // Method
        public virtual void Move()
            // Virtual - allows this method marks it as the ability to be overwritten
            // Allows us to come in later and modifies what it will look like
        {
            Console.WriteLine($"This {GetType().Name} moves.");
            // GetType gets the type of the current instance
            // .Name comes from what object GetType returns
        }

        public override string ToString()
        // override - Going to do something different than what the original intention was
        // ToString method is overridden
        {
            return base.ToString();
        }
    }
}
