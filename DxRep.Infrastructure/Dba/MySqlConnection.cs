using System.Configuration;
using SqlSugar;
using SqlSugar.Realization.SqlServer;

namespace DxRep.Infrastructure.Dba
{
    /// <summary>
    /// SqlSugar
    /// </summary>
    public class MySqlConnection
    {
        private MySqlConnection()
        {

        }
        public static string ConnectionString
        {
            get
            {
                var reval = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
                return reval;
            }
        }
        public static SqlSugarClient GetInstance()
        {
            var db = new SqlSugarClient(new SystemTableConfig{ ConnectionString = ConnectionString, DbType = DbType.MySql, IsAutoCloseConnection = true })
            {
                
            };
            //Enable log events
            return db;
        }
    }
}
