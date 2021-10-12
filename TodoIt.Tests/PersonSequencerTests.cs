using System;
using Xunit;
using TodoIt.Data;

namespace TodoIt.Tests
{
    public class PersonSequencerTests
	{
		[Fact]
		public void ResetTest()
		{
			//Arrange
			int expected = 0;

			//Act
			int resetPersonId = PersonSequencer.Reset();

			// Assert
			Assert.Equal(expected, resetPersonId);
		}
		[Fact]
		public void PersonIdTest()
		{
			//Arrange
			int expected = 0;

			//Act
			int personIdReset = PersonSequencer.Reset();

			// Assert
			Assert.Equal(expected, personIdReset);
		}
	}
}
