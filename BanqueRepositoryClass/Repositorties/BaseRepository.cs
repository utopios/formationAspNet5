using System;
using BanqueRepositoryClass.Tools;

namespace BanqueRepositoryClass.Repositorties
{
    public abstract class BaseRepository
    {
        protected readonly DataContext _dataContext;
        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public virtual bool Update()
        {
            return _dataContext.SaveChanges() > 0;
        }
    }
}
