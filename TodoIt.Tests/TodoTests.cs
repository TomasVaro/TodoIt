using System;
using Xunit;
using TodoIt.Model;

namespace TodoIt.Tests
{
    public class TodoTests
    {
		[Fact]
		public void ConstructorTest()
		{
			//Arrange
			int todoId = 10;
			string description = "Köp mjölk";
			//Act
			Todo todo = new Todo(todoId, description);
			//Assert
			Assert.NotNull(todo);
			Assert.Equal(todo.TodoId, todoId);
			Assert.Equal(todo.Description, description);
		}

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(-3)]
        [InlineData(55555555)]
        public void TodoIdCheck(int todoId)
        {
            //Arrange
            string description = "Köp mölk!";
            //Act
            Todo todo = new Todo(todoId, description);
            //Assert
            Assert.NotNull(todo);
            Assert.Equal(todo.TodoId, todoId);
        }

        [Theory]
		[InlineData("Köp mjölk!")]
		[InlineData(null)]
		[InlineData("")]
		[InlineData(" ")]
		public void DescriptionCheck(string description)
		{
			//Arrange
			int todoId = 10;
			//Act
			Todo todo = new Todo(todoId, description);
			//Assert
			Assert.NotNull(todo);
			Assert.Equal(description, todo.Description);
		}
	}
}
