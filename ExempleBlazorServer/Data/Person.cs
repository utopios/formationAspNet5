using System;
using System.Collections.Generic;

namespace ExempleBlazorServer.Data
{
    public class Person
    {
        public Person()
        {
        }

        private string firstName;

        private string lastName;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }


        public static List<Person> GetPersons()
        {
            return new List<Person>() { new Person { FirstName = "toto", LastName = "tata" }, new Person { FirstName = "titi", LastName = "minet" }, new Person { FirstName = "toto", LastName = "tata" } };
        }
    }
}
