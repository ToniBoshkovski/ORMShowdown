using Microsoft.Data.SqlClient;
using System.Data;

namespace ORMShowdown
{
    public class DapperContext
    {
        public IDbConnection CreateConnection() => new SqlConnection("Server=.; Initial Catalog=ORMShowdown; MultipleActiveResultSets=true; Integrated Security=true;");
    }
}