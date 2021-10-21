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
			People people = new People();
			people.CreateNewPerson("Brad", "Pitt");
			people.CreateNewPerson("Bob", "Marley");
			int expected = 2;
			//Act
			int actual = people.Size();
			//Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void FindAllTest()
		{
			//Arrange
			People people = new People();
			people.CreateNewPerson("Brad", "Pitt");
			people.CreateNewPerson("Bob", "Marley");
			int expectedSize = people.Person.Length;
			//Act
			Person[] actual = people.FindAll();
			int actualSize = actual.Length;
			//Assert
			Assert.Equal(expectedSize, actualSize);
		}

		[Fact]
		public void FindByIdTest()
		{
			//Arrange
			People people = new People();
			people.CreateNewPerson("Bob", "Marley");
			Person expectedPerson = people.CreateNewPerson("Brad", "Pitt");
			int expectedId = expectedPerson.PersonId;
			//Act
			Person actualPerson = people.FindById(expectedId);
			//Assert
			Assert.Equal(expectedPerson, actualPerson);
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
			//Assert
			Assert.Equal(expectedId, actualId);
			Assert.Equal(expectedFirsName, actualFirsName);
			Assert.Equal(expectedLastName, actualLastName);
		}

		[Fact]
        public void ClearTest()
        {
            //Arrange
			People people = new People();
			people.CreateNewPerson("Brad", "Pitt");
			people.CreateNewPerson("Bob", "Marley");
            //Act
            people.Clear();
			//Assert
			Assert.Empty(people.Person);
        }

		[Fact]
		public void RemovePersonFromArrayTest()
		{
			//Arrange
			People people = new People();
			people.Clear();
			PersonSequencer.Reset();
			people.CreateNewPerson("Brad", "Pitt");
			people.CreateNewPerson("Bob", "Marley");
			int expectedLength =  people.Person.Length - 1;
			//Act
			Person person = new Person(1, "Brad", "Pitt");
			people.RemovePersonFromArray(person);
			int actualLength = people.Person.Length;
			//Assert
			Assert.Equal(expectedLength, actualLength);
		}
	}
}
