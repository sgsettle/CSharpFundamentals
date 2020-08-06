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
        // make it read only so we don't break it
        // made this a field so we're not creating a new repository every time
        private readonly StreamingContentRepository _streamingRepo = new StreamingContentRepository();
        // we store Fields as _whateverName to call later

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
                    DisplayContentByTitle();
                    break;
                case "3":
                    // add new content
                    CreateNewContent();
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
                    Console.WriteLine("Invalid input.");
                    return;
                    // return is a way of getting out of a method entirely with void
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
        private void DisplayContentByTitle()
        {
            // Prompt the user to give us a title
            Console.WriteLine("Enter a title:");

            // Get and store the users input
            string title = Console.ReadLine();

            // Find the matching content in the repository
            StreamingContent searchResult = _streamingRepo.GetContentByTitle(title);
            // not doing a for each since we already did it in StreamingContentRepository, so we call the method from the repository since we already did the work
            // left side is creating nwe StreamingContent variable
            // right side is calling our _streamingRepo field at the top, then .GetContentByTitle method and passing in whatever title user has inputted

            // Display the content to the console
            if (searchResult != null)
            {
                DisplayContent(searchResult);
                // DisplayContent comes from method above since we already wrote out the syntax to display results and don't need to write it out again
                // we input searchResult as an argument to display what user is searching for
            }

            // If there's no content found, go ahead and say so
            else
            {
                Console.WriteLine("Invalid title. Could not find any results.");
            }

        }

        // Add New Content
        private void CreateNewContent()
        {
            // need to build a StreamingContent object first 
            // we can either new up a blank StreamingContent object and access properties directly (the way Josh would've done it)
            // StreamingContent newContent = new StreamingContent();
            // newContent.Title = "";
            // or gather all data then use overloaded constructor like below

            // Gather values for all properties for the StreamingContent object
            // Title
            Console.Write("Enter a Title: ");
            // Console.Write with a ReadLine will let user input on the same line as WriteLine (Title: "user input")
            string title = Console.ReadLine();

            // Description
            Console.Write("Enter a Description: ");
            string description = Console.ReadLine();

            // MaturityRating
            // calling helper method made below
            MaturityRating maturityRating = GetMaturityRating();

            // StarRating
            Console.Write("Enter the Star Rating (1-5): ");
            double starRating = double.Parse(Console.ReadLine());
            // parse method is a little fragile that if user typed something that wasn't a double it will not parse correctly
            // maybe refactor later so it won't break when not given a number

            // Release Year
            Console.Write("Enter the Release Year: ");
            int releaseYear = int.Parse(Console.ReadLine());

            // Genre 
            GenreType genre = GetGenreType();

            // Construct a StreamingContent object given the above values
            StreamingContent newContent = new StreamingContent(title, description, maturityRating, starRating, releaseYear, genre);

            // Add the StreamingContent object to the repository ("Save" the content)
            _streamingRepo.AddContentToDirectory(newContent);
        }

        // helper method so we can call it create new content and update content, so we have 1 large block of code and call method twice instead of 2 large blocks of code that do the same thing
        private MaturityRating GetMaturityRating()
        {
            Console.WriteLine("Select a Maturity Rating:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. TV Y \n" +
                "4. PG13\n" +
                "5. R\n" +
                "6. NC17\n" +
                "7. TV PG\n" +
                "8. TV 14\n" +
                "9. TV MA");

            // string maturityString = Console.ReadLine();
            // MaturityRating maturityRating;
            // reason we're declaring maturityRating here is if we use a switch case we can use it inside the switch and making it available outside of switch to use later on
            // left in above so I can reference what we first did when we were going to use it in create new content instead of creating a helper method
            // got rid of maturityRating = in switch case because we're just returning values 
            // can call Console.Readline as an argument instead of having a string, whatever ReadLine returns is what switch will evaluate
            // created while loop to lock user in loop if they do not choose something in the switch case (20, apple, 10, etc.), they cannot exit loop until they choose 1-9
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        return MaturityRating.G;
                    case "2":
                        return MaturityRating.PG;
                    case "3":
                        return MaturityRating.TV_Y;
                    case "4":
                        return MaturityRating.PG13;
                    case "5":
                        return MaturityRating.R;
                    case "6":
                        return MaturityRating.NC17;
                    case "7":
                        return MaturityRating.TV_PG;
                    case "8":
                        return MaturityRating.TV_14;
                    case "9":
                        return MaturityRating.TV_MA;
                }
                Console.WriteLine("Invalid selection.");
            }
        }

        // creating new method for genre type enum
        private GenreType GetGenreType()
        {
            Console.WriteLine("Select a Genre: " +
                "1. Action/Adventure\n" +
                "2. Action\n" +
                "3. Thriller\n" +
                "4. Horror\n" +
                "5. Comedy\n" +
                "6. Bromance\n" +
                "7. Mystery\n" +
                "8. SciFi");
            while (true)
            {
                // One Working Version
                //string genreString = Console.ReadLine();
                //int genreId = int.Parse(genreString); // Can pass in Console.ReadLine here as well instead of using string
                // casting takes one value and converts it to a different type
                // We're taking the int value user inputted and casted it into GenreType type
                // Since enum starts at 0, we can either take value below and -1 or we can go into enum in StreamingContent and set first (Action/Adventure) = 1 (example in enum in StreamingContent)
                //GenreType genre = (GenreType)genreId - 1;
                //return genre;

                // Second Working Version
                // Long way to do the second version
                string genreString = Console.ReadLine();
                bool parseResult = int.TryParse(genreString, out int parsedNumber);
                if (parseResult && parsedNumber >= 1 && parsedNumber < 9)
                {
                    GenreType genre = (GenreType)parsedNumber - 1;
                    return genre;
                }
                // TryParse needs a bool to return

                // Short way to do the second version
                //if (int.TryParse(Console.ReadLine(), out int genreId))
                //{
                //    return (GenreType)genreId - 1;
                //}

                //Console.WriteLine("Invalid selection. Please try again.");
            }
        }

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
