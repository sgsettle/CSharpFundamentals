using System;
using System.Collections.Generic;
using _08_StreamingContent_ConsoleUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_StreamingContent_UITests
{
    [TestClass]
    public class ProgramUITests
    {
        [TestMethod]
        public void GetList_OutputShouldContainStreamingContent()
        {
            // Arrange
            // Get the commands we want to run 
            // Initialize our Console and UI
            var commandList = new List<string>() { "1", "6" };
            // picked commands we want to use
            var console = new MockConsole(commandList);
            // built out console
            var program = new ProgramUI(console);
            // built ProgramUI

            // Act
            // Run the application
            program.Start();
            Console.WriteLine(console.Output);

            // Assert
            // Check for specified content in Output
            Assert.IsTrue(console.Output.Contains("Toy Story"));
        }

        // Comment for self to know what steps to take to verify adding to list
        // 3, "Title", "Description", maturity 1-9, stars 1/5, year
        [TestMethod]
        public void AddToList_ShouldFindByTitle()
        {
            // Arrange
            var description = "Some Custom Description"; // created description variable to be able to use multiple times without typing a description every time
            //                              List of commands to do
            var commandList = new string[] { "3", "Title", description, "8", "5", "2020", "3", "2", "Title", "6" };
            var console = new MockConsole(commandList);
            var ui = new ProgramUI(console);

            // Act
            ui.Start();
            Console.WriteLine(console.Output);

            // Assert
            Assert.IsTrue(console.Output.Contains(description));
        }
    }
}
