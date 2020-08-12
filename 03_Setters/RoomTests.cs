using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Setters
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void ConstructRoom_ShouldSetProperties()
        {
            // Since we set the setters to private, we can now input the measurements in the new Room instance
            var myRoom = new Room(8, 9, 12);

            Assert.AreEqual(8, myRoom.Length);
            Assert.AreEqual(9, myRoom.Width);
            Assert.AreEqual(12, myRoom.Height);
        }

        // Creating DataTestMethod to test the exception if the measurements are out of range
        [DataTestMethod]
        [DataRow(4, 10, 10)]
        [DataRow(31, 10, 10)]
        public void CreateInvalidLength_ShouldThrowException(double l, double w, double h)
        {
            // Arrange
            Exception thrownException = null;

            // Act
            try // try to run code
            {
                var room = new Room(l, w, h);
            }
            catch (Exception err) // if it fails, will catch the exception
            {
                thrownException = err;
            }
            finally
            {

            }

            // Assert
            // checking that our exception is not null
            Assert.IsNotNull(thrownException);
            Assert.IsInstanceOfType(thrownException, typeof(ArgumentException));
        }
    }
}
