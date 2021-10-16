using System;
using TodoIt.Model;
using TodoIt.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TodoIt
{
    class Program
    {
        private static Person[] person = new Person[0];
        public Person[] Person { get { return person; } }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}