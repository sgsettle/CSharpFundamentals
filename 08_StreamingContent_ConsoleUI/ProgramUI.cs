using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_ConsoleUI
{
    // public - can be used throughout the solution
    // internal - can only be accessed within the assembly/project
    // private - can only be accessed within the class
    class ProgramUI
    {
        // Field added to be able to get user out of loop in RunMenu
        // Field is a variable in the class but is not a property (doesn't use get and set)
        // Doing this so we can set everything in our switch case to True with void (instead of setting OpenMenuItem to a bool), declaring _isRunning in case 6 to false so user can exit  
        private bool _isRunning = true;
        // Create a field of StreamingContentRepository so we can use it 
        // make it red only so we don't break it
        private readonly StreamingContentRepository _streamingRepo = new StreamingContentRepository();

        // void basically just gets the method to start --> doesn't return anything just does something
        // Entry point to our UI, it starts our user interface
        // Basically writing a set of instructions --> when you want to run this code, here are the steps to take to run successfully
        public void Start()
        {
            SeedContentList();
            // Adding seed content before run menu to make sure that the first thing that's done is the data is in the list 
            RunMenu();
        }

        // This method has the task of running the menu
        // Making this private so we make sure that this method cannot run before the Start method
        // gives user "what do you want to do" and starts with these options
        // \n creates a new line
        private void RunMenu()
        {
            // currently will continue in an endles loop by setting the bool to true
            // adding a Field at the top of the class to be able to exit the loop
            // bool isRunning = true; --> leaving in notes to see what I was talking about but no longer needed since we created a Field 
            while (_isRunning)
            {
                string userInput = GetMenuSelection();
                OpenMenuItem(userInput);
            }

        }
        private string GetMenuSelection()
        {
            Console.Clear();
            // .Clear will clear the screen and prints the menu
            // concatenate strings, can hit enter inside of string and vs code will concatenate for you
            // makes it easier to read as a developer
            Console.WriteLine(
                "Welcome to the Streaming Content Management System!\n" +
                "Select Menu Item:\n" +
                "1. Show All Streaming Content\n" +
                "2. Find Streaming Content By Title\n" +
                "3. Add New Streaming Content\n" +
                "4. Update Existing Streaming Content\n" +
                "5. Remove Streaming Content\n" +
                "6. Exit");

            string userInput = Console.ReadLine();
            return userInput;
        }

        private void OpenMenuItem(string userInput)
        {
            Console.Clear();
            // putting clear here to clear the menu and display user input
            switch (userInput)
            {
                case "1":
                    // Show all streaming content
                    DisplayAllContent();

                    break;
                case "2":
                    // Find Content by title
                    break;
                case "3":
                    // add new content
                    break;
                case "4":
                    // update content
                    break;
                case "5":
                    // remove content
                    break;
                case "6":
                    // exit
                    _isRunning = false;
                    return;
                    // changed to return to escape the method without worrying about ReadKey that's outside of the switch case
                    // if break instead of return, it will get hung up on ReadKey and user will have to hit another key on exit
                default:
                    // Invalid selection
                    break;
            }
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
            //ReadKey will read any key that is pressed
            // putting these under the switch case so we don't have to write them in every case
        }

        // rule of thumb: if you don't need a method outside of the class, make it private 

        // Show All Content
        private void DisplayAllContent()
        {
            // Get content
            // Go to the repository and get the directory
            // can use methods in other assemblies/projects (StreamingContentRepository)
            // need an instance of StreamingContentRepository
            List<StreamingContent> listOfContent = _streamingRepo.GetDirectory();

            // Display content
            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);
                // calling helper method instead of console.writeline
            }
        }

        // if we're going to run our code multiple times, good idea to create helper method
        // able to continue calling this later on
        private void DisplayContent(StreamingContent content)
        {
            Console.WriteLine($"Title: {content.Title}\n" +
                $"Description: {content.Description}\n" +
                $"Genre: {content.Genre}\n" +
                $"Stars: {content.StarRating}\n" +
                $"Rating: {content.MaturityRating}\n" +
                $"Family Friendly: {(content.IsFamilyFriendly ? "Yes it is!" : "No it's not.")}\n" +
                $"Release Year: {content.ReleaseYear}\n");
        }

        // Find Content by Title


        // Add New Content

        // Update Content

        // Remove Content

        // Doing this is the UI instead of repository so repo doesn't always have data
        // seed content is typically "planted" by the program to give data to the database for use, prior to the end user adding in any content to the database
        private void SeedContentList()
        {
            StreamingContent rubber = new StreamingContent("Rubber", "Tire comes to life and kills people.", MaturityRating.R, 5.8, 2010, GenreType.Horror);
            StreamingContent toyStory = new StreamingContent("Toy Story", "Wonderful childhood memory.", MaturityRating.G, 10, 1995, GenreType.Bromance);
            StreamingContent harryPotter = new StreamingContent("Harry Potter and the Sorcerer's Stone", "Young boy finds out he's a wizard and introduced to magical world.", MaturityRating.PG, 10, 2001, GenreType.ActionAdventure);

            _streamingRepo.AddContentToDirectory(rubber);
            _streamingRepo.AddContentToDirectory(toyStory);
            _streamingRepo.AddContentToDirectory(harryPotter);
        }
    }
}
