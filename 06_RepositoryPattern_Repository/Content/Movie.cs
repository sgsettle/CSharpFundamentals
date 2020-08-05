using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository.Content
{
    public class Movie : StreamingContent
    {
        // Constructors
        public Movie() : base() // Don't need to do this for empty constructor because it will implicitly call base()
            // base() is referencing the base class StreamingContent and referencing the StreamingContent constructor in StreamingContent class
        {
        }
        public Movie(string title, string description, MaturityRating maturityRating, double starRating, int releaseYear, GenreType genre, double runTime) : base(title, description, maturityRating, starRating, releaseYear, genre)
            //pulling in properties from overloaded constructor in StreamingContent class to be able to use in this class without having to double the code (putting same properties in both StreamingContent and Movie classes)
            // base(...) saying "I want to utilize the code in the constructor that is already written"
        {
            RunTime = runTime;
        }

        // Properties
        // Minutes for runtime
        public double RunTime { get; set; }
        
    }
}
