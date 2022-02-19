using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace showdebola_api.repository.Repository.Base
{
    public class DBContext : IDBContext
    {
        public IDbConnection connection { get; set; }

        public DBContext(IConfiguration configuration)
        {
            connection = new SqliteConnection(configuration.GetConnectionString("conn"));
            connection.Open();
        }

        public void Dispose()
        {
            connection?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
