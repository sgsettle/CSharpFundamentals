using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    // CRUD: Create, Read, Update, Delete
    // SOLID: Single-responsibility principle, Open-closed principle, Liskov subsitution principle, Interface segregation principle, Dependency inversion principle

    // POCO: Plain Old C# Object 
    public class StreamingContent
    {
        /*
         CHALLENGE:
        Users have been complaining about their family friendly content. Some users have been reporting that when filtering for family friendly, they're getting some content with inappropriate maturity ratings. We need to fix this. Currently the maturity rating and family friendly bool are independent, we need to tie them together. If something is rated R (or another similar rating), it should never be able to have a IsFamilyFriendly of true. 

        We need you to refactor the code StreamingContent class. To help narrow down our problem, we want to replace the MaturityRating with a default set of options. Based on those options, we want our IsFamilyFriendly to return the appropriate true or false.
        */

        // Constructor (put above properties purely to be organizational)
        public StreamingContent() { }
        public StreamingContent(string title, string description, MaturityRating maturityRating, double starRating, int releaseYear, GenreType genre)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            ReleaseYear = releaseYear;
            Genre = genre;
        }

        //Properties
        public string Title { get; set; }
        public string Description { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public double StarRating { get; set; }
        public int ReleaseYear { get; set; }
        public bool IsFamilyFriendly { 
            get 
            {
                // Figure out if it's family friendly and return true or false
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TV_Y:
                        return true;
                    default:
                        return false;

                    // Another (longer) way to write code
                    /* case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TV_Y:
                        return true;
                    case MaturityRating.PG13:
                    case MaturityRating.NC17:
                    case MaturityRating.R:
                    case MaturityRating.TV_PG:
                    case MaturityRating.TV_14:
                    case MaturityRating.TV_MA:
                        return false;
                    default:
                        return false; */
                }
            }
        }
        public GenreType Genre { get; set; }
        
    }

    // Enums allow us to set predefined list of values (constants) in code
    // Cannot change values without changing enum itself
    // Defining values of genres to choose from instead of letting users set new data
    public enum GenreType
    {
        // Action/Adventure = 1, example made from note in ProgramUI
        ActionAdventure,
        Action,
        Thriller,
        Horror,
        Comedy,
        Bromance,
        Mystery,
        SciFi
    }

    public enum MaturityRating
    {
        G,
        PG,
        PG13,
        NC17,
        R,
        TV_Y,
        TV_PG,
        TV_14,
        TV_MA
    }
}
