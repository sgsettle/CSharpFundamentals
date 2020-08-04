using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReferencesTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings
            string declared;
            declared = "This is assignment.";

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName);

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            string compositeFullName = string.Format("{0} {1}", firstName, lastName);
            string interpolatedFullName = $"{firstName} {lastName}";
            string concatenatedFullName = firstName + " " + lastName;

            Console.WriteLine(compositeFullName);
            Console.WriteLine(interpolatedFullName);
            Console.WriteLine(concatenatedFullName);

            //Collections
            string[] stringArray = { "Hello", "World", firstName, lastName };

            string thirdItem = stringArray[2];
            Console.WriteLine("The third item is " + thirdItem);

            stringArray[0] = "Hey there";
            Console.WriteLine(stringArray[0]);

            // List
            List<string> listOfStrings = new List<string>();
            List<string> anotherReference = listOfStrings;

            listOfStrings.Add("Hello there");

            // Queue
            Queue<int> firstInFirstOut = new Queue<int>();
            firstInFirstOut.Enqueue(37);
            //Enqueue adds to end of queue
            int output = firstInFirstOut.Dequeue();
            // Dequeue removes from top of queue

            //Stack
            Stack<int> firstInLastOut = new Stack<int>();

            //Dictionary
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            Console.ReadLine();
        }
    }
}
