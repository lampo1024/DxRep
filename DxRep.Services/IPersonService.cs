using System.Collections.Generic;
using DxRep.Domain;

namespace DxRep.Services
{
    public interface IPersonService : IService<Person>
    {
        IEnumerable<Person> FindByClause(int top, string @where = "", string orderBy = "");
    }
}
