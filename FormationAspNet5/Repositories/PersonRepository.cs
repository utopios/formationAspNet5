using System;
using System.Collections.Generic;
using System.Linq;
using FormationAspNet5.Interfaces;
using FormationAspNet5.Models;

namespace FormationAspNet5.Repositories
{
    public class PersonRepository : IRepository<Person>
    {
        private readonly DataContext _data;
        public PersonRepository(DataContext dataContext)
        {
            _data = dataContext;
        }

        public bool Create(Person element)
        {
            _data.Persons.Add(element);
            _data.SaveChanges();
            return element.Id > 0;
        }

        public IEnumerable<Person> FindAll()
        {
            return _data.Persons;
        }

        public Person FindById(int id)
        {
            return _data.Persons.Find(id);
        }

        public IEnumerable<Person> Search(Func<Person, bool> delegateSearch)
        {
            return _data.Persons.Where(delegateSearch);
        }
    }
}
