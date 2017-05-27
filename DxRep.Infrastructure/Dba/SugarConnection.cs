using System.Configuration;
using SqlSugar;

namespace DxRep.Infrastructure.Dba
{
    /// <summary>
    /// SqlSugar
    /// </summary>
    public class SugarConnection
    {
        private SugarConnection()
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
