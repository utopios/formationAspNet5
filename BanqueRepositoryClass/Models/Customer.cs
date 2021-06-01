using System;
using System.Collections.Generic;

namespace BanqueRepositoryClass.Models
{
    public class Customer
    {
        private int id;
        private string firstName;
        private string lastName;
        private string phone;

        private List<Account> accounts;
        public Customer()
        {
            Accounts = new List<Account>();
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public List<Account> Accounts { get => accounts; set => accounts = value; }
    }
}
