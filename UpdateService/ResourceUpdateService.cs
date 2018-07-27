using JsonApiDotNetCore.Services;
using System.Threading.Tasks;

namespace App
{
    public class ResourceUpdateService : IUpdateService<Resource, TId>
    {
      public virtual async Task<Resource> UpdateAsync(TId id, Resource entity)
      {
        throw new NotImplementedException();
      }
    }
}