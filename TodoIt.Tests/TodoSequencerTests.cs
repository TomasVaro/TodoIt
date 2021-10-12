using System;
using Xunit;
using TodoIt.Data;

namespace TodoIt.Tests
{
    public class TodoSequencerTests
	{
		[Fact]
		public void ResetTest()
		{
			//Arrange
			int expected = 0;
			//Act
			int resetPersonId = TodoSequencer.ResetPersonId();
			// Assert
			Assert.Equal(expected, resetPersonId);
		}
	}
}
