using System;
using Xunit;
using TodoIt.Data;

namespace TodoIt.Tests
{
    public class TodoSequencerTests
	{
		[Fact]
		public void NextPersonIdTest()
		{
			//Arrange
			int personId = 10;
			int expected = 11;
			//Act
			personId = TodoSequencer.IncrementPersonId(personId);
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
			personId = TodoSequencer.ResetPersonId();
			// Assert
			Assert.Equal(expected, personId);
		}
	}
}
