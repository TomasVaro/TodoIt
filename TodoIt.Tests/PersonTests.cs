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

			//Act
			Person person = null;
			person = new Person(firstName, lastName);

			// Assert
			Assert.NotNull(person);
			//Assert.Equal(person.FirstName, firstName);
			//Assert.Equal(person.LastName, lastName);
		}

		[Theory]
		[InlineData(null)]
		[InlineData("")]
		public void FirstNameInputCheck(string firstName)
		{
			//Arrange
			string lastName = "Svensson";

			//Act
			ArgumentException result = Assert.Throws<ArgumentException>(
				() => new Person(firstName, lastName));

			// Assert
			Assert.Equal("firstName needs to be a valid name.", result.Message);
		}

		[Theory]
		[InlineData(null)]
		[InlineData("")]
		public void LastNameInputCheck(string lastName)
		{
			//Arrange
			string firstName = "Peter";

			//Act
			ArgumentException result = Assert.Throws<ArgumentException>(
				() => new Person(firstName, lastName));

			// Assert
			Assert.Equal("lastName needs to be a valid name.", result.Message);
		}
	}
}
