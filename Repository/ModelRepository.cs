using JsonApiDotNetCore.Services;
using JsonApiDotNetCore.Data;
using Microsoft.Extensions.Logging;

namespace App
{
  public class ModelRepository : DefaultEntityRepository<Model, TId>
  {
    public ModelRepository(
      ILoggerFactory loggerFactory,
      IJsonApiContext jsonApiContext,
      IDbContextResolver contextResolver)
      : base(loggerFactory, jsonApiContext, contextResolver)
    { }
  }
}