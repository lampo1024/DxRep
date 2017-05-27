using System.Collections.Generic;
using DxRep.Domain;
using DxRep.Repositories;

namespace DxRep.Services
{
    public class CoBusinessPersonnelService : ICoBusinessPersonnelService
    {
        private readonly ICoBusinessPersonnelRepository _repository;
        public CoBusinessPersonnelService(ICoBusinessPersonnelRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<CoBusinessPersonnel> FindAll()
        {
            return _repository.FindAll();
        }

        public CoBusinessPersonnel FindById(int id)
        {
            return _repository.FindById(id);
        }

        public CoBusinessPersonnel Insert(CoBusinessPersonnel entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(CoBusinessPersonnel entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(CoBusinessPersonnel entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CoBusinessPersonnel> FindByClause(int top, string @where = "", string orderBy = "")
        {
            return _repository.FindByClause(top,@where,orderBy);
        }
    }
}
