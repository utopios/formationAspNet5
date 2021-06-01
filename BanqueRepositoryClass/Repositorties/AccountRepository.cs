using System;
using System.Collections.Generic;
using BanqueRepositoryClass.Interface;
using BanqueRepositoryClass.Models;
using BanqueRepositoryClass.Tools;

namespace BanqueRepositoryClass.Repositorties
{
    public class AccountRepository : BaseRepository, IRepository<Account>
    {
        public AccountRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public bool Create(Account element)
        {
            _dataContext.Accounts.Add(element);
            _dataContext.SaveChanges();
            return element.Id > 0;

        }

        public Account Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Account> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
