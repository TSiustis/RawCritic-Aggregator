using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawCritic.Web.Models
{
    public class Title : ITimeStamps
    {
        public DateTimeOffset? CreatedAt { get; set; }
        public string Description { get; set; }
        public IdentitiesOrValues<Game> Games { get; set; }
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public string Url { get; set; }

    }
}
