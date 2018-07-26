using JsonApiDotNetCore.Services;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace App
{
    public class ResourceGetAllService : IGetAllService<Resource>
    {
      public virtual async Task<IEnumerable<Resource>> GetAsync()
      {
        return null;
      }
    }
}