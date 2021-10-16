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
			//Arrange
			int expectedSize = 0;
			//Act
			TodoItems todo = new TodoItems();
			todo.Clear();
			int actualSize = todo.Size();
			//Assert
			Assert.Equal(expectedSize, actualSize);
		}

		[Fact]
		public void FindByDoneStatusTest()
		{
			//Arrange
			bool doneStatus = false;
			TodoItems todo = new TodoItems();
			Todo[] findByDoneStatus = todo.FindByDoneStatus(doneStatus);
			int expectedSize = findByDoneStatus.Length;
			//Act
			int actualSize = 0;
			int actualSizeDone = 0;
			int actualSizeNotDone = 0;
			for (int i = 0; i < findByDoneStatus.Length; i++)
            {
                if (findByDoneStatus[i].Done == doneStatus)
                {
					actualSizeDone++;
                }
                else
                {
					actualSizeNotDone++;
				}
            }
            if (actualSizeDone == expectedSize)
            {
				actualSize = actualSizeDone;
			}
			else if(actualSizeNotDone == expectedSize)
            {
				actualSize = actualSizeNotDone;
			}
			// Assert
			Assert.Equal(expectedSize, actualSize);
		}

		[Fact]
		public void FindByAssigneePersonIdTest()
		{
			//Arrange
			int personId = 0;
			TodoItems todo = new TodoItems();
			Todo[] findByPersonId = todo.FindByAssignee(personId);
			int expectedSize = findByPersonId.Length;
			//Act
			int actualSize = 0;
			for (int i = 0; i < findByPersonId.Length; i++)
			{
				if (findByPersonId[i].Assignee.PersonId == personId)
				{
					actualSize++;
				}
			}
			//Assert
			Assert.Equal(expectedSize, actualSize);
		}

		[Fact]
		public void FindByAssigneePersonTest()
		{
			//Arrange
			int personId = PersonSequencer.NextPersonId() + 1;
			Person assignee = new Person(personId, "Brad", "Pitt");
			TodoItems todo = new TodoItems();
			Todo[] findByAssignee = todo.FindByAssignee(assignee);
			int expectedSize = 0;
			for (int i = 0; i < findByAssignee.Length; i++)
			{
				if (findByAssignee[i].Assignee == assignee)
				{
					expectedSize++;
				}
			}
			//Act
			int actualSize = findByAssignee.Length;
			//Assert
			Assert.Equal(expectedSize, actualSize);
		}

		[Fact]
		public void FindUnassignedTodoItemsTest()
		{
			//Arrange
			TodoItems todo = new TodoItems();
			Todo[] findUnassignedTodoItems = todo.FindUnassignedTodoItems();
			int expectedSize = 0;
			for (int i = 0; i < findUnassignedTodoItems.Length; i++)
			{
				if (findUnassignedTodoItems[i].Assignee.Equals(null))
				{
					expectedSize++;
				}
			}
			//Act
			int actualSize = findUnassignedTodoItems.Length;
			//Assert
			Assert.Equal(expectedSize, actualSize);
		}

		[Fact]
		public void RemoveTodoItemFromArrayTest()
		{
			//arrange
			TodoItems todoItems = new TodoItems();
			todoItems.Clear();
			TodoSequencer.ResetTodoId();
			todoItems.CreateNewTodo("Fixa tvätten");
			todoItems.CreateNewTodo("Gå och handla");
			int expectedLength = todoItems.Todo.Length - 1;
			//act
			Todo todo = new Todo(2, "Gå och handla");
			todoItems.RemoveTodoItemFromArray(todo);
			int actualLength = todoItems.Todo.Length;
			// assert
			Assert.Equal(expectedLength, actualLength);
		}
	}
}
