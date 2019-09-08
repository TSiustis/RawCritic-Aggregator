using Newtonsoft.Json;

namespace RawCritic2.Models
{
  public class PlatformVersion
  {
    public string Connectivity { get; set; }
    [JsonProperty("cpu")]
    public string CPU { get; set; }
    public string Graphics { get; set; }
    public int? Id { get; set; }
    public string Media { get; set; }
    public string Memory { get; set; }
    public string Name { get; set; }
    [JsonProperty("os")]
    public string OS { get; set; }
    public string Output { get; set; }
    public IdentityOrValue<PlatformLogo> PlatformLogo { get; set; }
    public string Resolutions { get; set; }
    public string Slug { get; set; }
    public string Sound { get; set; }
    public string Storage { get; set; }
    public string Summary { get; set; }
    public string Url { get; set; }
  }
}