using System;
using System.Collections;
using System.Collections.Generic;

namespace FormationAspNet5.Interfaces
{
    public interface IRepository<T>
    {
        bool Create(T element);

        IEnumerable<T> FindAll();

        T FindById(int id);

        IEnumerable<T> Search(Func<T, bool> delegateSearch);
    }
}
