using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Model
{
    public class Person
    {
        private static int idCounter = 0;
        public static int IdCounter { get { return idCounter; } }

        private readonly int personId;
        public int PersonId { get { return personId; } }

        private string firstName;
        public string FirstName { 
            get { return firstName; }
            set 
            {
                if (value == string.Empty  || value == null)
                {
                    throw new ArgumentException("firstName needs to be a valid name.");
                }
                firstName = value;
            }
        }

        private string lastName;
        public string LastName { 
            get { return lastName; }
            set
            {
                if (value == string.Empty || value == null)
                {
                    throw new ArgumentException("lastName needs to be a valid name.");
                }
                lastName = value;
            }
        }

        public Person(string firstName, string lastName)
        {
            personId = ++idCounter;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
