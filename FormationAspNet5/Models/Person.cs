using System;
namespace FormationAspNet5.Models
{
    public class Person
    {

        private string firstName;
        private string lastName;
        private string address;
        public Person()
        {
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }

        public void Deconstruct(out string firstName, out string lastName, out string address)
        {
            firstName = FirstName;
            lastName = LastName;
            address = Address;
        }
    }
}
