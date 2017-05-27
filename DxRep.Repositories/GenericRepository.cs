using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DxRep.Core.Extensions;
using DxRep.Infrastructure.Dba;
using SqlSugar;

namespace DxRep.Repositories
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class, new()
    {
        public virtual T FindById(int id)
        {
            var type = typeof(T);
            var propMapping = type.Mapping();
            var strSql = new StringBuilder();
            strSql.AppendFormat("SELECT {0}", propMapping.PropertiesString);
            strSql.AppendFormat(" FROM {0}", propMapping.ClassName);
            strSql.AppendFormat(" WHERE {0}=@PrimaryKey", propMapping.PrimaryKey);
            var paraPrimaryKey = SqlParameterFactory.GetParameter;
            paraPrimaryKey.ParameterName = "@PrimaryKey";
            paraPrimaryKey.Value = id;
            paraPrimaryKey.DbType = System.Data.DbType.String;

            var ds = DbHelperSql.Query(strSql.ToString(), paraPrimaryKey);
            return ds.Tables[0].ToEntity<T>();
        }

        public virtual IEnumerable<T> FindAll()
        {
            var type = typeof(T);
            var propMapping = type.Mapping();

            var strSql = new StringBuilder();
            strSql.AppendFormat("SELECT {0}", propMapping.PropertiesString);
            strSql.AppendFormat(" FROM {0}", propMapping.ClassName);

            var ds = DbHelperSql.Query(strSql.ToString());
            return ds.Tables[0].ToList<T>();
        }

        public virtual IEnumerable<T> FindByClause(int top, string orderBy, string @where = "")
        {
            using (var db = SugarConnection.GetInstance())
            {
                /*
                var list = db.Queryable<T>();
                if (!string.IsNullOrEmpty(@where))
                {
                    list=list.Where(@where);
                }
                list = list.OrderBy(orderBy).Take(top);
                */
                var sable = db.Queryable<T>("t");
                if (!string.IsNullOrEmpty(@where))
                {
                    sable = sable.Where(@where);
                }
                var totalCount = sable.Count();
                var list = sable.OrderBy(orderBy).ToPageList(0, 2);
                return list.ToList();
            }

        }

        public virtual int Insert(T entity)
        {
            throw new System.NotImplementedException();
        }

        public virtual bool Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public virtual bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public virtual bool Delete(string ids)
        {
            throw new System.NotImplementedException();
        }

        public virtual bool Exsits()
        {
            throw new System.NotImplementedException();
        }
    }
}
