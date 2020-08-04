using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Ternaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 31;   // aka hardcoding in data
                        // Condition if true : if false
            bool isAdult = (age > 17) ? true : false;
            Console.WriteLine("Age is over 17: " + isAdult);

            int numOne = 12;
            int numTwo = (numOne == 10) ? 30 : 20;
            Console.WriteLine(numTwo);

            Console.WriteLine((numTwo == 30) ? "True" : "False");

            int valueToManipulate = 5;

            // function, Methods are function's that we define within a class... outside of a class it is jsut a function
            int DoubleValue(int num)
            {
                return num * 2;
            }

            int TripleValue(int num)
            {
                return num * 3;
            }

            int banana = DoubleValue(127);
            int orange = DoubleValue(7); 
            int pineapple = DoubleValue(17); 
            int apple = DoubleValue(1);

            int dataToManipulate = 5;
            Console.WriteLine(dataToManipulate);

            int doubledValue = DoubleValue(dataToManipulate);
            Console.WriteLine(doubledValue);

            string userInput = Console.ReadLine();
            int manipulatedData = (userInput == "double") ? DoubleValue(dataToManipulate) : TripleValue(dataToManipulate);

            Console.WriteLine(manipulatedData);

            Console.ReadLine();
        }
    }
}
