using System;

namespace RawCritic2.Models
{
  public class Keyword : ITimestamps
  {
    public DateTimeOffset? CreatedAt { get; set; }
    public int? Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public string Url { get; set; }
  }
}