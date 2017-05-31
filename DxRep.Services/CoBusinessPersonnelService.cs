using System.Collections.Generic;
using DxRep.Domain;
using DxRep.Repositories;

namespace DxRep.Services
{
    public class CoBusinessPersonnelService : GenericService<CoBusinessPersonnel>, ICoBusinessPersonnelService
    {
        private readonly ICoBusinessPersonnelRepository _repository;
        public CoBusinessPersonnelService(ICoBusinessPersonnelRepository repository) : base(repository)
        {
            _repository = repository;
        }
        
        public IEnumerable<CoBusinessPersonnel> FindByClause(int top, string @where = "", string orderBy = "")
        {
            return _repository.FindByClause(top, @where, orderBy);
        }
    }
}
