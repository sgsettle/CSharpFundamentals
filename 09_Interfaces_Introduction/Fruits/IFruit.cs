using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Introduction.Fruits
{
    public interface IFruit
    {
        // whenever we want to have a class that has a defined set of functionality we have an interface
        // we implement, not inherit
         string Name { get; }
        bool Peeled { get; }
        string Peel();
    }
}
