using System;
using JsonApiDotNetCore.Services;
using System.Threading.Tasks;

namespace App
{
    public class ResourceGetByIdService : IGetByIdService<Resource, TId>
    {
      public virtual async Task<Resource> GetAsync(TId id)
      {
        throw new NotImplementedException();
      }
    }
}