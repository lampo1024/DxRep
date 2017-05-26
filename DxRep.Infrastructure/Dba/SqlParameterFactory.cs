using System.Data.SqlClient;

namespace DxRep.Infrastructure.Dba
{
    public class SqlParameterFactory
    {
        public static SqlParameter GetParameter
        {
            get
            {
                return new SqlParameter();
            }
        }
    }
}
