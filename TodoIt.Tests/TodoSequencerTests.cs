using System;
using Xunit;
using TodoIt.Data;

namespace TodoIt.Tests
{
    public class TodoSequencerTests
	{
		[Fact]
		public void NextTodoIdTest()
		{
			//Arrange
			TodoSequencer.ResetTodoId();
			int expected = 1;
			//Act
			int todoId = TodoSequencer.NextTodoId();
			// Assert
			Assert.Equal(expected, todoId);
		}

		[Fact]
		public void ResetTest()
		{
			//Arrange
			int expected = 0;
			//Act
			int todoId = TodoSequencer.ResetTodoId();
			// Assert
			Assert.Equal(expected, todoId);
		}
	}
}
