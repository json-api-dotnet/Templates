using JsonApiDotNetCore.Services;
using System.Threading.Tasks;
using JsonApiDotNetCore.Models;

namespace App
{
    public class ResourceUpdateRelationshipService : IUpdateRelationshipService<Resource, TId>
    {
      public virtual async Task UpdateRelationshipsAsync(TId id, string relationshipName, List<DocumentData> relationships)
      {
        throw new NotImplementedException();
      }
    }
}