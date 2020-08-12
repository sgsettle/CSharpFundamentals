using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkingWithDI.Currency
{
    public interface ICurrency
    {
        // Properties in an interface are properties that classes MUST have, bare minimums
        // Name - what currency is called
        // Only a get because we can't change the name of a dollar
        string Name { get; }

        // Value - how much the currency is worth
        decimal Value { get; }
    }
}
