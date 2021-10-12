using System;
using TodoIt.Model;

namespace TodoIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string firstName = "";
            string lastName = "Svensson";
            Person person = new Person(firstName, lastName);
            Console.ReadKey();
        }
    }
}
