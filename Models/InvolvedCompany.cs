using System;

namespace RawCritic2.Models
{
  public class InvolvedCompany : ITimestamps
  {
    public DateTimeOffset? CreatedAt { get; set; }
    public bool? Developer { get; set; }
    public IdentityOrValue<Game> Game { get; set; }
    public int? Id { get; set; }
    public bool? Porting { get; set; }
    public bool? Publisher { get; set; }
    public bool? Supporting { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
  }
}