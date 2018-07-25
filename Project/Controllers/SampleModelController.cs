using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;

namespace _JADNC.App
{
  public class SampleModelController : JsonApiController<SampleModel>
  {
    public SampleModelController(
      IJsonApiContext jsonApiContext,
      IResourceService<SampleModel> resourceService,
      ILoggerFactory loggerFactory) 
      : base(jsonApiContext, resourceService, loggerFactory)
    { }
  }
}