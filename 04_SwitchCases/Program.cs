using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SwitchCases
{
    class Program
    {
        // If Else =>   // If this conditional is true or false, then run this code.
        // Switch Cases =>  // When this conditional is "Whatever we decide", then run this code.
        static void Main(string[] args)
        {
            int input = 1;

            switch (input)
            {
                case 1:
                        Console.WriteLine("Hello");
                        break;
                case 2:
                        Console.WriteLine("What are you doing?");
                        break;
                default:
                    Console.WriteLine("This is default. It will execute if no other case is evaluated as true. Defaults are not required");
                    break;
            }

            DayOfWeek today = DateTime.Today.DayOfWeek;

            switch (today)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Sorry we are closed");
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Hey, it's almost Friday");
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;  
            }

            // Challenge
            // Ask the user how they are feeling on a scale of 1-5. Capture their input and run it through a switch statement. Output a different response for each value. If they respond out of range, let them know.

            Console.WriteLine("How are you feeling today on a scale of 1-5?");
            string feeling = Console.ReadLine();
            int totalFeeling = int.Parse(feeling);

            switch (totalFeeling)
            {
                case 1:
                    Console.WriteLine("I'm sorry you're feeling that way.");
                    break;
                case 2:
                    Console.WriteLine("I hope you're day gets better.");
                    break;
                case 3:
                    Console.WriteLine("That's not too bad.");
                    break;
                case 4:
                    Console.WriteLine("I'm glad you're having a good day!");
                    break;
                case 5:
                    Console.WriteLine("Wow! That's great!");
                    break;
                default:
                    Console.WriteLine("I'm sorry. That response is out of range.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
