using System.Collections.Generic;
using DxRep.Domain;
using DxRep.Infrastructure.Dba;
using System.Linq;

namespace DxRep.Repositories
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public override IEnumerable<Person> FindByClause(int top, string orderBy, string @where = "")
        {

            using (var db = MySqlConnection.GetInstance())
            {
                /*
                var list = db.Queryable<T>();
                if (!string.IsNullOrEmpty(@where))
                {
                    list=list.Where(@where);
                }
                list = list.OrderBy(orderBy).Take(top);
                */
                var sable = db.Queryable<Person>("t");
                if (!string.IsNullOrEmpty(@where))
                {
                    sable = sable.Where(@where);
                }
                var totalCount = sable.Count();
                var list = sable.OrderBy(orderBy).ToPageList(0, 2);
                return list.ToList();
            }

        }
    }

}
