using System.Collections.Generic;
using System.Data;
using System.Text;
using DxRep.Core.Extensions;
using DxRep.Infrastructure.Dba;

namespace DxRep.Repositories
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
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
            paraPrimaryKey.DbType = DbType.String;

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

        public virtual IEnumerable<T> FindByClause(int top, string @where, string orderBy)
        {
            throw new System.NotImplementedException();
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
