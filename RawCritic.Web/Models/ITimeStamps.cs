using System;

namespace RawCritic.Web.Models
{
    public interface ITimeStamps
    {
        DateTimeOffset? CreatedAt { get; set; }
        DateTimeOffset? UpdatedAt { get; set; }
    }
}