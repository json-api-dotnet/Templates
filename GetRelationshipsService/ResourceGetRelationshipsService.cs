using System;
using JsonApiDotNetCore.Services;
using System.Threading.Tasks;

namespace App
{
    public class ResourceGetRelationshipsService : IGetRelationshipsService<Resource, TId>
    {
      public virtual async Task<object> GetRelationshipsAsync(TId id, string relationshipName)
      {
        throw new NotImplementedException();
      }
    }
}