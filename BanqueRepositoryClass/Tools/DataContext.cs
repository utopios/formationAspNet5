using System;
using BanqueRepositoryClass.Models;
using Microsoft.EntityFrameworkCore;

namespace BanqueRepositoryClass.Tools
{
    public class DataContext : DbContext
    {
        private string connectionString = "server=localhost;database=formationAspNet;user=root;passowrd=";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
