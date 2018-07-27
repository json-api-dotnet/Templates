using JsonApiDotNetCore.Services;
using System.Threading.Tasks;

namespace App
{
    public class ModelCmdService : IResourceCmdService<Model, TId>
    {
      public virtual async Task<Model> CreateAsync(Model entity)
      {
        throw new NotImplementedException();
      }

      public virtual async Task<Model> UpdateAsync(TId id, Model entity)
      {
        throw new NotImplementedException();
      }

      public virtual async Task UpdateRelationshipsAsync(TId id, string relationshipName, List<DocumentData> relationships)
      {
        throw new NotImplementedException();
      }

      public virtual async Task<bool> DeleteAsync(TId id)
      {
        throw new NotImplementedException();
      }
    }
}