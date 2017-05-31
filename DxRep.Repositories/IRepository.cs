using System.Collections.Generic;
using DxRep.Domain;
using DxRep.Infrastructure;

namespace DxRep.Repositories
{
    public interface IRepository<T>
    {
        T FindById(int id);

        IEnumerable<T> FindAll();
        //IEnumerable<T> FindByClause(int top, string where, string orderBy);
        IEnumerable<T> FindByClause(int top, string orderBy, string @where = "");

        IPagedList<T> FindPagedList(string orderBy, string @where, int pageIndex = 1,int pageSize = 20);

        int Insert(T entity);

        bool Update(T entity);

        bool Delete(int id);

        bool Delete(string ids);

        bool Exsits();

    }
}
