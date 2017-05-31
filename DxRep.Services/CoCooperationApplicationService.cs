using System.Collections.Generic;
using DxRep.Domain;
using DxRep.Infrastructure;
using DxRep.Repositories;

namespace DxRep.Services
{
    public class CoCooperationApplicationService : GenericService<CoCooperationApplication>, ICoCooperationApplicationService
    {
        private readonly ICoCooperationApplicationRepository _repository;
        public CoCooperationApplicationService(ICoCooperationApplicationRepository repository) : base(repository)
        {
            _repository = repository;
        }
       

        public IEnumerable<CoCooperationApplication> FindByClause(int top, string orderBy, string @where = "")
        {
            return _repository.FindByClause(top, orderBy, @where);
        }
    }
}
