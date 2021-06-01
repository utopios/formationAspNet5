using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using BanqueRepositoryClass.Interface;
using BanqueRepositoryClass.Models;
using BanqueRepositoryClass.Tools;
using Microsoft.EntityFrameworkCore;

namespace BanqueRepositoryClass.Repositorties
{
    public class OperationRepository : BaseRepository, IRepository<Operation>
    {
        public OperationRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public bool Create(Operation element)
        {
            throw new NotImplementedException();
        }

        public Operation Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Operation> FindAll()
        {
            Debug.WriteLine(_dataContext.Operations.Include(o => o.Account).ThenInclude(a => a.Customers).ToQueryString());
            return _dataContext.Operations.Include(o => o.Account).ThenInclude(a => a.Customers).ToList();
        }

        public bool Update(Operation element)
        {
            throw new NotImplementedException();
        }
    }
}
