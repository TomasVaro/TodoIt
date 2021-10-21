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
            PersonSequencer.Reset();
            int expected = 1;
            //Act
            int personId = PersonSequencer.NextPersonId();
            //Assert
            Assert.Equal(expected, personId);
        }

        [Fact]
		public void ResetTest()
		{
            //Arrange
            int expected = 0;
            //Act
			int personId = PersonSequencer.Reset();
			//Assert
			Assert.Equal(expected, personId);
		}
	}
}
