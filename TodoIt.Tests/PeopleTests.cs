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
			int result = people.Size();
			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void FindAllTest()
		{
			//Arrange
			Person[] expected = new Person[0];
			//Act
			People people = new People();
			Person[] result = people.FindAll();
			// Assert
			Assert.Equal(expected, result);
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
			Person result = people.FindById(personId);
			// Assert
			Assert.Equal(expected, result);
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
        public void ClearTest2()
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
