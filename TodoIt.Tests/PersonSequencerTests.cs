using System;
using Xunit;
using TodoIt.Data;

namespace TodoIt.Tests
{
    public class PersonSequencerTests
	{
        [Fact]
        public void NextPersonIdTest()
        {
            //Arrange
            int personId = 10;
            int expected = 11;
            //Act
            personId = PersonSequencer.NextPersonId(personId);
            // Assert
            Assert.Equal(expected, personId);
        }

        [Fact]
		public void ResetTest()
		{
            //Arrange
            int personId = 10;
            int expected = 0;
            //Act
			personId = PersonSequencer.Reset();
			// Assert
			Assert.Equal(expected, personId);
		}
	}
}
