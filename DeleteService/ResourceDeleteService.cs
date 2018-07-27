using JsonApiDotNetCore.Services;
using System.Threading.Tasks;

namespace App
{
    public class ResourceDeleteService : IDeleteService<Resource, TId>
    {
      public virtual async Task<bool> DeleteAsync(TId id)
      {
        throw new NotImplementedException();
      }
    }
}