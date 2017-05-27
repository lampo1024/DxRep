using System.Collections.Generic;
using DxRep.Domain;

namespace DxRep.Services
{
    public interface ICoBusinessPersonnelService :IService<CoBusinessPersonnel>
    {
        IEnumerable<CoBusinessPersonnel> FindByClause(int top, string @where = "", string orderBy = "");
    }
}
