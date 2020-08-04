using System;
using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldGetCorrectString()
        {
            // Because we don't do everything in one class, these using statements are like adding contacts to your phone. Once you have the contact you can use their info to do whatever you are trying to do on that page
            // set up new streaming content
            // Arrange
            StreamingContent content = new StreamingContent();

            //set the title
            // Act
            content.Title = "Toy Story";

            //variables what you are expecting
            string expected = "Toy Story";
            string actual = content.Title;

            //assert variables
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(MaturityRating.G, true)]
        [DataRow(MaturityRating.R, false)]
        public void SetMaturityRating_ShouldGetCorrectIsFamilyFriendly(MaturityRating rating, bool expectedFamilyFriendly)
        {
            // Arrange
            StreamingContent content = new StreamingContent();

            // Act
            content.MaturityRating = rating;

            // Assert
            Assert.AreEqual(expectedFamilyFriendly, content.IsFamilyFriendly);
        }
    }
}
