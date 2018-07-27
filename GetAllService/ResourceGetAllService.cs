using JsonApiDotNetCore.Services;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace App
{
    public class ResourceGetAllService : IGetAllService<Resource, TId>
    {
      public virtual async Task<IEnumerable<Resource>> GetAsync()
      {
        throw new NotImplementedException();
      }
    }
}