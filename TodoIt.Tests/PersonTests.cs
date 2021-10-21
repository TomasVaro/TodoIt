using System;
using Xunit;
using TodoIt.Model;

namespace TodoIt.Tests
{
    public class PersonTests
    {
        [Fact]
        public void ConstructorTest()
		{           
			//Arrange
			string firstName = "Adam";
			string lastName = "Dubrovski";
			int personId = 7;
			//Act
			Person person = new Person(personId, firstName, lastName);
			//Assert
			Assert.NotNull(person);
			Assert.Equal(firstName, person.FirstName);
			Assert.Equal(lastName, person.LastName);
		}

		[Theory]
		[InlineData(0)]
		[InlineData(5)]
		[InlineData(-3)]
		[InlineData(55555555)]
		public void PersonIdCheck(int personId)
		{
			//Arrange
			string firstName = "Celine";
			string lastName = "Dione";
			//Act
			Person person = new Person(personId, firstName, lastName);
			//Assert
			Assert.NotNull(person);
			Assert.Equal(person.PersonId, personId);
		}

		[Theory]
		[InlineData(null)]
		[InlineData("")]
		public void FirstNameInputExceptionCheck(string firstName)
		{
			//Arrange
			string lastName = "Svensson";
			int personId = 6;
			//Act
			ArgumentException result = Assert.Throws<ArgumentException>(
				() => new Person(personId, firstName, lastName));
			//Assert
			Assert.Equal("firstName needs to be a valid name.", result.Message);
		}

		[Theory]
		[InlineData("Kåre")]
		[InlineData("K@lle")]
		[InlineData("Kall€")]
		[InlineData("Linnéa")]
		public void FirstNameInputCheck(string firstName)
        {
			//Arrange
			int personId = 5;
			string lastName = "Nilsson";
			//Act
			Person person = new Person(personId, firstName, lastName);
			string actualFirstName = person.FirstName;
			//Assert
			Assert.Equal(firstName, actualFirstName);
        }

		[Theory]
		[InlineData(null)]
		[InlineData("")]
		public void LastNameInputExceptionCheck(string lastName)
		{
			//Arrange
			string firstName = "Peter";
			int personId = 6;
			//Act
			ArgumentException actual = Assert.Throws<ArgumentException>(
				() => new Person(personId, firstName, lastName));
			//Assert
			Assert.Equal("lastName needs to be a valid name.", actual.Message);
		}

		[Theory]
		[InlineData("Söder")]
		[InlineData("Söd€r")]
		[InlineData("K@rlsson")]
		[InlineData("Bidén")]
		public void LastNameInputCheck(string lastName)
		{
			//Arrange
			int personId = 5;
			string firstName = "Bengt";
			//Act
			Person person = new Person(personId, firstName, lastName);
			string actualLastName = person.LastName;
			//Assert
			Assert.Equal(lastName, actualLastName);
		}
	}
}
