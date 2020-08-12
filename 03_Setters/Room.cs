using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Setters
{
    /*        
    Create a Room class that has three properties: one each for the length, width, and height.       
    Create a method that calculates total square footage.

    We also would like to include some constants that the define a minimum and maximum length, width, and height.
    When setting the properties, make sure to compare the values to the min/max and only set them if the value is valid.

    Bonus:
    Create a method that calculates total lateral surface area.
    Only allow the properties to be set from inside the class itself.

    Throw an exception if the given value is outside the permitted range.
    Test the code like we did with the Vehicle tests. */

    class Room
    {
        // access modifiers - used for accessibility
        // modifiers - static, const, etc.
        // all const does is make sure that the value is constant
        // Constants - Unchanging variables
        private const double MaxLength = 30;
        private const double MinLength = 6;

        private const double MaxWidth = 30;
        private const double MinWidth = 6;

        private const double MaxHeight = 12;
        private const double MinHeight = 9;

        // propfull tab tab (Full Property)
        // backing field - property that is set to whatever the field is
        // length backing field 
        private double _length;
        private double _width;
        private double _height;

        // Constructor that sets length, width, and height upon construction
        public Room(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        // Length property
        public double Length
        {
            // Getter that returns the backing field value
            get { return _length; }

            // Setter, allows us to change the value of the _length backing field 
            // Includes logic to validate correct assignment
            // private set means it can only be set inside this class
            // restricting the flow so you can only create a room by using constructor 
            private set
            {
                // check to see if we meet the expected constraints
                if(value < MinLength || value > MaxLength)
                {
                    // Argument is the value given to the parameter
                    throw new ArgumentException($"The length should be between {MinLength} and {MaxLength} inclusive.");
                }

                // If we've gotten this far, that means we haven't thrown an exception
                // Go ahead and assign a value to our field
                _length = value;
            }
        }

        public double Width
        {
            get { return _width; }
            private set
            {
                if(value < MinWidth || value > MaxWidth)
                {
                    throw new ArgumentException($"The length should be between {MinWidth} and {MaxWidth} inclusive.");
                }

                _width = value;
            }
        }

        public double Height
        {
            get { return _height; }
            private set
            {
                if (value < MinHeight || value > MaxHeight)
                {
                    throw new ArgumentException($"The length should be between {MinHeight} and {MaxHeight} inclusive.");
                }

                _height = value;
            }
        }

        public double GetSquareFootage()
        {
            double squareFootage = Length * Width;
            // can also use backing field
            // double squareFootage = _length * _width;
            // better practice to use properties like we did for future use
            
            return squareFootage;
        }
    }
}
