using System.Configuration;
using SqlSugar;
using SqlSugar.Realization.SqlServer;

namespace DxRep.Infrastructure.Dba
{
    /// <summary>
    /// SqlSugar
    /// </summary>
    public class SqlServerConnection
    {
        private SqlServerConnection()
        {

        }
        public static string ConnectionString
        {
            get
            {
                var reval = ConfigurationManager.AppSettings["ConnectionString"];
                return reval;
            }
        }
        public static SqlSugarClient GetInstance()
        {
            var db = new SqlSugarClient(new SystemTableConfig{ ConnectionString = ConnectionString, DbType = DbType.SqlServer, IsAutoCloseConnection = true })
            {
                
            };
            //Enable log events
            return db;
        }
    }
}
