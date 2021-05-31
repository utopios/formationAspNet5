using System;
using Microsoft.EntityFrameworkCore;

namespace FormationAspNet5.Models
{
    public class DataContext : DbContext
    {
        private string connectionString = "server=localhost;database=formationAspNet;user=root;password=";

        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
