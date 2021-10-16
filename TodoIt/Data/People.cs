using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoIt.Model;

namespace TodoIt.Data
{
    public class People
    {
        private static Person[] person = new Person[0];
        public Person[] Person { get { return person; } }

        public int Size()
        {
            return person.Length;
        }
        public Person[] FindAll()
        {
            return person;
        }
        public Person FindById(int personId)
        {
            int i;
            for (i = 0; i < person.Length; i++)
            {
                if (person[i].PersonId == personId)
                {
                    break;
                }
            }
            return person[i];
        }
        public Person CreateNewPerson(string firstName, string lastName)
        {
            int personId = PersonSequencer.NextPersonId();
            Person newPerson = new Person(personId, firstName, lastName);

            Array.Resize(ref person, person.Length + 1);
            person[person.Length - 1] = newPerson;
            return newPerson;
        }
        public void Clear()
        {
            person = new Person[0];
        }
        public void RemovePersonFromArray(Person personToRemove)
        {
            for (int i = 0; i < person.Length; i++)
            {
                if (Person[i].FirstName == personToRemove.FirstName 
                    && Person[i].LastName == personToRemove.LastName
                    && Person[i].PersonId == personToRemove.PersonId)
                {
                    person = person.Where((source, index) => index != i).ToArray();
                }
            }
        }
    }
}