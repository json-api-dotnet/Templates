using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;

namespace App
{
  public class ModelController : JsonApiController<Model>
  {
    public ModelController(
      IJsonApiContext jsonApiContext,
      IResourceService<Model> resourceService,
      ILoggerFactory loggerFactory) 
      : base(jsonApiContext, resourceService, loggerFactory)
    { }
  }
}