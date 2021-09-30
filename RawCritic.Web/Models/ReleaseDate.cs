using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawCritic.Web.Models
{
    public class ReleaseDate : ITimeStamps
    {
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? Date { get; set; }
        public IdentityOrValue<Game> Game { get; set; }
        public int? Id { get; set; }
        public string Human { get; set; }
        [JsonProperty("m")]
        public int? Month { get; set; }
        public IdentityOrValue<Platform> Platform { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        [JsonProperty("y")]
        public int? Year { get; set; }
    }
}
