using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritance_Classes
{
    public class Cat : Animal
        // Cat inherits from Animal
        // Makes Cat a child of Animal
    {
        public Cat()
        {
            Console.WriteLine("This is the Cat Constructor.");
            IsMammal = true;
            TypeOfDiet = DietType.Carnivore;
            LivesLeft = 9;
        }

        public int LivesLeft { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Meow.");
        }

        public override void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves quickly!");
        }
    }

    public class Liger : Cat
        // Liger inherits from Cat
        // Grandchild of Animal
    {
        public Liger()
        {
            Console.WriteLine("This is the Liger Constructor.");
        }

        public string TeethSize { get; set; }


        public override void MakeSound()
        {
            Console.WriteLine("Roar.");
        }

        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} stalks its prey.");
            base.Move();
        }
    }
}
