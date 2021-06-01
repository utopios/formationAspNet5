using System;
using System.Collections.Generic;

namespace BanqueRepositoryClass.Models
{
    public class Account
    {
        private int id;
        private string uniqNumber;
        private decimal amount;
        private List<Customer> customers;
        private List<Operation> operations;
        public Account()
        {
            Customers = new List<Customer>();
        }

        public int Id { get => id; set => id = value; }
        public string UniqNumber { get => uniqNumber; set => uniqNumber = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public List<Customer> Customers { get => customers; set => customers = value; }
        public List<Operation> Operations { get => operations; set => operations = value; }
    }
}
