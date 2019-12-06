using System;
using Xunit;
using Rover;

namespace RoverTest
{
    public class UnitTest1
    {
        Rovers rover = new Rovers();
        [Fact]
        public void Should_Be_Valid_For_Correct_Coordinates_And_Command()
        {
            string coordinates = "(10,5,N)";
            string command = "MMLMRMML";
            rover.SetInitialValues(coordinates, command);
            rover.ReadCommand();

            string expected = "(9, 9, W)";
            string actual = rover.GetUpdatedLocation();
            Assert.Equal(expected,actual);
        }
    }
}
