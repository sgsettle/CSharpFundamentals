using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 1;

            // While
            while (total != 10)
            {
                Console.WriteLine(total);
                // reassigning the value of total to equal total + 1
                // total++;     or what we have below
                // total += 1;  // sets value of total + 1
                total = total + 1;
            }

            total = 0;

            while (true)
            {
                if(total == 10)
                {
                    Console.WriteLine("Goal reached");
                    break;
                }

                total++;
            }

            Random rand = new Random();
            // Random will choose a random number for you

            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                someCount = rand.Next(0, 20);

                if (someCount == 6 || someCount == 10)
                {
                    continue;
                    // continue will disregard the rest of the loop, and will go back to the top to loop again 
                }
                Console.WriteLine(someCount);

                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }

            Console.WriteLine();
            Console.WriteLine();        //just to break up code in terminal
            Console.WriteLine();

            int studentCount = 21;

            // 1 Starting point
            // 2 While this condition is true, keep looping
            // 3 What we do after each iteration/loop
            // 4 Code we execute each iteration/loop

        // for      1       2(condition)       3
            for (int counter = 0; counter < studentCount; counter++)
            {
                // 4 code to execute
                Console.WriteLine(counter);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string[] students = { "Adam", "Justin", "Joshua", "Amanda", "Danielle", "Ingeborg", "Michael", "Marquese", "Kevin", "Casey" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to class {students[i]}!");
            }

            Console.WriteLine();
            Console.WriteLine();

            // For each
            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in the class... or are they Instructors?");
            }

            Console.WriteLine();
            Console.WriteLine();

            string oneStudent = students[2];
            foreach (char letter in oneStudent)
            {
                Console.WriteLine(letter + " is a letter in my name");
            }

            Console.WriteLine();
            Console.WriteLine();

            string myName = "Slayde Gabrielle Settle";
            foreach (char letter in myName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            // Do While Loop        -- Do something once, and then continue to do that while the condition is true
            // While Loop is a Pre-Test, meaning it will test the conditional for true/false before first iteration
            // Do While Loop is a Post-Test, it will run 1 iteration and then test the conditional for true/false before continuing to the next iteration

            int iterator = 0;
            do
            {   // We will run this code once, and then keep running it until our condition is false
                Console.WriteLine("Hello!");
                iterator++;
            }
                   //condition
            while (iterator < 5);
            // Need to have while after do or you will get an error
            // Do While loops aren't used often. While loops are used more and work better

            do
            {
                Console.WriteLine("My do while condition is false!");
            } 
            while (false);

            Console.ReadLine();
        }
    }
}
