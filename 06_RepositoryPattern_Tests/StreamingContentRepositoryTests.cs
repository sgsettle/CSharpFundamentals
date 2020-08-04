using System;
using System.Collections.Generic;
using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        // In all repository tests, we'll need streaming content repository
        // Best practice to have Fields at the top
        // Properties are more flexible/dynamic Fields
        private StreamingContentRepository _repo;
        private StreamingContent _content;

        // TestInitialize will make this test run before any other test
        // Makes so you don't have to write code for Arrange in every TestMethod
        [TestInitialize]
        // Create a method that arranges
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode and goes on a murderous rampage through the Californian desert.", MaturityRating.R, 5.8, 2010, GenreType.Horror);

            _repo.AddContentToDirectory(_content);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            // Arrange, Act, Assert - Triple A Paradigm

            // Arrange --> Setting up the playing field
            // Everything we have to do before we start running code we're testing
            StreamingContentRepository repo = new StreamingContentRepository();
            // creating something
            StreamingContent orange = new StreamingContent();
            // then passing it through to the method
            repo.AddContentToDirectory(orange);

            // Act --> Get or run the code we want to test
            List<StreamingContent> directory = repo.GetDirectory();

            bool directoryHasOrange = directory.Contains(orange);

            // Assert --> Using the Assert class to verify the expected outcome
            Assert.IsTrue(directoryHasOrange);
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            // Arrange
            // This will be replaced with [TestInitialize] method

            // Act
            bool removeResult = _repo.DeleteExistingContent(_content);

            // Assert
            Assert.IsTrue(removeResult);
        }

        [DataTestMethod]
        [DataRow("rubber", true)]
        [DataRow("toy story", false)]
        public void DeleteTitle_ShouldReturnCorrectBool(string title, bool expectedResult)
        {
            // Arrange [TestInitialize]

            // Act
            bool actualResult = _repo.DeleteContentByTitle(title);

            // Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
