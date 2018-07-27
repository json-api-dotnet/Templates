using JsonApiDotNetCore.Services;
using System.Threading.Tasks;

namespace App
{
    public class ResourceCreateService : ICreateService<Resource, TId>
    {
      public virtual async Task<Resource> CreateAsync(Resource entity)
      {
        throw new NotImplementedException();
      }
    }
}