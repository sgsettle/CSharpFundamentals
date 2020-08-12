using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkingWithDI.Currency
{
    public class Transaction
    {
        // Field
        private readonly ICurrency _currency;
        // underscore (_currency) is just a naming convention
        // have dependencies and going to inject it into the class

        //                          parameter that only exists inside this local scope
        public Transaction(ICurrency currency)
        {
            // will know what kind of currency was given and what time transaction happened
            _currency = currency;
            DateOfTransaction = DateTimeOffset.Now;
        }

        // DateTimeOffset can track time zone
        public DateTimeOffset DateOfTransaction { get; }

        public decimal GetTransactionValue()
        {
            return _currency.Value;
        }

        // when called, return _currency.Name
        public string GetTransactionType() => _currency.Name;
    }
}
