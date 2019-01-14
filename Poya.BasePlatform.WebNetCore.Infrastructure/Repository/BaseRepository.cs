using Poya.BasePlatform.WebNetCore.Infrastructure.Options;
using System.Data;

namespace Poya.BasePlatform.WebNetCore.Infrastructure.Repository
{
    public class BaseRepository<T, TKey> : IBaseRepository<T, TKey> where T : class
    {
        protected DbOpion _dbOpion;
        protected IDbConnection _dbConnection;


        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
