using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BanqueRepositoryClass.Models
{
    [Table(name:"operation")]
    public class Operation
    {
        private int id;
        private decimal amount;
        public Operation()
        {
        }

        public int Id { get => id; set => id = value; }
        public decimal Amount { get => amount; set => amount = value; }

        public Account Account { get; set; }
    }
}
