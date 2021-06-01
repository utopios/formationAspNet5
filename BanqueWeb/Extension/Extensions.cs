using System;
using BanqueRepositoryClass.Interface;
using BanqueRepositoryClass.Models;
using BanqueRepositoryClass.Repositorties;
using BanqueRepositoryClass.Tools;
using Microsoft.Extensions.DependencyInjection;

namespace BanqueWeb.Extension
{
    public static class Extensions
    {
        public static void AddRepositoriesServices(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>();
            services.AddScoped<IRepository<Account>, AccountRepository>();
            services.AddScoped<IRepository<Operation>, OperationRepository>();
            services.AddScoped<IRepository<Customer>, CustomerRepository>();
        }
    }
}
