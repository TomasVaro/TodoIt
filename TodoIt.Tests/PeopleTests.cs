using System;
using Xunit;
using TodoIt.Data;
using TodoIt.Model;

namespace TodoIt.Tests
{
    public class PeopleTests
    {
		[Fact]
		public void SizeTest()
		{
			//Arrange
			int expected = 0;
			//Act
			People people = new People();
			int actual = people.Size();
			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void FindAllTest()
		{
			//Arrange
			People people = new People();
			int expectedSize = people.Person.Length;
			//Act
			Person[] actual = people.FindAll();
			int actualSize = actual.Length;
			// Assert
			Assert.Equal(expectedSize, actualSize);
		}

		[Fact]
		public void FindByIdTest()
		{
			//Arrange
			People people = new People();
			Person expected = people.CreateNewPerson("Brad", "Pitt");
			int personId = expected.PersonId;
			//Act
			people = new People();
			Person actual = people.FindById(personId);
			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void CreateNewPersonTest()
		{
			//Arrange
			int personId = PersonSequencer.NextPersonId() + 1;
			Person expectedPerson = new Person(personId, "Brad", "Pitt");
			int expectedId = expectedPerson.PersonId;
			string expectedFirsName = expectedPerson.FirstName;
			string expectedLastName = expectedPerson.LastName;
			//Act
			People people = new People();
			Person actualPerson = people.CreateNewPerson("Brad", "Pitt");
			int actualId = actualPerson.PersonId;
			string actualFirsName = actualPerson.FirstName;
			string actualLastName = actualPerson.LastName;
			// Assert
			Assert.Equal(expectedId, actualId);
			Assert.Equal(expectedFirsName, actualFirsName);
			Assert.Equal(expectedLastName, actualLastName);
		}

		[Fact]
        public void ClearTest()
        {
            //arrange
            int expectedSize = 0;
            //act
            People people = new People();
            people.Clear();
            int actualSize = people.Size();
            // assert
            Assert.Equal(expectedSize, actualSize);
        }
    }
}
