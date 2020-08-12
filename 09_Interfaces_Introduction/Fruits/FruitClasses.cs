using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Introduction.Fruits
{
    public class Banana : IFruit
    {
        // WET coding - We Enjoy Typing
        // DRY coding - Don't Repeat Yourself
        // Below is WET coding 

        public Banana() { }
        public Banana(bool isPeeled)
        {
            Peeled = isPeeled;
        }

        public string Name 
        { 
            get { return "Banana"; } 
        }
        public bool Peeled { get; private set; }
        // we made private so it can only be changed in this class
        public string Peel()
        {
            Peeled = true;
            return "You peeled the banana.";
        }
    }
    
    
    public class Orange : IFruit
    {
        public Orange() { }
        public Orange(bool isPeeled)
        {
            Peeled = isPeeled;
        }

        public string Name
        {
            get { return "Orange";  }
        }
        public bool Peeled { get; private set; }
        public string Peel()
        {
            Peeled = true;
            return "You peel the orange.";
        }
        public string Squeeze()
        {
            return "You squeeze the orange and juice comes out.";
        }
    }

    public class Grape : IFruit
    {
        public string Name
        {
            get { return "Grape"; } 
        }
        public bool Peeled { get; } = false; // initial value // assign default value inline // can change later if wanted to
        public string Peel()
        {
            return "Who peels grapes?\n" +
                "Connor says \"Surgeons do!\"\n" + // back slashes create new quotes without closing out string
                "Drew says \"Or serial killers do!\"";
        }
    }
}
