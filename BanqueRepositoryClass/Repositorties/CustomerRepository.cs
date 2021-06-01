using System;
using System.Collections.Generic;
using System.Linq;
using BanqueRepositoryClass.Interface;
using BanqueRepositoryClass.Models;
using BanqueRepositoryClass.Tools;

namespace BanqueRepositoryClass.Repositorties
{
    public class CustomerRepository : BaseRepository, IRepository<Customer>
    {
        public CustomerRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public bool Create(Customer element)
        {
            throw new NotImplementedException();
        }

        public Customer Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> FindAll()
        {
            return _dataContext.Customers.ToList();
        }

        public bool Update(Customer element)
        {
            throw new NotImplementedException();
        }
    }
}
