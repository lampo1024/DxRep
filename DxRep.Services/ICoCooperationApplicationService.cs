using System.Collections.Generic;
using DxRep.Domain;

namespace DxRep.Services
{
    public interface ICoCooperationApplicationService : IService<CoCooperationApplication>
    {
        IEnumerable<CoCooperationApplication> FindByClause(int top, string orderBy, string @where = "");
    }
}
