using System;
using TodoIt.Model;
using TodoIt.Data;

namespace TodoIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string firstName = "Per";
            string lastName = "Svensson";
            Person person = new Person(firstName, lastName);
            int todoId = 1;
            string descrption = "Köp mjölk";
            Todo todo = new Todo(todoId, descrption);

            int personId = 10;
            //PersonSequencer personSequencer = new PersonSequencer();
            personId = TodoSequencer.ResetPersonId();
            
            Console.ReadKey();
        }
    }
}