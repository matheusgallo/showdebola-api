using System.Data;

namespace showdebola_api.repository.Repository.Base
{
    public interface IDBContext : IDisposable
    {
        IDbConnection connection { get; }
    }
}
