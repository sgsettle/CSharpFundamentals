using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public class StreamingContentRepository //made this class public so we can reference it later
    {
        //Fields private
        //properties public

        //Field
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        //private makes this editible only in THIS class vs making it public and it can then be reassigned later on
        // backing field or "hidden field"
        // everytime you make a repository in a console app, you will ALWAYS need to have a private line above to create new list 

        // CRUD
        // CREATE
        public void AddContentToDirectory(StreamingContent content)
        {
            _contentDirectory.Add(content);
        }

        // READ
        // Get All StreamingContent
        public List<StreamingContent> GetDirectory()
        {
            return _contentDirectory;
        }

        // Get One StreamingContent by Title
        // StreamingContent is a class so we're returning an instance of that class
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent item in _contentDirectory)
            {
                if (item.Title.ToLower() == title.ToLower())
                {
                    return item;
                }
            }

            return null;
        }

        // UPDATE
        //used a bool to get confirmation (true, false) on if it updated
        public bool UpdateExistingContent(StreamingContent updatedContent, string originalTitle)
        {
            StreamingContent content = GetContentByTitle(originalTitle);
                if (content != null)
                {
                    int itemIndex = _contentDirectory.IndexOf(content);
                    _contentDirectory[itemIndex] = updatedContent;
                    return true;
                }

            return false;
            // Example of what below method could look like 
            // A way to not have your code break if your return is null

            // Find the target content by originalTitle
            foreach (StreamingContent item in _contentDirectory)
                // foreach find the item then go into the for loop
            {
                // Another example: 
                // if (item.Title.Contains(originalTitle))
                // This way would grab whatever comes first
                // If you're wanting to grab Toy Story but Toy Story 2 comes first, it will grab Toy Story 2 

                if(item.Title.ToLower() == originalTitle.ToLower())
                {
                    // Update the target content with updatedContent properties/values
                    // Need to assign each value to property to update
                    // This way will update everything manually
                    /* item.Title = updatedContent.Title;
                    item.Description = updatedContent.Description;
                    item.Genre = updatedContent.Genre;
                    item.MaturityRating = updatedContent.MaturityRating;
                    item.ReleaseYear = updatedContent.ReleaseYear;
                    item.StarRating = updatedContent.StarRating; */

                    // Another way:
                    // Find the index that item is at 
                    // List always starts at 0 so indexs go 0-...(however many numbers of indexs there are)
                    // will tell use what number this item is located so we know what to update
                    // Find the spot I'm supposed to be going
                    int itemIndex = _contentDirectory.IndexOf(item);
                    // slot in updatedContent into that index on the List
                    // Go to the number to update the content
                    _contentDirectory[itemIndex] = updatedContent;
                    // saying go to this list and go ahead and change this value to updated
                    

                    // return bool value true since we set method to a bool to get confirmation that it updated
                    // return will leave method
                    // break will leave a loop
                    return true;
                }
                // cannot return false inside of loop because it will check if first value matches and if not will close the method
            }
            return false;
            // return false outside of foreach loop since once code is done or nothing matches input (if no title exists etc.) it will return false

        }

        // DELETE
        // used a bool to get confirmation (true, false) on if it deleted
        public bool DeleteExistingContent(StreamingContent content)
        {
            return _contentDirectory.Remove(content);
            
            // Another (longer) way to write the return:
            // bool removed = _contentDirectory.Remove(content);
            // return removed;
        }

        // Delete Content by Title (method)
        // Give a title (take in) parameter
        // Find the content by its title
        // If I find that content, delete
        // Return a true/ false whether it worked
        public bool DeleteContentByTitle(string title)
        {
            StreamingContent targetContent = GetContentByTitle(title);
            return DeleteExistingContent(targetContent);
            // Calling DeleteExistingContent so that way any changes made to DeleteExistingContent is also applied to this method so you don't need to refactor every method
            // Best practice to utilize methods within methods
            // Making methods as small as possible to make Helper Methods and you can call them as many times as you want
            // Will not break if return is null
        }

        // scope - things can go in but cannot come out. Variable names only exist in this local scope. If same variable name is used outside of this class, it doesn't matter (content). 
        // Create, Read, Update, and Delete are all separate methods in this class so you can use same variable name and it won't overlap
    }
}
