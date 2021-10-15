using System;
using Xunit;
using TodoIt.Data;
using TodoIt.Model;

namespace TodoIt.Tests
{
    public class TodoItemsTests
    {
		[Fact]
		public void SizeTest()
		{
			//Arrange
			int expected = 0;
			//Act
			TodoItems todo = new TodoItems();
			int actual = todo.Size();
			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void FindAllTest()
		{
			//Arrange
			TodoItems todoItems = new TodoItems();
			int expectedSize = todoItems.Todo.Length;
			//Act
			Todo[] actual = todoItems.FindAll();
			int actualSize = actual.Length;
			// Assert
			Assert.Equal(expectedSize, actualSize);
		}

		[Fact]
		public void FindByIdTest()
		{
			//Arrange
			TodoItems todo = new TodoItems();
			Todo expected = todo.CreateNewTodo("Köp mjölk!");
			int todoId = expected.TodoId;
			//Act
			todo = new TodoItems();
			Todo actual = todo.FindById(todoId);
			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void CreateNewTodoTest()
		{
			//Arrange
			int todoId = TodoSequencer.NextTodoId() + 1;
			Todo expectedTodo = new Todo(todoId, "Köp mer mjölk!");
			int expectedId = expectedTodo.TodoId;
			string expectedDescription = expectedTodo.Description;
			//Act
			TodoItems todo = new TodoItems();
			Todo actualTodo = todo.CreateNewTodo("Köp mer mjölk!");
			int actualId = actualTodo.TodoId;
			string actualDescription = actualTodo.Description;
			// Assert
			Assert.Equal(expectedId, actualId);
			Assert.Equal(expectedDescription, actualDescription);
		}

		[Fact]
		public void ClearTest()
		{
			//arrange
			int expectedSize = 0;
			//act
			TodoItems todo = new TodoItems();
			todo.Clear();
			int actualSize = todo.Size();
			// assert
			Assert.Equal(expectedSize, actualSize);
		}
	}
}
