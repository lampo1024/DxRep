using System.Collections.Generic;
using DxRep.Domain;
using DxRep.Repositories;

namespace DxRep.Services
{
    public class CoCooperationApplicationService : ICoCooperationApplicationService
    {
        private readonly ICoCooperationApplicationRepository _repository;
        public CoCooperationApplicationService(ICoCooperationApplicationRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<CoCooperationApplication> FindAll()
        {
            return _repository.FindAll();
        }

        public CoCooperationApplication FindById(int id)
        {
            return _repository.FindById(id);
        }

        public CoCooperationApplication Insert(CoCooperationApplication entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(CoCooperationApplication entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(CoCooperationApplication entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CoCooperationApplication> FindByClause(int top, string @where = "", string orderBy = "")
        {
            return _repository.FindByClause(top,@where,orderBy);
        }
    }
}
