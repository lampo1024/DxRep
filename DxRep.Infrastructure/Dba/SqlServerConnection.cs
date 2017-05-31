using System.Configuration;

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
    }
}
