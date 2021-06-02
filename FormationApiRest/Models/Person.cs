using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace FormationApiRest.Models
{
    public class Person
    {
        string firstName;
        string lastName;
        int id;
        public Person()
        {
        }

        public string FirstName { get => firstName; set { if (value.Length > 3) firstName = value; else throw new FormatException("Merci de saisir un prénom min 3 caractère"); } }
        public string LastName { get => lastName; set => lastName = value; }
        public int Id { get => id; set => id = value; }

        public static Task<List<Person>> GetPersonAsync()
        {
            Task<List<Person>> TaskPerson = Task.Run(() =>
            {
                //Logic metier
                return new List<Person>() {
                    new Person { FirstName = "toto", LastName = "tata" }, new Person { FirstName = "titi", LastName = "minet" }
                };
            });
            
            return TaskPerson;
        }

        public static Task<Person> GetPersonAsyncById(int id)
        {
            return Task.Run(() =>
            {
                //Logic metier
                return new Person { FirstName = "ihab", LastName = "abadi", Id = id };
            });
        }

        public static Task<Person> PostPersonAsync(PersonRecord person)
        {
            return Task.Run(() =>
            {
                return new Person { Id = new Random().Next(100), FirstName = person.FirstName, LastName = person.LastName };
            });
        }
        public static Task<bool> DeletePersonAsync(int id)
        {
            return Task.Run(() =>
            {
                return true;
            });
        }

        public bool Update(PersonRecord person)
        {
            //Mise à jour dans la base.
            FirstName = person.FirstName;
            LastName = person.LastName;
            return true;
        }
    }

    public record PersonRecord(string FirstName, string LastName);

}
