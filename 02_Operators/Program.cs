using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 22;
            int numTwo = 15;

            // Addition: + 
            int sum = numOne + numTwo;
            Console.WriteLine(sum);

            // Subtraction: -
            int difference = numOne - numTwo;
            Console.WriteLine(difference);

            // Multiplication: *
            int multiply = numOne * numTwo;
            Console.WriteLine(multiply);

            // Division: /
            int divide = numOne / numTwo;
            Console.WriteLine(divide);

            // Remainder: %
            int remain = numOne % numTwo;
            Console.WriteLine(remain);

            DateTimeOffset timeZoneDate = DateTimeOffset.Now;
            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1978, 1, 1);

            TimeSpan banana = now - someDay;
            Console.WriteLine(banana);

            // Comparison Operators
            Console.WriteLine("Enter your age:");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);

            bool equals = age == 42;
            Console.WriteLine("User is 42: " + equals);

            Console.WriteLine("Enter you name:");
            string name = Console.ReadLine();
            bool userIsAdam = name == "Adam";
            Console.WriteLine("User is Adam: " + userIsAdam);

            bool userIsNotAdam = name != "Adam";
            Console.WriteLine("User is not Adam: " + userIsNotAdam);

            List<string> firstList = new List<string>();
            firstList.Add(name);

            List<string> secondList = new List<string>();
            secondList.Add(name);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine($"The lists are the same {listsAreEqual}");



            Console.ReadLine();
        }
    }
}
