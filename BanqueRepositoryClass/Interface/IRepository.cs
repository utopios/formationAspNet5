using System;
using System.Collections.Generic;

namespace BanqueRepositoryClass.Interface
{
    public interface IRepository<T>
    {
        bool Create(T element);
        T Find(int id);
        List<T> FindAll();
    }
}
