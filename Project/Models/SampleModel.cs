using JsonApiDotNetCore.Models;

namespace _JADNC.App
{
  public class SampleModel : Identifiable
  {
    [Attr("string-data")]
    public string StringData { get; set; }

    [Attr("integer-data")]
    public int IntegerData { get; set; }
  }
}