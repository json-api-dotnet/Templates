using System;
using JsonApiDotNetCore.Services;
using System.Threading.Tasks;

namespace App
{
    public class ResourceGetRelationshipService : IGetRelationshipService<Resource, TId>
    {
      public virtual async Task<object> GetRelationshipAsync(TId id, string relationshipName)
      {
        throw new NotImplementedException();
      }
    }
}