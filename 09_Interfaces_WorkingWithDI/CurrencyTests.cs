using System;
using _09_Interfaces_WorkingWithDI.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces_WorkingWithDI
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void PennyTest()
        {
            ICurrency penny = new Penny();
            // creating an instance of ICurrency since Penny is implementing ICurrency
            // also making it an ICurrency instance so we can jump around between classes we created (Penny, Dime, Dollar)

            Assert.AreEqual("Penny", penny.Name);
            Assert.AreEqual(0.01m, penny.Value);
        }

        [TestMethod]
        public void DimeTest()
        {
            ICurrency dime = new Dime();

            Assert.AreEqual("Dime", dime.Name);
            Assert.AreEqual(0.1m, dime.Value);
        }

        [TestMethod]
        public void DollarTest()
        {
            ICurrency dollar = new Dollar();

            Assert.AreEqual("Dollar", dollar.Name);
            Assert.AreEqual(1m, dollar.Value);
        }

        [DataTestMethod]
        [DataRow(3.50)]
        [DataRow(9000.01)]
        [DataRow(13.37)]
        [DataRow(19)]
        public void EPaymentTests(double value)
        {
            // converting because DataRow does not take in decimals directly, so had to set it to a double then convert to decimal
            var convertedValue = Convert.ToDecimal(value);
            var ePayment = new ElectronicPayment(convertedValue);
            // using var to make line shorter

            Assert.AreEqual(convertedValue, ePayment.Value);
            Assert.AreEqual("Electronic Payment", ePayment.Name);
        }
    }
}
