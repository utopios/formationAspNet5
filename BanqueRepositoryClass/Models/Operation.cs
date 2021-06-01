using System;
namespace BanqueRepositoryClass.Models
{
    public class Operation
    {
        private int id;
        private decimal amount;
        public Operation()
        {
        }

        public int Id { get => id; set => id = value; }
        public decimal Amount { get => amount; set => amount = value; }
    }
}
