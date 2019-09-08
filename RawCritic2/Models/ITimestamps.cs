using System;

namespace RawCritic2.Models
{
  public interface ITimestamps
  {
    DateTimeOffset? CreatedAt { get; set; }
    DateTimeOffset? UpdatedAt { get; set; }
  }
}