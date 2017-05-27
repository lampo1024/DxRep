using System.Collections.Generic;
using DxRep.Domain;
using DxRep.Repositories;

namespace DxRep.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _repository;
        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Person Insert(Person entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Person entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(Person entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Person> FindByClause(int top, string @where = "", string orderBy = "")
        {
            return _repository.FindByClause(top,@where,orderBy);
        }
    }
}
