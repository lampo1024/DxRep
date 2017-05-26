using System.Collections.Generic;

namespace DxRep.Repositories
{
    public interface IRepository<T>
    {
        T FindById(int id);

        IEnumerable<T> FindAll();
        IEnumerable<T> FindByClause(int top, string where, string orderBy);

        int Insert(T entity);

        bool Update(T entity);

        bool Delete(int id);

        bool Delete(string ids);

        bool Exsits();

    }
}
