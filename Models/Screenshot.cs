namespace RawCritic2.Models
{
  public class Screenshot
  {
    public bool? AlphaChannel { get; set; }
    public bool? Animated { get; set; }
    public IdentityOrValue<Game> Game { get; set; }
    public int? Height { get; set; }
    public int? Id { get; set; }
    public string ImageId { get; set; }
    public string Url { get; set; }
    public int? Width { get; set; }
  }
}