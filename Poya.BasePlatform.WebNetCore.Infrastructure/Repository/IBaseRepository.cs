using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poya.BasePlatform.WebNetCore.Infrastructure.Repository
{
    public interface IBaseRepository<T,TKey> :  IDisposable where T : class
    {
      
    }
}
