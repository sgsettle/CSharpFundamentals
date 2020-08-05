using System;
using System.Collections.Generic;
using _07_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_Inheritance_Tests
{
    [TestClass]
    public class CatTests
    {
        [TestMethod]
        public void ConstructorTests()
        {
            Animal casey = new Animal();
            casey.Move();

            Console.WriteLine();

            Cat mittens = new Cat();
            mittens.Move();
            mittens.MakeSound();

            Console.WriteLine();

            Cat content = new Liger();
            content.Move();
            content.MakeSound();

            // content and garfield are both referencing Liger object, but content is Cat type and garfield is Liger type

            Liger garfield = (Liger)content;
            //              casting content as a Liger
            garfield.TeethSize = "Kinda large";

            Console.WriteLine();

            Liger billieJoel = new Liger();
            billieJoel.Move();
            billieJoel.MakeSound();
            billieJoel.TeethSize = "Reeeally big.";

        }

        [TestMethod]
        public void CheckingTypes()
        {
            Liger mittens = new Liger();

            // Make a collection that holds animals
            List<Animal> animals = new List<Animal>();

            animals.Add(mittens);
            animals.Add(new Cat());
            animals.Add(new Animal());

            foreach(var animal in animals)
            {
                animal.Move();
            }
        }
    }
}
