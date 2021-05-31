using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormationAspNet5.Models
{
    [Table(name:"personne")]
    public class Person
    {

        private int id;

        private string firstName;
        private string lastName;
        private string address;
        public Person()
        {
        }

        [Column("prenom")]
        public string FirstName { get => firstName; init => firstName = value; }
        [Column("nom")]
        public string LastName { get => lastName; init => lastName = value; }
        [Column("adresse")]
        public string Address { get => address; init => address = value; }
        public int Id { get => id; set => id = value; }

        public void Deconstruct(out string firstName, out string lastName, out string address)
        {
            firstName = FirstName;
            lastName = LastName;
            address = Address;
        }
    }
}
