using System.Collections.Generic;
using DxRep.Domain;
using DxRep.Repositories;

namespace DxRep.Services
{
    public interface ICoCooperationApplicationService : IService<CoCooperationApplication>
    {
        IEnumerable<CoCooperationApplication> FindByClause(int top, string @where = "", string orderBy = "");
    }
}
