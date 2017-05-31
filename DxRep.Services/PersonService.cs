using System.Collections.Generic;
using DxRep.Domain;
using DxRep.Repositories;

namespace DxRep.Services
{
    public class PersonService : GenericService<Person>, IPersonService
    {
        private readonly IPersonRepository _repository;
        public PersonService(IPersonRepository repository) : base(repository)
        {
            _repository = repository;
        }
        public IEnumerable<Person> FindByClause(int top, string @where = "", string orderBy = "")
        {
            return _repository.FindByClause(top, @where, orderBy);
        }
    }
}
