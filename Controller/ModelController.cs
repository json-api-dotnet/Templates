using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;

namespace App
{
  public class ModelController : JsonApiController<Model, TId>
  {
    public ModelController(
      IJsonApiContext jsonApiContext,
      IResourceService<Model, TId> resourceService,
      ILoggerFactory loggerFactory) 
      : base(jsonApiContext, resourceService, loggerFactory)
    { }
  }
}