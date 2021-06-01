using System;
using System.Collections.Generic;
using System.Linq;
using BanqueRepositoryClass.Interface;
using BanqueRepositoryClass.Models;
using BanqueRepositoryClass.Tools;
using Microsoft.EntityFrameworkCore;

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
            return _dataContext.Accounts.Include(e => e.Operations).FirstOrDefault( e => e.Id == id);
        }

        public List<Account> FindAll()
        {
            return _dataContext.Accounts.Include(e => e.Customers).Include(e => e.Operations).ToList();
        }

        public bool Update(Account account)
        {
            _dataContext.Accounts.Update(account);
            //A vérfier après la pause
            return _dataContext.SaveChanges() > 0;
        }
    }
}
