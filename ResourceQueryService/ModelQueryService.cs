using JsonApiDotNetCore.Services;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace App
{
    public class ModelQueryService : IResourceQueryService<Model, TId>
    {
      public virtual async Task<IEnumerable<Model>> GetAsync()
      {
        throw new NotImplementedException();
      }

      public virtual async Task<Model> GetAsync(TId id)
      {
        throw new NotImplementedException();
      }

      public virtual async Task<object> GetRelationshipAsync(TId id, string relationshipName)
      {
        throw new NotImplementedException();
      }

      public virtual async Task<object> GetRelationshipsAsync(TId id, string relationshipName)
      {
        throw new NotImplementedException();
      }
    }
}